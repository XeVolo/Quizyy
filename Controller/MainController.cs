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
			CreateMainController();
			Control();
		}
		public void CreateMainController()
		{
			String option1 = "Fiszki";
			String option2 = "Dopasowanie pojęć";
			String option3 = "Podanie odpowiedzi";
			String option4 = "Wybór odpowiedzi";


			FirstView.FirstViewSet();

			OptionView.ChoosenOption(option1, 20, 15);

			OptionView.NewOption(option2, 42, 15);

			OptionView.NewOption(option3, 75, 15);

			OptionView.NewOption(option4, 115, 15);
			
		}
		private void Control()
		{
			String option1 = "Fiszki";
			String option2 = "Dopasowanie pojęć";
			String option3 = "Podanie odpowiedzi";
			String option4 = "Wybór odpowiedzi";

			FlashCardsController newobject1 = new FlashCardsController();
			FitController newobject2 = new FitController();
			WriteController newobject3= new WriteController();
			ChooseController newobject4= new ChooseController();

			int x = 20, y = 16;
			while (true)
			{
				Console.SetCursorPosition(x, y);

				ConsoleKeyInfo keyInfo = Console.ReadKey();

				switch (keyInfo.Key)
				{
					case ConsoleKey.LeftArrow:
						if (x == 20)
						{
							OptionView.NewOption(option1, 20, 15);
							OptionView.ChoosenOption(option4, 115, 15);
							x = 115;
						}else if (x == 115)
						{
							OptionView.NewOption(option4, 115, 15);
							OptionView.ChoosenOption(option3, 75, 15);
							x = 75;
						}else if (x == 75)
						{
							OptionView.NewOption(option3, 75, 15);
							OptionView.ChoosenOption(option2, 42, 15);
							x = 42;
						}else if (x == 42)
						{
							OptionView.NewOption(option2, 42, 15);
							OptionView.ChoosenOption(option1, 20, 15);
							x = 20;
						}
					


						break;
					case ConsoleKey.RightArrow:
						if (x == 20)
						{
							OptionView.ChoosenOption(option2, 42, 15);
							OptionView.NewOption(option1, 20, 15);
							x = 42;
						}
						else if (x == 42)
						{
							OptionView.ChoosenOption(option3, 75, 15);
							OptionView.NewOption(option2, 42, 15);
							x = 75;
						}
						else if (x == 75)
						{
							OptionView.ChoosenOption(option4, 115, 15);
							OptionView.NewOption(option3, 75, 15);
							x = 115;
						}else if(x == 115)
						{
							OptionView.ChoosenOption(option1, 20, 15);
							OptionView.NewOption(option4, 115, 15);
							x = 20;
						}

						break;
					case ConsoleKey.Enter:
						if (x >= 20 && x <= (21 + option1.Length) && y >= 15 && y <= 17)
						{

							newobject1.CreateFlashCardsController();
							Console.Write("?");
							CreateMainController();
							OptionView.ChoosenOption(option1, 20, 15);

						}
						else if (x >= 42 && x <= (43 + option2.Length) && y >= 15 && y <= 17)
						{
							newobject2.CreateFitController();
							Console.Write("?");
							CreateMainController();
							OptionView.NewOption(option1, 20, 15);
							OptionView.ChoosenOption(option2, 42, 15);

						}
						else if (x >= 75 && x <= (76 + option3.Length) && y >= 15 && y <= 17)
						{
							newobject3.CreateWriteController();
							Console.Write("?");
							CreateMainController();
							OptionView.NewOption(option1, 20, 15);
							OptionView.ChoosenOption(option3, 75, 15);

						}
						else if (x >= 115 && x <= (116 + option4.Length) && y >= 15 && y <= 17)
						{
							newobject4.CreateChooseController();
							Console.Write("?");
							CreateMainController();
							OptionView.NewOption(option1, 20, 15);
							OptionView.ChoosenOption(option4, 115, 15);

						}
						break;
				}
			}
		}
	}
}
