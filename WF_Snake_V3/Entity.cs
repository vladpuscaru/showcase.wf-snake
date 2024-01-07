using System;
using System.Drawing;

namespace WF_Snake_V3
{
	class Entity
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }
		public Brush Color { get; set; }

		public Entity() { }

		public Entity(int x, int y, int width, int height, Brush color)
		{
			X = x;
			Y = y;
			Width = width;
			Height = height;
			Color = color;
		}
	}
}
