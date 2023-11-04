using Quizyy.Model;
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
			List<FlashCardsModel> lista = BaseController.GetFlashCardsList();
			int lastid = lista.Count()-1;
			int d = 2;
			int id = 0;
			OptionView.NewOption(lista[id].concept, 67, 22);
			while (true)
			{
				ConsoleKeyInfo keyInfo = Console.ReadKey();
				switch (keyInfo.Key)
				{
					case ConsoleKey.LeftArrow:
						--id;
						d = 2;
						if (id ==-1) id = lastid;
						ClearFieldView.ClearField(60, 22);
						OptionView.NewOption(lista[id].concept, 67, 22);
						break;
					case ConsoleKey.RightArrow:
						++id;
						d = 2;
						if (id == lastid+1) id = 0;
						ClearFieldView.ClearField(60, 22);
						OptionView.NewOption(lista[id].concept, 67, 22);
						break;
					case ConsoleKey.Enter:
						if (d == 1)
						{
							ClearFieldView.ClearField(60, 22);
							OptionView.NewOption(lista[id].concept, 67, 22);
							d = 2;
						}else
						{
							ClearFieldView.ClearField(60, 22);
							OptionView.NewOption(lista[id].definition, 67, 22);
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
