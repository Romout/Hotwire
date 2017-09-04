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
		private string _leftInputPath;
		private string _rightInputPath;

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
	}
}
