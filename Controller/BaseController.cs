using Quizyy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizyy.Controller
{
	public static class BaseController
	{


		public static List<FlashCardsModel> GetFlashCardsList()
		{
			using (var context=new MyBaseContext())
			{
				List<FlashCardsModel> list = context.FlashCards.ToList();
				context.Dispose();
				return list;
			}
		}
		public static List<WriteModel> GetWriteList()
		{
			using (var context = new MyBaseContext())
			{
				List<WriteModel> list = context.Writes.ToList();
				context.Dispose();
				return list;
			}
		}




	}
}
