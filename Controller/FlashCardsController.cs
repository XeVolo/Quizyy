using Quizyy.Model;
using Quizyy.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
			List<FlashCardsModel> lista = BaseController.GetFlashCardsList();
			int lastid = lista.Count()-1;
			int d = 2;
			int id = 0;
			OptionView.NewOption(lista[id].concept, 60, 22);
			while (true)
			{
				ConsoleKeyInfo keyInfo = Console.ReadKey();
				switch (keyInfo.Key)
				{
					case ConsoleKey.LeftArrow:
						
						ClearFieldView.BetterClearField(60, 22, lista[id].concept);
						--id;
						d = 2;
						if (id ==-1) id = lastid;
						
						OptionView.NewOption(lista[id].concept, 60, 22);
						break;
					case ConsoleKey.RightArrow:
						ClearFieldView.BetterClearField(60, 22, lista[id].concept);
						++id;
						d = 2;
						if (id == lastid+1) id = 0;
						
						OptionView.NewOption(lista[id].concept, 60, 22);
						break;
					case ConsoleKey.Enter:
						
						if (d == 1)
						{
							ClearFieldView.BetterClearField(60, 22, lista[id].definition);
							OptionView.NewOption(lista[id].concept, 60, 22);
							d = 2;
						}else
						{
							ClearFieldView.BetterClearField(60, 22, lista[id].concept);
							OptionView.NewOption(lista[id].definition, 60, 22);
							d = 1;
						}

						break;
						
					case ConsoleKey.Escape:

						return;
					
				}
			}
		}
	}
}
