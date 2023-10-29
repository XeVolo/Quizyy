using Quizyy.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Quizyy.Controller
{
	public class MainController
	{
		public MainController() {

			String option1 = "Fiszki";
			String option2 = "Dopasowanie pojęć";
			String option3 = "Wpisanie odpowiedzi";
			String option4 = "Wybór odpowiedzi";


			FirstView.FirstViewSet();

			OptionView.NewOption(option1, 20, 15);

			OptionView.NewOption(option2, 42, 15);

			OptionView.NewOption(option3, 75, 15);

			OptionView.NewOption(option4, 115, 15);
			int x = 20, y = 15;
			while (true)
			{
				Console.SetCursorPosition(x, y);

				ConsoleKeyInfo keyInfo = Console.ReadKey();

				switch (keyInfo.Key)
				{
					case ConsoleKey.LeftArrow:
						if (x > 0)
							x--;
						break;
					case ConsoleKey.RightArrow:
						if (x < Console.WindowWidth - 1)
							x++;
						break;
					case ConsoleKey.UpArrow:
						if (y > 0)
							y--;
						break;
					case ConsoleKey.DownArrow:
						if (y < Console.WindowHeight - 1)
							y++;
						break;
					case ConsoleKey.Enter:					
						if (x >= 20 && x <= (21+option1.Length) && y>=15 && y <= 17)
						{
							LogoView.LogoViewSet();

						}
						else if(x >= 42 && x <= (43 + option2.Length) && y >= 15 && y <= 17)
						{
							LogoView.LogoViewSet();

						}
						else if (x >= 75 && x <= (76 + option3.Length) && y >= 15 && y <= 17)
						{
							LogoView.LogoViewSet();

						}
						else if (x >= 115 && x <= (116 + option4.Length) && y >= 15 && y <= 17)
						{
							LogoView.LogoViewSet();

						}
						break; 
				}
			}


			//Console.ReadKey();
		}
	}
}
