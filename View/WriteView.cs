using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizyy.View
{
	public static class WriteView
	{
		public static void WriteViewSet()
		{
			ArrowsView.ArrowsSet();
			Console.SetCursorPosition(59, 11);
			Console.Write("Witaj w trybie Podania odpowiedzi");
			Console.SetCursorPosition(8, 36);
			Console.Write("Strzałki w boki - poruszanie się miedzy pytaniami");
			Console.SetCursorPosition(8, 37);
			Console.Write("Enter - podanie oraz zatwierdzenie odpowiedzi");
			Console.SetCursorPosition(8, 38);
			Console.Write("Escape - powrót");

		}
		public static void WriteOption(string question)
		{
			int position = 75 - (question.Length / 2);
			Console.SetCursorPosition(position, 26);
			Console.Write(question);

		}
		public static void ClearField(int position)
		{
			Console.SetCursorPosition(28, position);
			Console.Write("                                                                                  ");
		}



	}
}
