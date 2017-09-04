using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hotwire
{
	[Serializable]
	public class Profile : INotifyPropertyChanged
	{
		[NonSerialized]
		private static Regex profileDataRegex = new Regex(@"^\s*(?<xvalue>-?\d*((\.|\,)\d+)?)\s+(?<yvalue>-?\d*((\.|\,)\d+)?)\s*$", RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace | RegexOptions.Singleline);

		[field: NonSerialized]
		public event PropertyChangedEventHandler PropertyChanged;

		private double _strengthFactor = 1.0;
		private string _fileName;

		private string _name;

		Vector2[] _data = null;

		private string ReplacePoint(string value)
		{
			return value.Replace(',', '.');
		}

		private IEnumerable<Vector2> LoadProfile(string fileName)
		{
			IEnumerable<string> lines = File.ReadLines(fileName);
			int count = 0;
			foreach (string line in lines)
			{
				Match match = profileDataRegex.Match(line);
				if (match.Success)
				{
					double x = double.Parse(ReplacePoint(match.Groups["xvalue"].Value), NumberStyles.Any, CultureInfo.InvariantCulture);
					double y = double.Parse(ReplacePoint(match.Groups["yvalue"].Value), NumberStyles.Any, CultureInfo.InvariantCulture);
					++count;

					yield return new Vector2(x, y);
				}
			}
			if (count > 0)
				_name = lines.First().Trim();
			else
				throw new Exception("Failed to import data");
		}

		[Browsable(false)]
		public string Name
		{
			get
			{
				return _name;
			}
		}

		[EditorAttribute(typeof(System.Windows.Forms.Design.FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
		public string FileName
		{
			get
			{
				return _fileName;
			}
			set
			{
				if (_fileName != value)
				{
					_data = LoadProfile(value).ToArray();

					_fileName = value;
					OnPropertyChanged();
				}
			}
		}

		public double StrengthFactor
		{
			get
			{
				return _strengthFactor;
			}
			set
			{
				if (_strengthFactor != value)
				{
					_strengthFactor = value;
					OnPropertyChanged();
				}
			}
		}

		public Vector2[] Data
		{
			get
			{
				if (_data != null)
					return _data.Select(v => new Vector2(v.x, v.y * _strengthFactor)).ToArray();

				return null;
			}
		}

		protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = "")
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}

		public override string ToString()
		{
			if (!string.IsNullOrEmpty(_name))
				return _name;

			return "<undefined>";
		}
	}
}
