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
			//ArrowsView.ArrowsSet();


		}
		public static void ChooseOption(string question)
		{
			Console.SetCursorPosition(50, 20);
			Console.WriteLine(question);

		}


	}
}
