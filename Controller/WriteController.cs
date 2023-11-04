
using Quizyy.Model;
using Quizyy.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
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
			List<WriteModel> list = BaseController.GetWriteList();
			int lastid = list.Count() - 1;
			Random rnd = new Random();
			int id = rnd.Next(lastid);
			
			WriteView.WriteOption(list[id].question);
			while (true)
			{
				ConsoleKeyInfo keyInfo = Console.ReadKey();
				switch (keyInfo.Key)
				{
					case ConsoleKey.LeftArrow:
						--id;
						if (id == -1) id = lastid;
						WriteView.ClearField(26);
						ClearFieldView.ClearField(70, 30);
						ClearFieldView.ClearField(70, 34);
						WriteView.WriteOption(list[id].question);
						break;
					case ConsoleKey.RightArrow:
						++id;
						if (id == lastid + 1) id = 0;
						WriteView.ClearField(26);
						ClearFieldView.ClearField(70, 30);
						ClearFieldView.ClearField(70, 34);
						WriteView.WriteOption(list[id].question);
						break;
					case ConsoleKey.Enter:
						ClearFieldView.ClearField(70, 30);
						ClearFieldView.ClearField(70, 34);
						Console.SetCursorPosition(70, 30);
						string ans=Console.ReadLine();
						bool correctness = ans.Equals(list[id].answer);
						if (correctness)
						{
							Console.SetCursorPosition(70, 34);
							Console.WriteLine("Odpowiedź prawidłowa");
							ClearFieldView.ClearField(70, 30);
							WriteView.ClearField(26);
							++id;
							if (id == lastid + 1) id = 0;
							WriteView.WriteOption(list[id].question);
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
