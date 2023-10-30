using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizyy.View
{
	public static class LogoView
	{
		public static void LogoViewSet() {
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.ForegroundColor = ConsoleColor.White;
			Console.Clear();		
			Console.SetCursorPosition(47, 1);
			Console.Write("  #####   ##   ##   ####    #######  ##  ##   ##  ##  \r\n");
			Console.SetCursorPosition(47, 2);
			Console.Write(" ##   ##  ##   ##    ##     #   ##   ##  ##   ##  ##  \r\n");
			Console.SetCursorPosition(47, 3);
			Console.Write(" ##   ##  ##   ##    ##        ##    ##  ##   ##  ##  \r\n");
			Console.SetCursorPosition(47, 4);
			Console.Write(" ##   ##  ##   ##    ##       ##      ####     ####   \r\n");
			Console.SetCursorPosition(47, 5);
			Console.Write(" ##   ##  ##   ##    ##      ##        ##       ##    \r\n");
			Console.SetCursorPosition(47, 6);
			Console.Write(" ##  ###  ##   ##    ##     ##    #    ##       ##    \r\n");
			Console.SetCursorPosition(47, 7);
			Console.Write("  #####    #####    ####    #######   ####     ####   \r\n");
			Console.SetCursorPosition(47, 8);
			Console.Write("     ###                                              \r\n");			
			
		}
	}
}
