using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Snake_V3
{
	// Clasa care inglobeaza toate setarile jocului
	class Settings
	{
		public static int EntityWidth { get; set; }
		public static int EntityHeight { get; set; }
		public static int Speed { get; set; }
		public static bool GameOver { get; set; }
		public static float Score { get; set; }

		public Settings()
		{
			EntityWidth = 20;
			EntityHeight = 20;
			Speed = 20;
			GameOver = false;
			Score = 0.0F;
		}

	}
}
