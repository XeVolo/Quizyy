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
			List<FlashCardsModel> lista = FlashCardsModel.CreateFlashCardsModel();
			int d = 1;
			int id = 0;
			OptionView.NewOption(lista[id].concept, 70, 26);
			while (true)
			{
				ConsoleKeyInfo keyInfo = Console.ReadKey();
				switch (keyInfo.Key)
				{
					case ConsoleKey.LeftArrow:
						--id;
						ClearFieldView.ClearField(60, 26);
						OptionView.NewOption(lista[id].concept, 70, 26);
						break;
					case ConsoleKey.RightArrow:
						++id;
						ClearFieldView.ClearField(60, 26);
						OptionView.NewOption(lista[id].concept, 70, 26);
						break;
					case ConsoleKey.Enter:
						if (d == 1)
						{
							ClearFieldView.ClearField(60, 26);
							OptionView.NewOption(lista[id].definition, 70, 26);
							d = 2;
						}else
						{
							ClearFieldView.ClearField(60, 26);
							OptionView.NewOption(lista[id].concept, 70, 26);
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
