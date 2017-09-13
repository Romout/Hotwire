using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hotwire
{
	public class HotwirePort : SerialPort, IDisposable
	{
		public event Action DataAvailable;
		public event Action NewDataLineAvailable;

		private Dictionary<byte, Action> _triggers = new Dictionary<byte, Action>();
		private List<byte> _readData = new List<byte>();
		private Thread _thread;
		private bool _listen;
		private ManualResetEvent _notify = new ManualResetEvent(false);

		public HotwirePort(string portName, int baudRate)
			: base(portName, baudRate)
		{
			_thread = new Thread(PortListener);
			_thread.IsBackground = true;
			_thread.Start();
		}

		private void TestInternalTriggers(byte read)
		{
			if (read == 254)
				_notify.Set();
		}

		private void PortListener()
		{
			_listen = true;
			while (_listen)
			{
				if (IsOpen)
				{
					try
					{
						while (BytesToRead > 0)
						{
							byte read = (byte)ReadByte();
							lock (_readData)
								_readData.Add(read);

							TestInternalTriggers(read);

							Action action;
							if (_triggers.TryGetValue(read, out action))
								action();

							if (read == 13)
								OnNewDataLineAvailable();
						}
						OnDataAvailable();
					}
					catch
					{ }
				}
				Thread.Sleep(10);
			}
		}

		internal void ClearData()
		{
			lock (_readData)
				_readData.Clear();
		}

		public byte[] GetData()
		{
			lock (_readData)
				return _readData.ToArray();
		}

		public void RegisterHook(byte trigger, Action action)
		{
			_triggers.Add(trigger, action);
		}

		public void UnregisterHook(byte trigger)
		{
			_triggers.Remove(trigger);
		}

		private void Send(params byte[] data)
		{
			if (IsOpen)
				Write(data, 0, data.Length);
		}
		public void MoveMotor(byte identifier, short steps)
		{
			_notify.Reset();
			Send((byte)identifier, (byte)((steps & 0x0ff00) >> 8), (byte)(steps & 0x0ff));
			_notify.WaitOne(5000);
		}

		public void MoveMotors(short steps0, short steps1, short steps2, short steps3)
		{
			_notify.Reset();
			Send(0,
					(byte)((steps0 & 0x0ff00) >> 8), (byte)(steps0 & 0x0ff),
					(byte)((steps1 & 0x0ff00) >> 8), (byte)(steps1 & 0x0ff),
					(byte)((steps2 & 0x0ff00) >> 8), (byte)(steps2 & 0x0ff),
					(byte)((steps3 & 0x0ff00) >> 8), (byte)(steps3 & 0x0ff));
			_notify.WaitOne(5000);
		}

		public void SetStepDelays(short delay0, short delay1, short delay2, short delay3)
		{
			Send(7,
					(byte)((delay0 & 0x0ff00) >> 8), (byte)(delay0 & 0x0ff),
					(byte)((delay1 & 0x0ff00) >> 8), (byte)(delay1 & 0x0ff),
					(byte)((delay2 & 0x0ff00) >> 8), (byte)(delay2 & 0x0ff),
					(byte)((delay3 & 0x0ff00) >> 8), (byte)(delay3 & 0x0ff));
		}

		public void StopMotors()
		{
			Send(5);
		}
		public void StopMotor(byte identifier)
		{
			Send(6, (byte)identifier);
		}

		protected virtual void OnDataAvailable()
		{
			if (DataAvailable != null)
				DataAvailable();
		}

		protected virtual void OnNewDataLineAvailable()
		{
			if (NewDataLineAvailable != null)
				NewDataLineAvailable();
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);

			_triggers.Clear();
		}
	}
}
