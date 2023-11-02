using Quizyy.Model;
using Quizyy.View;
using System;
using System.Collections.Generic;
using System.Linq;
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
		
			while (true)
			{
				ConsoleKeyInfo keyInfo = Console.ReadKey();
				switch (keyInfo.Key)
				{
					case ConsoleKey.LeftArrow:

						break;
					case ConsoleKey.RightArrow:

						break;
					case ConsoleKey.Enter:


						break;
					case ConsoleKey.Escape:

						return;
				}
			}
		}

	}
}
