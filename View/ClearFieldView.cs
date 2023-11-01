using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizyy.View
{
	public static class ClearFieldView
	{
		public static void ClearField()
		{
			Console.SetCursorPosition(4,24);

			for(int i = 24; i <= 28; i++)
			{
				Console.SetCursorPosition(60,i);
				Console.Write("                                                                   ");
				
			}
		}
	}
}
