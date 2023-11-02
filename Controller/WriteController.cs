using Quizyy.Model;
using Quizyy.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Quizyy.Controller
{
	public class WriteController
	{
		public WriteController()
		{
		}

		public void CreateWriteController()
		{
			LogoView.LogoViewSet();
			WriteView.WriteViewSet();



			WriteControllerService();
		}
		private void WriteControllerService()
		{
			List<WriteModel> list = WriteModel.CreateWriteModel();
			int id = 0;
			WriteView.WriteOption(list[id].question);
			while (true)
			{
				ConsoleKeyInfo keyInfo = Console.ReadKey();
				switch (keyInfo.Key)
				{
					case ConsoleKey.LeftArrow:
						--id;
						ClearFieldView.ClearField(50, 26);
						ClearFieldView.ClearField(70, 30);
						ClearFieldView.ClearField(70, 34);
						WriteView.WriteOption(list[id].question);
						break;
					case ConsoleKey.RightArrow:
						++id;
						ClearFieldView.ClearField(50, 26);
						ClearFieldView.ClearField(70, 30);
						ClearFieldView.ClearField(70, 34);
						WriteView.WriteOption(list[id].question);
						break;
					case ConsoleKey.Enter:
						Console.SetCursorPosition(70, 30);
						string ans=Console.ReadLine();
						bool correctness = ans.Equals(list[id].answer);
						if (correctness)
						{
							Console.SetCursorPosition(70, 34);
							Console.WriteLine("Odpowiedź prawidłowa");
						}
						else
						{
							Console.SetCursorPosition(70, 34);
							Console.WriteLine("Odpowiuedź błędna");
						}

						break;
					case ConsoleKey.Escape:

						return;
				}
			}
		}

	}
}
