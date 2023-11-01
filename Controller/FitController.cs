using Quizyy.Model;
using Quizyy.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizyy.Controller
{
	public class FitController
	{
		public FitController()
		{
		}
		public void CreateFlashCardsController()
		{
			LogoView.LogoViewSet();
			FitView.FitViewSet();

			FitControllerService();
		}
		private void FitControllerService()
		{
			List<FlashCardsModel> lista = FlashCardsModel.CreateFlashCardsModel();
			int d = 1;
			int id = 0;

			OptionView.NewOption(lista[id].concept, 70, 26); OptionView.NewOption(lista[id].definition, 70, 26);
			OptionView.NewOption(lista[id].concept, 70, 26); OptionView.NewOption(lista[id].definition, 70, 26);
			OptionView.NewOption(lista[id].concept, 70, 26); OptionView.NewOption(lista[id].definition, 70, 26);
			OptionView.NewOption(lista[id].concept, 70, 26); OptionView.NewOption(lista[id].definition, 70, 26);
			OptionView.NewOption(lista[id].concept, 70, 26); OptionView.NewOption(lista[id].definition, 70, 26);
			OptionView.NewOption(lista[id].concept, 70, 26); OptionView.NewOption(lista[id].definition, 70, 26);
			OptionView.NewOption(lista[id].concept, 70, 26); OptionView.NewOption(lista[id].definition, 70, 26);
			while (true)
			{
				ConsoleKeyInfo keyInfo = Console.ReadKey();
				switch (keyInfo.Key)
				{
					case ConsoleKey.LeftArrow:
						--id;
						OptionView.NewOption(lista[id].concept, 70, 26);
						break;
					case ConsoleKey.RightArrow:
						++id;
						OptionView.NewOption(lista[id].concept, 70, 26);
						break;
					case ConsoleKey.Enter:
						if (d == 1)
						{
							ClearFieldView.ClearField();
							OptionView.NewOption(lista[id].definition, 70, 26);
							d = 2;
						}
						else
						{
							ClearFieldView.ClearField();
							OptionView.NewOption(lista[id].concept, 70, 26);
							d = 1;
						}

						break;
					case ConsoleKey.Escape:

						return;
				}
			}
		}
		private int GetRandom()
		{
			List<FlashCardsModel> lista = FlashCardsModel.CreateFlashCardsModel();
			int size=lista.Count;
			Random rnd=new Random();
			int result=rnd.Next(size);
			return result;
		}
	}
}
