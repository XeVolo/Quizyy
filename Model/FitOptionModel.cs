using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizyy.Model
{
	public class FitOptionModel
	{
		public int id { get; set; }
		public FlashCardsModel option { get; set; }
		public int positionx { get; set; }
		public int positiony { get; set; }
		public int length { get; set; }

		public FitOptionModel(int id, FlashCardsModel card, int positionx, int positiony,int length)
		{
			this.id = id;
			this.option = card;
			this.positionx = positionx;
			this.positiony = positiony;
			this.length = length+1;
		}
	}
}
