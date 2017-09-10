using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotwire
{
	[Serializable]
	public class Configuration
	{
		private double _leftDistance;
		private double _rightDistance;
		private double _frontDistance;
		private double _backDistance;
		private double _spoolDiameter;

		private double _originA;
		private double _originB;
		private double _originC;
		private double _originD;

		private double _originOffsetX;
		private double _originOffsetY;

		private bool _reverseA;
		private bool _reverseB;
		private bool _reverseC;
		private bool _reverseD;

		private double _stepsA;
		private double _stepsB;
		private double _stepsC;
		private double _stepsD;

		private double _lengthA;
		private double _lengthB;
		private double _lengthC;
		private double _lengthD;

		private double _x;
		private double _y;

		public double LeftDistance
		{
			get
			{
				return _leftDistance;
			}
			set
			{
				_leftDistance = value;
			}
		}
		public double RightDistance
		{
			get
			{
				return _rightDistance;
			}
			set
			{
				_rightDistance = value;
			}
		}
		public double FrontDistance
		{
			get
			{
				return _frontDistance;
			}
			set
			{
				_frontDistance = value;
			}
		}
		public double BackDistance
		{
			get
			{
				return _backDistance;
			}
			set
			{
				_backDistance = value;
			}
		}
		public double SpoolDiameter
		{
			get
			{
				return _spoolDiameter;
			}
			set
			{
				_spoolDiameter = value;
			}
		}

		public bool ReverseA
		{
			get
			{
				return _reverseA;
			}

			set
			{
				_reverseA = value;
			}
		}

		public bool ReverseB
		{
			get
			{
				return _reverseB;
			}

			set
			{
				_reverseB = value;
			}
		}

		public bool ReverseC
		{
			get
			{
				return _reverseC;
			}

			set
			{
				_reverseC = value;
			}
		}

		public bool ReverseD
		{
			get
			{
				return _reverseD;
			}

			set
			{
				_reverseD = value;
			}
		}

		public double OriginA
		{
			get
			{
				return _originA;
			}

			set
			{
				_originA = value;
			}
		}

		public double OriginB
		{
			get
			{
				return _originB;
			}

			set
			{
				_originB = value;
			}
		}

		public double OriginC
		{
			get
			{
				return _originC;
			}

			set
			{
				_originC = value;
			}
		}

		public double OriginD
		{
			get
			{
				return _originD;
			}

			set
			{
				_originD = value;
			}
		}

		public double LengthA
		{
			get
			{
				return _lengthA;
			}

			set
			{
				_lengthA = value;
			}
		}

		public double LengthB
		{
			get
			{
				return _lengthB;
			}

			set
			{
				_lengthB = value;
			}
		}

		public double LengthC
		{
			get
			{
				return _lengthC;
			}

			set
			{
				_lengthC = value;
			}
		}

		public double LengthD
		{
			get
			{
				return _lengthD;
			}

			set
			{
				_lengthD = value;
			}
		}

		public double OriginOffsetX
		{
			get
			{
				return _originOffsetX;
			}

			set
			{
				_originOffsetX = value;
			}
		}

		public double OriginOffsetY
		{
			get
			{
				return _originOffsetY;
			}

			set
			{
				_originOffsetY = value;
			}
		}

		public double X
		{
			get
			{
				return _x;
			}

			set
			{
				_x = value;
			}
		}

		public double Y
		{
			get
			{
				return _y;
			}

			set
			{
				_y = value;
			}
		}

		public double StepsA
		{
			get
			{
				return _stepsA;
			}

			set
			{
				_stepsA = value;
			}
		}

		public double StepsB
		{
			get
			{
				return _stepsB;
			}

			set
			{
				_stepsB = value;
			}
		}

		public double StepsC
		{
			get
			{
				return _stepsC;
			}

			set
			{
				_stepsC = value;
			}
		}

		public double StepsD
		{
			get
			{
				return _stepsD;
			}

			set
			{
				_stepsD = value;
			}
		}
	}
}
