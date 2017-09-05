using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotwire
{
	public partial class PreviewPanel : UserControl
	{
		public PreviewPanel()
		{
			InitializeComponent();

			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			SetStyle(ControlStyles.ResizeRedraw, true);
			SetStyle(ControlStyles.UserPaint, true);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.Clear(Color.White);
			if (Data == null)
				return;

			double minx = double.MaxValue;
			double maxx = double.MinValue;
			double miny = double.MaxValue;
			double maxy = double.MinValue;

			IEnumerable<Vector2> leftProfile = null;
			if (Data.LeftProfile != null)
				leftProfile = Data.LeftProfile.Data.Select(v => v * Data.ScaleLeft + new Vector2(Data.LeftXOffset, Data.LeftYOffset));

			IEnumerable<Vector2> rightProfile = null;
			if (Data.RightProfile != null)
				rightProfile = Data.RightProfile.Data.Select(v => v * Data.ScaleRight + new Vector2(Data.RightXOffset, Data.RightYOffset));

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

			double scale = Width / (maxx - minx);
			double height = (maxy - miny) * scale;

			if (leftProfile != null)
			{
				DrawProfile(leftProfile, Pens.Green, minx, miny, height, scale, e);
			}

			if (rightProfile != null)
			{
				DrawProfile(rightProfile, Pens.Blue, minx, miny, height, scale, e);
			}
		}

		private void DrawProfile(IEnumerable<Vector2> profile, Pen pen, double minx, double miny, double height, double scale, PaintEventArgs e)
		{
			Vector2 last = null;
			foreach(Vector2 vec in profile)
			{
				Vector2 point = (vec - new Vector2(minx, miny)) * scale;
				point.y = (Height + height / 2) / 2 - point.y;
				if (last != null)
				{
					e.Graphics.DrawLine(pen, last, point);
				}
				last = point;
			}
		}

		public Data Data { get; set; }
	}
}
