using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Snake_V3
{
	enum Direction { UP, DOWN, LEFT, RIGHT }
	class Snake
	{
		public Direction Direction { get; set; }
		public Entity Head { get; set; }
		public List<Entity> Tail { get; set; }

		public Snake(int x, int y, int size)
		{
			Head = new Entity();
			Head.Width = size;
			Head.Height = size;
			Head.X = x;
			Head.Y = y;
			Head.Color = System.Drawing.Brushes.Red;

			Tail = new List<Entity>();

			Direction = new Direction();
			Direction = Direction.UP;
		}

		private void Update()
		{
			for (int i = Tail.Count - 1; i >= 0; i--)
			{
				if (i == 0)
				{
					Tail[i].X = Head.X;
					Tail[i].Y = Head.Y;
				}
				else
				{
					Tail[i].X = Tail[i - 1].X;
					Tail[i].Y = Tail[i - 1].Y;
				}
			}
		}

		public void Move()
		{
			Update();

			switch (Direction)
			{
				case Direction.UP: Head.Y -= Settings.Speed; break;
				case Direction.DOWN: Head.Y += Settings.Speed; break;
				case Direction.LEFT: Head.X -= Settings.Speed; break;
				case Direction.RIGHT: Head.X += Settings.Speed; break;
			}

		}

		public void Grow(Fruit fruit)
		{

			Tail.Add(fruit);
			Update();

		}

		public int Shrink(int index)
		{
			int pointsLost = 0;
			for (int i = index; i < Tail.Count; i++)
			{
				pointsLost += (Tail[i] as Fruit).Value;
			}
			Tail.RemoveRange(index, Tail.Count - index);

			return pointsLost;

		}
	}
}
