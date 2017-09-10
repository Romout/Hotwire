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

		private double _scaleLeft = 1.0;
		private double _leftXOffset = 0;
		private double _leftYOffset = 0;

		private double _scaleRight = 1.0;
		private double _rightXOffset = 0;
		private double _rightYOffset = 0;

		private Vector2 _origin = new Vector2();
		private double _viewScale = 1.0;

		public void ProcessProfiles(int displayWidth, out IEnumerable<Vector2> leftProfile, out IEnumerable<Vector2> rightProfile, out double minx, out double maxx, out double miny, out double maxy, out double scale, out double width, out double height)
		{
			minx = double.MaxValue;
			maxx = double.MinValue;
			miny = double.MaxValue;
			maxy = double.MinValue;

			leftProfile = null;
			if (_leftProfile != null)
				leftProfile = _leftProfile.Data.Select(v => v * _scaleLeft + new Vector2(_leftXOffset, _leftYOffset));

			rightProfile = null;
			if (_rightProfile != null)
				rightProfile = _rightProfile.Data.Select(v => v * _scaleRight + new Vector2(_rightXOffset, _rightYOffset));

			if (leftProfile != null)
			{
				minx = leftProfile.Select(v => v.x).Min();
				maxx = leftProfile.Select(v => v.x).Max();
				miny = leftProfile.Select(v => v.y).Min();
				maxy = leftProfile.Select(v => v.y).Max();
			}

			if (rightProfile != null)
			{
				minx = Math.Min(minx, rightProfile.Select(v => v.x).Min());
				maxx = Math.Max(maxx, rightProfile.Select(v => v.x).Max());
				miny = Math.Min(miny, rightProfile.Select(v => v.y).Min());
				maxy = Math.Max(maxy, rightProfile.Select(v => v.y).Max());
			}

			scale = displayWidth / (maxx - minx) / _viewScale;
			width = (maxx - minx) * scale;
			height = (maxy - miny) * scale;
		}


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

		public double ViewScale
		{
			get
			{
				return _viewScale;
			}

			set
			{
				_viewScale = value;
			}
		}

		public Vector2 Origin
		{
			get
			{
				return _origin;
			}
			set
			{
				_origin = value;
			}
		}
	}
}
