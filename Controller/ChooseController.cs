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
			int x = 40, y = 26;
			List<FitOptionModel> optionlist = NewSet();
			while (true)
			{
				Console.SetCursorPosition(x, y);
				ConsoleKeyInfo keyInfo = Console.ReadKey();
				switch (keyInfo.Key)
				{
					case ConsoleKey.LeftArrow:
						if (x == 95 && y == 26)
						{
							OptionView.NewOption(optionlist[1].option.concept, optionlist[1].positionx, optionlist[1].positiony);
							x = 40;
							OptionView.ChoosenOption(optionlist[0].option.concept, optionlist[0].positionx, optionlist[0].positiony);
						}
						else if (x == 95 && y == 29)
						{
							OptionView.NewOption(optionlist[3].option.concept, optionlist[3].positionx, optionlist[3].positiony);
							x = 40;
							OptionView.ChoosenOption(optionlist[2].option.concept, optionlist[2].positionx, optionlist[2].positiony);
						}
						break;
					case ConsoleKey.RightArrow:
						if (x == 40 && y == 26)
						{
							OptionView.NewOption(optionlist[0].option.concept, optionlist[0].positionx, optionlist[0].positiony);
							x = 95;
							OptionView.ChoosenOption(optionlist[1].option.concept, optionlist[1].positionx, optionlist[1].positiony);
						}
						else if (x == 40 && y == 29)
						{
							OptionView.NewOption(optionlist[2].option.concept, optionlist[2].positionx, optionlist[2].positiony);
							x = 95;
							OptionView.ChoosenOption(optionlist[3].option.concept, optionlist[3].positionx, optionlist[3].positiony);
						}

						break;
					case ConsoleKey.UpArrow:
						if (x == 40 && y == 29)
						{
							OptionView.NewOption(optionlist[2].option.concept, optionlist[2].positionx, optionlist[2].positiony);
							y = 26;
							OptionView.ChoosenOption(optionlist[0].option.concept, optionlist[0].positionx, optionlist[0].positiony);
						}
						else if (x == 95 && y == 29)
						{
							OptionView.NewOption(optionlist[3].option.concept, optionlist[3].positionx, optionlist[3].positiony);
							y = 26;
							OptionView.ChoosenOption(optionlist[1].option.concept, optionlist[1].positionx, optionlist[1].positiony);
						}
						break;
					case ConsoleKey.DownArrow:
						if (x == 40 && y == 26)
						{
							OptionView.NewOption(optionlist[0].option.concept, optionlist[0].positionx, optionlist[0].positiony);
							y = 29;
							OptionView.ChoosenOption(optionlist[2].option.concept, optionlist[2].positionx, optionlist[2].positiony);
						}
						else if (x == 95 && y == 26)
						{
							OptionView.NewOption(optionlist[1].option.concept, optionlist[1].positionx, optionlist[1].positiony);
							y = 29;
							OptionView.ChoosenOption(optionlist[3].option.concept, optionlist[3].positionx, optionlist[3].positiony);
						}
						break;
					case ConsoleKey.Enter:
						int correct = optionlist[0].length;
						if (x >= optionlist[correct].positionx && x <= (optionlist[correct].positionx + optionlist[correct].option.concept.Length) && y >= optionlist[correct].positiony && y <= optionlist[correct].positiony + 2)
						{
							Console.SetCursorPosition(70, 36);
							Console.Write("Odpowiedź poprawna");
							
							optionlist = NewSet();
							x = 40;
							y = 26;
							
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
		private List<FitOptionModel> NewSet()
		{
			List<WriteModel> list = BaseController.GetWriteList();
			List<string> anslist = new List<string>();
			int questionid = GetRandom();
			anslist.Add(list[questionid].answer);
			anslist.Add(list[questionid].incorrectans1);
			anslist.Add(list[questionid].incorrectans2);
			anslist.Add(list[questionid].incorrectans3);
			ChooseView.ClearField(20);
			ClearFieldView.ClearField(40,26);
			ClearFieldView.ClearField(40, 29);
			ClearFieldView.ClearField(95, 26);
			ClearFieldView.ClearField(95, 29);
			ChooseView.ChooseOption(list[questionid].question);
			List<int> drawn = GetNumbers();
				
				OptionView.ChoosenOption(anslist[drawn[0]], 40, 26);
				OptionView.NewOption(anslist[drawn[1]], 95, 26);
				OptionView.NewOption(anslist[drawn[2]], 40, 29);
				OptionView.NewOption(anslist[drawn[3]], 95, 29);
			List<FitOptionModel> optionlist = new List<FitOptionModel>();


			int correct = 0;
			if (drawn[0] == 0)
			{
				correct = 0;
			}
			else if (drawn[1] == 0)
			{
				correct = 1;
			}
			else if (drawn[2] == 0)
			{
				correct = 2;
			}
			else
			{
				correct = 3;
			}
			optionlist.Add(new FitOptionModel(0, new FlashCardsModel { id = 0, concept = anslist[drawn[0]], definition = "" }, 40, 26, correct-1));
			optionlist.Add(new FitOptionModel(1, new FlashCardsModel { id = 1, concept = anslist[drawn[1]], definition = "" }, 95, 26, correct-1));
			optionlist.Add(new FitOptionModel(2, new FlashCardsModel { id = 2, concept = anslist[drawn[2]], definition = "" }, 40, 29, correct - 1));
			optionlist.Add(new FitOptionModel(3, new FlashCardsModel { id = 3, concept = anslist[drawn[3]], definition = "" }, 95, 29, correct - 1));

			return optionlist;
		}
	}
}
