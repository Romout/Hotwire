using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotwire
{
	public static class SerialPortExtensions
	{
		private static void Send(SerialPort port, params byte[] data)
		{
			if (port != null && port.IsOpen)
				port.Write(data, 0, data.Length);
		}
		public static void MoveMotor(this SerialPort port, byte identifier, short steps)
		{
			Send(port, (byte)identifier, (byte)((steps & 0x0ff00) >> 8), (byte)(steps & 0x0ff));
		}

		public static void MoveMotors(this SerialPort port, short steps0, short steps1, short steps2, short steps3)
		{
			Send(port, 0,
					(byte)((steps0 & 0x0ff00) >> 8), (byte)(steps0 & 0x0ff),
					(byte)((steps1 & 0x0ff00) >> 8), (byte)(steps1 & 0x0ff),
					(byte)((steps2 & 0x0ff00) >> 8), (byte)(steps2 & 0x0ff),
					(byte)((steps3 & 0x0ff00) >> 8), (byte)(steps3 & 0x0ff));
		}

		public static void StopMotors(this SerialPort port)
		{
			Send(port, 5);
		}
		public static void StopMotor(this SerialPort port, byte identifier)
		{
			Send(port, 6, (byte)identifier);
		}
	}
}
