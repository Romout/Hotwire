using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotwire
{
	public class Vector2
	{
		public double x;
		public double y;

		public Vector2()
		{
			x = 0;
			y = 0;
		}
		public Vector2(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		public double Length
		{
			get
			{
				return Math.Sqrt(x * x + y * y);
			}
		}

		public static Vector2 operator *(Vector2 vec, double scale)
		{
			return new Vector2(vec.x * scale, vec.y * scale);
		}

		public static Vector2 operator +(Vector2 a, Vector2 b)
		{
			return new Vector2(a.x + b.x, a.y + b.y);
		}
		public static Vector2 operator -(Vector2 a, Vector2 b)
		{
			return new Vector2(a.x - b.x, a.y - b.y);
		}
		public static implicit operator PointF(Vector2 vec)
		{
			return new PointF((float)vec.x, (float)vec.y);
		}

		public static implicit operator Point(Vector2 vec)
		{
			return new Point((int)vec.x, (int)vec.y);
		}
	}
}
