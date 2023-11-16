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
			
			int x = 40, y = 14,count=0;
			FitOptionModel ?flashcard1 =null;
			FitOptionModel ?flashcard2 = null;
			FitOptionModel? delete1 = null;
			FitOptionModel? delete2 = null;
			List<FitOptionModel> optionlist = NewSet();
			FitOptionModel current = optionlist[0];
			int con = 0;
			while (true)
			{
				Console.SetCursorPosition(x, y);
				ConsoleKeyInfo keyInfo = Console.ReadKey();
				switch (keyInfo.Key)
				{
					case ConsoleKey.LeftArrow:
						if (current.positionx == 95)
						{
							foreach (var item in optionlist)
							{
								if (item.positiony == current.positiony && item.positionx == 40)
								{
									if (con != 1)
									{
										OptionView.NewOption(current.option.definition, current.positionx, current.positiony);
									}
									current = item;
									x = 40;
									OptionView.ChoosenOption(item.option.concept, item.positionx, item.positiony);
									con = 0;
									break;
								}
							}
						}
						break;
					case ConsoleKey.RightArrow:
						if (current.positionx == 40)
						{
							foreach(var item in optionlist)
							{
								
								if (item.positiony == current.positiony&&item.positionx==95)
								{
									if (con != 1)
									{
										OptionView.NewOption(current.option.concept, current.positionx, current.positiony);
									}
									current = item;
									x = 95;
									OptionView.ChoosenOption(item.option.definition, item.positionx, item.positiony);
									con = 0;
									break;
								}
							}
						}
						break;
					case ConsoleKey.UpArrow:
						if (x == 40)
						{
							for (int i=optionlist.Count-1;i>=0;i--)
							{
								FitOptionModel item = optionlist[i];
								if (item.positionx == 40)
								{
									if (item.positiony < y)
									{
										if (con != 1)
										{
											OptionView.NewOption(current.option.concept, current.positionx, current.positiony);
										}
										y = item.positiony;
										current = item;
										OptionView.ChoosenOption(item.option.concept, item.positionx, item.positiony);
										con = 0;
										break;
									}
								}

							}
						}
						else if (x == 95)
						{
							for (int i = optionlist.Count - 1; i >= 0; i--)
							{
								FitOptionModel item = optionlist[i];
								if (item.positionx == 95)
								{
									if (item.positiony < y)
									{
										if (con != 1)
										{
											OptionView.NewOption(current.option.definition, current.positionx, current.positiony);
										}
										y = item.positiony;
										current = item;
										OptionView.ChoosenOption(item.option.definition, item.positionx, item.positiony);
										con = 0;
										break;
									}
								}

							}
						}
						break;
					case ConsoleKey.DownArrow:
						if (x == 40)
						{
							foreach (var item in optionlist)
							{
								if (item.positionx == 40) 
								{
									if (item.positiony > y)
									{
										if (con != 1)
										{
											OptionView.NewOption(current.option.concept, current.positionx, current.positiony);
										}
										y =item.positiony;
										current= item;
										OptionView.ChoosenOption(item.option.concept, item.positionx, item.positiony);
										con = 0;
										break;
									}
								}
								
							}
						}else if (x == 95)
						{
							foreach (var item in optionlist)
							{
								if (item.positionx == 95)
								{
									if (item.positiony > y)
									{
										if (con != 1)
										{
											OptionView.NewOption(current.option.definition, current.positionx, current.positiony);
										}
										y = item.positiony;
										current = item;
										OptionView.ChoosenOption(item.option.definition, item.positionx, item.positiony);
										con = 0;
										break;
									}
								}

							}
						}

						break;
					case ConsoleKey.Enter:
						foreach(var f in optionlist) {
							if (x >= f.positionx && x <= (f.positionx + f.length) && y >= f.positiony && y <= f.positiony+2)
							{
								if (flashcard1 == null)
								{
									flashcard1 = f;
									Console.SetCursorPosition(40, 40);
									Console.Write("                             ");
									Console.SetCursorPosition(95, 40);
									Console.Write("                              ");
									Console.SetCursorPosition(70, 42);
									Console.Write("                          ");
									Console.SetCursorPosition(40, 40);
									if (f.positionx == 40)
									{
										Console.Write("Wybrano: " + flashcard1.option.concept);
									}
									else
									{
										Console.Write("Wybrano: " + flashcard1.option.definition);
									}
								}
								else
								{
									if (f != flashcard1)
									{
										flashcard2 = f;
										Console.SetCursorPosition(95, 40);
										if (f.positionx == 40)
										{
											Console.Write("Wybrano: " + flashcard2.option.concept);
										}
										else
										{
											Console.Write("Wybrano: " + flashcard2.option.definition);
										}
										if (flashcard1.option.id == flashcard2.option.id)
										{
											Console.SetCursorPosition(70, 42);
											Console.Write("Połącznie poprawne");
											ClearFieldView.ClearField(flashcard1.positionx, flashcard1.positiony);
											ClearFieldView.ClearField(flashcard2.positionx, flashcard2.positiony);
											count++;
											delete1 = flashcard1;
											delete2= flashcard2;
											
											flashcard1 = null;
											flashcard2 = null;
											con = 1;
											
										}
										else
										{
											Console.SetCursorPosition(70, 42);
											Console.Write("Połącznie błędne");
											flashcard1 = null;
											flashcard2 = null;
										}
									}

								}								
								break;
							}
						}

						optionlist.Remove(delete1);
						optionlist.Remove(delete2);
						delete1 = null;
						delete2 = null;
						if (count == 7) CreateFitController();
						break;
					case ConsoleKey.Escape:

						return;
				}
			}
		}
		private int GetRandom()
		{
			List<FlashCardsModel> lista = BaseController.GetFlashCardsList();
			int size=lista.Count-7;
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
			List<FlashCardsModel> lista = BaseController.GetFlashCardsList();
			List<FitOptionModel> optionlist=new List<FitOptionModel>();
			int first = GetRandom();
			Range xy = new Range(first, first+6);

			List<int> drawn = GetNumbers(xy);

			OptionView.ChoosenOption(lista[drawn[0]].concept, 40, 14);
			optionlist.Add(new FitOptionModel(0, lista[drawn[0]], 40, 14, lista[drawn[0]].concept.Length));
			OptionView.NewOption(lista[drawn[1]].concept, 40, 17);
			optionlist.Add(new FitOptionModel(1, lista[drawn[1]], 40, 17, lista[drawn[1]].concept.Length));
			OptionView.NewOption(lista[drawn[2]].concept, 40, 20);
			optionlist.Add(new FitOptionModel(2, lista[drawn[2]], 40, 20, lista[drawn[2]].concept.Length));
			OptionView.NewOption(lista[drawn[3]].concept, 40, 23);
			optionlist.Add(new FitOptionModel(3, lista[drawn[3]], 40, 23, lista[drawn[3]].concept.Length));
			OptionView.NewOption(lista[drawn[4]].concept, 40, 26);
			optionlist.Add(new FitOptionModel(4, lista[drawn[4]], 40, 26, lista[drawn[4]].concept.Length));
			OptionView.NewOption(lista[drawn[5]].concept, 40, 29);
			optionlist.Add(new FitOptionModel(5, lista[drawn[5]], 40, 29, lista[drawn[5]].concept.Length));
			OptionView.NewOption(lista[drawn[6]].concept, 40, 32);
			optionlist.Add(new FitOptionModel(6, lista[drawn[6]], 40, 32, lista[drawn[6]].concept.Length));
			drawn.Clear();
			drawn = GetNumbers(xy);
			OptionView.NewOption(lista[drawn[0]].definition, 95, 14);
			optionlist.Add(new FitOptionModel(7, lista[drawn[0]], 95, 14, lista[drawn[0]].definition.Length));
			OptionView.NewOption(lista[drawn[1]].definition, 95, 17);
			optionlist.Add(new FitOptionModel(8, lista[drawn[1]], 95, 17, lista[drawn[1]].definition.Length));
			OptionView.NewOption(lista[drawn[2]].definition, 95, 20);
			optionlist.Add(new FitOptionModel(9, lista[drawn[2]], 95, 20, lista[drawn[2]].definition.Length));
			OptionView.NewOption(lista[drawn[3]].definition, 95, 23);
			optionlist.Add(new FitOptionModel(10, lista[drawn[3]], 95, 23, lista[drawn[3]].definition.Length));
			OptionView.NewOption(lista[drawn[4]].definition, 95, 26);
			optionlist.Add(new FitOptionModel(11, lista[drawn[4]], 95, 26, lista[drawn[4]].definition.Length));
			OptionView.NewOption(lista[drawn[5]].definition, 95, 29);
			optionlist.Add(new FitOptionModel(12, lista[drawn[5]], 95, 29, lista[drawn[5]].definition.Length));
			OptionView.NewOption(lista[drawn[6]].definition, 95, 32);
			optionlist.Add(new FitOptionModel(13, lista[drawn[6]], 95, 32, lista[drawn[6]].definition.Length));
			return optionlist;
		}
	}

}
