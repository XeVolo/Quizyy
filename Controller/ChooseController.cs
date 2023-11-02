using Quizyy.Model;
using Quizyy.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizyy.Controller
{
	public class ChooseController
	{
		public ChooseController()
		{
		}
		public void CreateChooseController()
		{
			LogoView.LogoViewSet();
			ChooseView.ChooseViewSet();

			ChooseControllerService();
		}
		private void ChooseControllerService()
		{
			List<WriteModel> list = WriteModel.CreateWriteModel();
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
						

						break;
					case ConsoleKey.Escape:

						return;
				}
			}
		}

		private List<int> GetNumbers()
		{
			Range xy = new Range(0, 3);
			int count = 4;
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
		private int GetRandom()
		{
			List<WriteModel> list = WriteModel.CreateWriteModel();
			int size = list.Count;
			Random rnd = new Random();
			int result = rnd.Next(size);
			return result;
		}
		private List<FitOptionModel> NewSet()
		{
			List<WriteModel> list = WriteModel.CreateWriteModel();
			List<FitOptionModel> optionlist = new List<FitOptionModel>();
			int questionid = GetRandom();
			ChooseView.ChooseOption(list[questionid].question);
			List<int> drawn = GetNumbers();
			foreach (int i in drawn)
			{
				if (i == 0)
				{
					OptionView.NewOption(list[questionid].answer, 40, 26);
					//optionlist.Add(new FitOptionModel(5, lista[drawn[5]], 40, 26));
				}
				else if (i == 1)
				{
					OptionView.NewOption(list[questionid].incorrectans1, 40, 29);
					//optionlist.Add(new FitOptionModel(6, lista[drawn[6]], 40, 29));
				}
				else if (i == 2)
				{
					OptionView.NewOption(list[questionid].incorrectans2, 95, 26);
					//optionlist.Add(new FitOptionModel(7, lista[drawn[0]], 95, 26));

				}
				else
				{
					OptionView.NewOption(list[questionid].incorrectans3, 95, 29);
					//optionlist.Add(new FitOptionModel(8, lista[drawn[1]], 95, 29));
				}
			}
			drawn.Clear();
			return optionlist;
		}
	}
}
