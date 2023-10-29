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
						Console.WriteLine(x +" "+ y);
						if (x >= 20 && x <= (20+option1.Length) && y>=15 && y <= 17)
						{
							Console.Write("EOOO");
						}
						break; 
				}
			}


			//Console.ReadKey();
		}
	}
}
