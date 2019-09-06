using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
	public struct Vector2
	{
		public int x;
		public int y;
		
		public Vector2(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
		public static Vector2 down
		{
			get
			{
				return new Vector2(0, 1);
			}
		}
		public static Vector2 up
		{
			get
			{
				return new Vector2(0, -1);
			}
		}
		public static Vector2 left
		{
			get
			{
				return new Vector2(-1, 0);
			}
		}
		public static Vector2 right
		{
			get
			{
				return new Vector2(1, 0);
			}
		}
		public static Vector2 zero
		{
			get
			{
				return new Vector2(0, 0);
			}
		}
		public override string ToString()
		{
			return x + " " + y;
		}
	}
}
