using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizyy.Model
{
	public class FlashCardsModel
	{
		public int id { get; set; }
		public string concept { get; set; }
		public string definition { get; set; }

		public FlashCardsModel(int id,string concept,string definition) {
			this.id = id;
			this.concept = concept;
			this.definition = definition;
		}

		public static List<FlashCardsModel> CreateFlashCardsModel()
		{
			List<FlashCardsModel> lista = new List<FlashCardsModel>
			{
				new FlashCardsModel(0,"pensja","a salary"),
				new FlashCardsModel(1,"kwalifikacje","qualifications"),
				new FlashCardsModel(2, "uczciwość", "integrity"),
				new FlashCardsModel(3, "metka", "label"),
				new FlashCardsModel(4, "struktura", "framework"),
				new FlashCardsModel(5, "równość", "equality"),
				new FlashCardsModel(6, "surowce", "raw materials"),

			};
			return lista;
		}


	}
	
}
