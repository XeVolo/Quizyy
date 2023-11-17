using Quizyy.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizyy.Controller
{
	public class EasterEggController
	{
		public EasterEggController()
		{
		}
		public void CreateEasterEggController()
		{
			
			EasterEggView.EasterEggSet();

			EasterEggService();
		}
		private void EasterEggService()
		{
			int x = 20, y = 16;
			while (true)
			{
				Console.SetCursorPosition(x, y);

				ConsoleKeyInfo keyInfo = Console.ReadKey();

				switch (keyInfo.Key)
				{
					case ConsoleKey.Escape:
						return;

				}
			}
		}

	}
}
