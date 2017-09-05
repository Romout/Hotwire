using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotwire
{
	[Serializable]
	public class Data
	{
		private Profile _leftProfile;
		private Profile _rightProfile;

		private string _leftInputPath;
		private string _rightInputPath;

		private double _scaleLeft;
		private double _leftXOffset;
		private double _leftYOffset;

		private double _scaleRight;
		private double _rightXOffset;
		private double _rightYOffset;

		public Profile LeftProfile
		{
			get
			{
				return _leftProfile;
			}
			set
			{
				_leftProfile = value;
			}
		}

		public Profile RightProfile
		{
			get
			{
				return _rightProfile;
			}
			set
			{
				_rightProfile = value;
			}
		}
		public string LeftInputPath
		{
			get
			{
				return _leftInputPath;
			}
			set
			{
				_leftInputPath = value;
			}
		}

		public string RightInputPath
		{
			get
			{
				return _rightInputPath;
			}
			set
			{
				_rightInputPath = value;
			}
		}

		public double ScaleLeft
		{
			get
			{
				return _scaleLeft;
			}

			set
			{
				_scaleLeft = value;
			}
		}

		public double LeftXOffset
		{
			get
			{
				return _leftXOffset;
			}

			set
			{
				_leftXOffset = value;
			}
		}

		public double LeftYOffset
		{
			get
			{
				return _leftYOffset;
			}

			set
			{
				_leftYOffset = value;
			}
		}

		public double ScaleRight
		{
			get
			{
				return _scaleRight;
			}

			set
			{
				_scaleRight = value;
			}
		}

		public double RightXOffset
		{
			get
			{
				return _rightXOffset;
			}

			set
			{
				_rightXOffset = value;
			}
		}

		public double RightYOffset
		{
			get
			{
				return _rightYOffset;
			}

			set
			{
				_rightYOffset = value;
			}
		}
	}
}
