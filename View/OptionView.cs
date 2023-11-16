using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Quizyy.View
{
	public static class OptionView
	{
		public static void NewOption(String option,int position1,int position2)
		{
			if (option == "")
			{
				return;
			}
			else
			{
				string wall = "║";
				string r_corner = "╗";
				string l_corner = "╔";
				string dr_corner = "╝";
				string dl_corner = "╚";
				string floor = "═";

				Console.SetCursorPosition(position1, position2);
				Console.Write(l_corner);
				foreach (var c in option)
				{
					Console.Write(floor);
				}
				Console.Write(r_corner);


				Console.SetCursorPosition(position1, position2 + 1);
				Console.Write(wall);
				foreach (var c in option)
				{
					Console.Write(c);
				}
				Console.Write(wall);


				Console.SetCursorPosition(position1, position2 + 2);
				Console.Write(dl_corner);
				foreach (var c in option)
				{
					Console.Write(floor);
				}
				Console.Write(dr_corner);
			}
		}
		public static void ChoosenOption(String option, int position1, int position2)
		{
			Console.BackgroundColor = ConsoleColor.DarkGreen;
			Console.ForegroundColor = ConsoleColor.Yellow;
			int size = option.Length;
			/*
			for (int i = position2; i <= position2 ; i++)
			{
				Console.SetCursorPosition(position1, i);
				Console.Write("".PadLeft(size, ' '));

			}
			*/
			if (option == "")
			{
				return;
			}
			else
			{
				string wall = "║";
				string r_corner = "╗";
				string l_corner = "╔";
				string dr_corner = "╝";
				string dl_corner = "╚";
				string floor = "═";

				Console.SetCursorPosition(position1, position2);
				Console.Write(l_corner);
				foreach (var c in option)
				{
					Console.Write(floor);
				}
				Console.Write(r_corner);


				Console.SetCursorPosition(position1, position2 + 1);
				Console.Write(wall);
				foreach (var c in option)
				{
					Console.Write(c);
				}
				Console.Write(wall);


				Console.SetCursorPosition(position1, position2 + 2);
				Console.Write(dl_corner);
				foreach (var c in option)
				{
					Console.Write(floor);
				}
				Console.Write(dr_corner);
			}
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
}
