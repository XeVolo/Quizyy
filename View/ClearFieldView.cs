using System;
using System.Collections.Generic;
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
	}
}
