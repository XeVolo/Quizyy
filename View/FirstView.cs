using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quizyy.Controller;

namespace Quizyy.View
{
	public static class FirstView
	{
		public static void FirstViewSet() {
			Console.SetBufferSize(150, 45);
			Console.SetWindowSize(150, 45);
			LogoView.LogoViewSet();
			Console.SetCursorPosition(67, 10);
			Console.Write("Witaj w Quizyy");
			Console.SetCursorPosition(49, 11);
			Console.Write("Wybierz tryb gry z którym chciałbyś się zmierzyć");

			
			OptionView.NewOption("Fiszki",20,15);

			OptionView.NewOption("Dopasowanie pojęć", 42, 15);

			OptionView.NewOption("Wpisanie odpowiedzi", 75, 15);

			OptionView.NewOption("Wybór odpowiedzi", 115, 15);



		}

	}
}
