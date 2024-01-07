using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Snake_V3
{
	class Fruit : Entity
	{
		public int Value { get; set; }

		public Fruit(int x, int y, int boxSize)
		{
			// TODO: Rethink algorithm.. ATM is not correct!!
			Value = (new Random()).Next(1, 4); // creates a random value between 1 and 3
			X = (x / boxSize) * boxSize;
			Y = (y / boxSize) * boxSize;
			Width = boxSize;
			Height = boxSize;

			switch (Value)
			{
				case 1: Color = System.Drawing.Brushes.Blue; break;
				case 2: Color = System.Drawing.Brushes.Beige; break;
				case 3: Color = System.Drawing.Brushes.CadetBlue; break;
			}
		}
	}
}
