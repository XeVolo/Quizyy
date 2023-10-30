using Quizyy.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizyy.Controller
{
	public  class FlashCardsController
	{
		public FlashCardsController()
		{
		}
		public void CreateFlashCardsController()
		{
			LogoView.LogoViewSet();
			FlashCardsView.FlashCardsViewSet();



			FlashCardsControllerService();
		}
		private void FlashCardsControllerService()
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
