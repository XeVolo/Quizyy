using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizyy.View
{
	public static class ClearFieldView
	{
		public static void ClearField(int x,int y)
		{
			Console.SetCursorPosition(x,y);

			for(int i = y; i <= y+2; i++)
			{
				Console.SetCursorPosition(x,i);
				Console.Write("                                           ");
				
			}
		}
		public static void BetterClearField(int position1,int position2,string option)
		{
			int size=option.Length+2;
			for (int i = position2; i <= position2+2; i++)
			{
				Console.SetCursorPosition(position1, i);
				Console.Write("".PadLeft(size, ' '));

			}
		}

	}
}
