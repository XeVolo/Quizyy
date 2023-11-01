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
			int x = 20, y = 15;
			List<FitOptionModel> optionlist = NewSet();
			while (true)
			{
				Console.SetCursorPosition(x, y);
				ConsoleKeyInfo keyInfo = Console.ReadKey();
				switch (keyInfo.Key)
				{
					case ConsoleKey.LeftArrow:
						if (x > 0)
							x--;
						break;
					case ConsoleKey.RightArrow:
						if (x < Console.WindowWidth - 1)
							x++;
						break;
					case ConsoleKey.UpArrow:
						if (y > 0)
							y--;
						break;
					case ConsoleKey.DownArrow:
						if (y < Console.WindowHeight - 1)
							y++;
						break;
					case ConsoleKey.Enter:
						foreach(var f in optionlist) {
							if (x >= f.positionx && x <= (f.positionx + f.option.concept.Length) && y >= 15 && y <= 17)
							{

							}
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
		private List<FitOptionModel> NewSet()
		{
			List<FlashCardsModel> lista = FlashCardsModel.CreateFlashCardsModel();
			List<FitOptionModel> optionlist=new List<FitOptionModel>();
			Range xy = new Range(0, 6);

			List<int> drawn = GetNumbers(xy);

			OptionView.NewOption(lista[drawn[0]].concept, 40, 11);
			optionlist.Add(new FitOptionModel(0, lista[drawn[0]], 40, 11));
			OptionView.NewOption(lista[drawn[1]].concept, 40, 14);
			optionlist.Add(new FitOptionModel(1, lista[drawn[1]], 40, 14));
			OptionView.NewOption(lista[drawn[2]].concept, 40, 17);
			optionlist.Add(new FitOptionModel(2, lista[drawn[2]], 40, 17));
			OptionView.NewOption(lista[drawn[3]].concept, 40, 20);
			optionlist.Add(new FitOptionModel(3, lista[drawn[3]], 40, 20));
			OptionView.NewOption(lista[drawn[4]].concept, 40, 23);
			optionlist.Add(new FitOptionModel(4, lista[drawn[4]], 40, 23));
			OptionView.NewOption(lista[drawn[5]].concept, 40, 26);
			optionlist.Add(new FitOptionModel(5, lista[drawn[5]], 40, 26));
			OptionView.NewOption(lista[drawn[6]].concept, 40, 29);
			optionlist.Add(new FitOptionModel(6, lista[drawn[6]], 40, 29));
			drawn.Clear();
			drawn = GetNumbers(xy);
			OptionView.NewOption(lista[drawn[0]].definition, 95, 11);
			optionlist.Add(new FitOptionModel(7, lista[drawn[0]], 95, 11));
			OptionView.NewOption(lista[drawn[1]].definition, 95, 14);
			optionlist.Add(new FitOptionModel(8, lista[drawn[1]], 95, 14));
			OptionView.NewOption(lista[drawn[2]].definition, 95, 17);
			optionlist.Add(new FitOptionModel(9, lista[drawn[2]], 95, 17));
			OptionView.NewOption(lista[drawn[3]].definition, 95, 20);
			optionlist.Add(new FitOptionModel(10, lista[drawn[3]], 95, 20));
			OptionView.NewOption(lista[drawn[4]].definition, 95, 23);
			optionlist.Add(new FitOptionModel(11, lista[drawn[4]], 95, 23));
			OptionView.NewOption(lista[drawn[5]].definition, 95, 26);
			optionlist.Add(new FitOptionModel(12, lista[drawn[5]], 95, 26));
			OptionView.NewOption(lista[drawn[6]].definition, 95, 29);
			optionlist.Add(new FitOptionModel(13, lista[drawn[6]], 95, 29));
			return optionlist;
		}
	}
}
