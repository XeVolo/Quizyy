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

			Console.ReadKey();
		}
	}
}
