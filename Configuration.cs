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

		private bool _reverseA;
		private bool _reverseB;
		private bool _reverseC;
		private bool _reverseD;

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
	}
}
