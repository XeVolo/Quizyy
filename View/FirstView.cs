using System;
using System.Collections.Generic;
using System.Diagnostics;
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
			Console.WriteLine("?");
			LogoView.LogoViewSet();
			Console.SetCursorPosition(67, 10);
			Console.Write("Witaj w Quizyy");
			Console.SetCursorPosition(49, 11);
			Console.Write("Wybierz tryb gry z którym chciałbyś się zmierzyć");

			Console.SetCursorPosition(64, 25);
			Console.Write("Szybkie wprowadzenie:");
			Console.SetCursorPosition(40, 26);
			Console.Write("Quizyy to prosta gra edukacyjna w której zmierzysz się z quizami w różnej formie");
			Console.SetCursorPosition(30, 28);
			Console.Write("Fiszki to wyświetlane pojęcie i ukryta definicja");
			Console.SetCursorPosition(30, 29);
			Console.Write("Dopasowanie pojęć polega na połączeniu w pary pasujących do siebie opcji");
			Console.SetCursorPosition(30, 30);
			Console.Write("Podanie odpowiedzi polega na ręcznym wpisaniu odpowiedzi do zadanego pytania");
			Console.SetCursorPosition(30, 31);
			Console.Write("Wybór odpowiedzi polega na wybraniu jednej poprawnej odpowiedzi spośród podanych");
			Console.SetCursorPosition(30, 40);
			Console.Write("Aby wybrać tryb gry naprowadź kursor strzałkami na ramkę z wybranym trybem gry i kliknij Enter...");

		}

	}
}
