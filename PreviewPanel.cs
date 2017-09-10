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

			double minx, maxx, miny, maxy, scale, width, height;
			IEnumerable<Vector2> leftProfile, rightProfile;
			Data.ProcessProfiles(Width, out leftProfile, out rightProfile, out minx, out maxx, out miny, out maxy, out scale, out width, out height);

			if (leftProfile != null)
			{
				DrawProfile(leftProfile, Pens.Green, minx, miny, width, height, scale, e);
			}

			if (rightProfile != null)
			{
				DrawProfile(rightProfile, Pens.Blue, minx, miny, width, height, scale, e);
			}

			// Draw origin
			Vector2 point = (Data.Origin - new Vector2(minx, miny)) * scale;
			point.x = point.x + (Width - width) / 2;
			point.y = (Height + height / 2) / 2 - point.y;

			e.Graphics.DrawLine(Pens.Red, point - new Vector2(2, 0), point + new Vector2(2, 0));
			e.Graphics.DrawLine(Pens.Red, point - new Vector2(0, 2), point + new Vector2(0, 2));
		}

		private void DrawProfile(IEnumerable<Vector2> profile, Pen pen, double minx, double miny, double width, double height, double scale, PaintEventArgs e)
		{
			Vector2 last = null;
			foreach(Vector2 vec in profile)
			{
				Vector2 point = (vec - new Vector2(minx, miny)) * scale;
				point.x = point.x + (Width - width) / 2;
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
