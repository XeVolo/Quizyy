using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quizyy.Controller;

namespace Quizyy.View
{
	public class FirstView
	{
		public FirstView() {
			Console.SetBufferSize(150, 45);
			Console.SetWindowSize(150, 45);
			Console.SetCursorPosition(25, 0);
			Console.Write("  #####   ##   ##   ####    #######  ##  ##   ##  ##  \r\n ##   ##  ##   ##    ##     #   ##   ##  ##   ##  ##  \r\n ##   ##  ##   ##    ##        ##    ##  ##   ##  ##  \r\n ##   ##  ##   ##    ##       ##      ####     ####   \r\n ##   ##  ##   ##    ##      ##        ##       ##    \r\n ##  ###  ##   ##    ##     ##    #    ##       ##    \r\n  #####    #####    ####    #######   ####     ####   \r\n     ###                                              \r\n");


			Console.WriteLine("The current buffer height is {0} rows.",
				  Console.BufferHeight);
			Console.WriteLine("The current buffer width is {0} columns.",
							  Console.BufferWidth);
		}

	}
}
