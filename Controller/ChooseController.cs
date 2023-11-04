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
			List<WriteModel> list = BaseController.GetWriteList();
			int x = 20, y = 15;
			FitOptionModel ansplace= NewSet();			
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
						if (x >= ansplace.positionx && x <= (ansplace.positionx + ansplace.option.concept.Length) && y >= ansplace.positiony && y <= ansplace.positiony + 2)
						{
							Console.SetCursorPosition(70, 36);
							Console.Write("Odpowiedź poprawna");
							ansplace = NewSet();
						}
						else
						{
							Console.SetCursorPosition(70, 36);
							Console.Write("Odpowiedź błędna");

						}

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
			List<WriteModel> list = BaseController.GetWriteList();
			int size = list.Count;
			Random rnd = new Random();
			int result = rnd.Next(size);
			return result;
		}
		private FitOptionModel NewSet()
		{
			List<WriteModel> list = BaseController.GetWriteList();
			List<string> anslist = new List<string>();
			int questionid = GetRandom();
			anslist.Add(list[questionid].answer);
			anslist.Add(list[questionid].incorrectans1);
			anslist.Add(list[questionid].incorrectans2);
			anslist.Add(list[questionid].incorrectans3);
			ChooseView.ChooseOption(list[questionid].question);
			List<int> drawn = GetNumbers();
			
				OptionView.NewOption(anslist[drawn[0]], 40, 26);
				OptionView.NewOption(anslist[drawn[1]], 40, 29);
				OptionView.NewOption(anslist[drawn[2]], 95, 26);
				OptionView.NewOption(anslist[drawn[3]], 95, 29);

			if (drawn[0] == 0)
			{
				return new FitOptionModel(0, new FlashCardsModel { id = 0, concept=list[questionid].answer, definition="" }, 40, 26,2);
			}else if (drawn[1] == 0)
			{
				return new FitOptionModel(0, new FlashCardsModel { id = 0, concept = list[questionid].answer, definition = "" }, 40, 29, 2);
			}else if (drawn[2] == 0)
			{
				return new FitOptionModel(0, new FlashCardsModel { id = 0, concept = list[questionid].answer, definition = "" }, 95, 26, 2);
			}
			else
			{
				return new FitOptionModel(0, new FlashCardsModel { id = 0, concept = list[questionid].answer, definition = "" }, 95, 29, 2);
			}


		}
	}
}
