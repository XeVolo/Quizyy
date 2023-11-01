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
		public void CreateFitController()
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
			NewSet();
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
		private List<int> GetNumbers(Range xy)
		{
			int count = 7;
			Random rnd = new Random();
			List<int> numbers = new List<int>();

			while (numbers.Count < count)
			{
				int liczba = rnd.Next(xy.Start.Value, xy.End.Value + 1);
				if (!numbers.Contains(liczba))
				{
					numbers.Add(liczba);
				}
			}

			return numbers;
		}
		private void NewSet()
		{
			List<FlashCardsModel> lista = FlashCardsModel.CreateFlashCardsModel();
			Range xy = new Range(0, 6);

			List<int> drawn = GetNumbers(xy);

			OptionView.NewOption(lista[drawn[0]].concept, 30, 11);
			OptionView.NewOption(lista[drawn[1]].concept, 30, 16);
			OptionView.NewOption(lista[drawn[2]].concept, 30, 21);
			OptionView.NewOption(lista[drawn[3]].concept, 30, 26);
			OptionView.NewOption(lista[drawn[4]].concept, 30, 31);
			OptionView.NewOption(lista[drawn[5]].concept, 30, 36);
			OptionView.NewOption(lista[drawn[6]].concept, 30, 41);
			drawn.Clear();
			drawn = GetNumbers(xy);
			OptionView.NewOption(lista[drawn[0]].definition, 90, 11);
			OptionView.NewOption(lista[drawn[1]].definition, 90, 16);
			OptionView.NewOption(lista[drawn[2]].definition, 90, 21);
			OptionView.NewOption(lista[drawn[3]].definition, 90, 26);
			OptionView.NewOption(lista[drawn[4]].definition, 90, 31);
			OptionView.NewOption(lista[drawn[5]].definition, 90, 36);
			OptionView.NewOption(lista[drawn[6]].definition, 90, 41);
		}
	}
}
