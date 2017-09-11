using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotwire
{
	public class HotwireControl
	{
		public event EventHandler AfterMovement;
		private Configuration _configuration;
		private SerialPort _port;

		public HotwireControl(Configuration configuration, SerialPort port)
		{
			_configuration = configuration;
			_port = port;
		}

		public static short Invert(decimal value, bool configuration, bool invert)
		{
			short steps = (short)value;
			if ((invert && !configuration) || (configuration && !invert))
				steps = (short)(-steps);

			return steps;
		}

		public void MoveRelative(double x, double y)
		{
			x = _configuration.X + x;
			y = _configuration.Y + y;

			MoveAbsolute(x, y);
		}

		public void MoveAbsolute(double x, double y)
		{
			Vector2 vec = new Vector2(x, y) - new Vector2(-_configuration.SpoolDiameter / 2, 0);
			double newLenA = vec.Length;

			vec = new Vector2(x, y) - new Vector2(_configuration.LeftDistance + _configuration.SpoolDiameter / 2, 0);
			double newLenB = vec.Length;

			double lenDiffA = newLenA - _configuration.LengthA;
			double lenDiffB = newLenB - _configuration.LengthB;

			// Invert due to orientation of steppers
			double stepsA = -(lenDiffA / 10 /*cm*/ ) * _configuration.StepsA;
			double stepsB = -(lenDiffB / 10 /*cm*/ ) * _configuration.StepsB;

			if (_configuration.ReverseA)
				stepsA = -stepsA;
			if (_configuration.ReverseB)
				stepsB = -stepsB;

			_port.MoveMotors((short)stepsA, (short)stepsB, 0, 0);

			_configuration.X = x;
			_configuration.Y = y;
			_configuration.LengthA = newLenA;
			_configuration.LengthB = newLenB;

			OnAfterMovement();
		}

		protected virtual void OnAfterMovement()
		{
			if (AfterMovement != null)
				AfterMovement(this, EventArgs.Empty);
		}
	}
}
