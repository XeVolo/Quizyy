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

			Console.SetCursorPosition(64, 25);
			Console.Write("Szybkie wprowadzenie:");
			Console.SetCursorPosition(40, 26);
			Console.Write("Quizyy to prosta gra edukacyjna w której zmierzysz się z quizami w różnej formie");
			Console.SetCursorPosition(30, 27);
			Console.Write("Aby wybrać tryb gry naprowadź kursor strzałkami na ramkę z wybranym trybem gry i kliknij Enter");

		}

	}
}
