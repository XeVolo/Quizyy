using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizyy.View
{
	public static class ChooseView
	{
		public static void ChooseViewSet()
		{
			Console.SetCursorPosition(59, 11);
			Console.Write("Witaj w trybie Wyboru odpowiedzi");
			Console.SetCursorPosition(8, 36);
			Console.Write("Strzałki - poruszanie się po oknie");
			Console.SetCursorPosition(8, 37);
			Console.Write("Enter - wybór odpowiedzi");
			Console.SetCursorPosition(8, 38);
			Console.Write("Escape - powrót");


		}
		public static void ChooseOption(string question)
		{
			int position = 75 - (question.Length / 2);
			Console.SetCursorPosition(position, 20);
			Console.Write(question);

		}
		public static void ClearField(int position)
		{
			Console.SetCursorPosition(28, position);
			Console.Write("                                                                                  ");
		}

	}
}
