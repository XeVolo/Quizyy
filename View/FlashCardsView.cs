using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Quizyy.View
{
	public static class FlashCardsView
	{
		public static void FlashCardsViewSet()
		{
			ArrowsView.ArrowsSet();
			Console.SetCursorPosition(62, 16);
			Console.Write("Witaj w trybie Fiszek");
			Console.SetCursorPosition(45, 36);
			Console.Write("Strzałki w boki - poruszanie się miedzy fiszkami");
			Console.SetCursorPosition(45, 37);
			Console.Write("Enter - przełączenie widoku między pojęciem a definicją");
			Console.SetCursorPosition(45, 38);
			Console.Write("Escape - powrót");

		}

	}
}
