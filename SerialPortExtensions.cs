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
		public static void MoveMotor(this SerialPort port, char identifier, int steps)
		{
			if (port != null && port.IsOpen)
			{
				steps = Math.Min(127, steps);
				steps = Math.Max(-127, steps);

				port.Write(new byte[] { (byte)identifier, (byte)(steps + 128) }, 0, 2);
			}
		}
	}
}
