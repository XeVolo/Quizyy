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

		public static List<FlashCardsModel> CreateFlashCardsModel()
		{
			List<FlashCardsModel> lista = new List<FlashCardsModel>
			{
				new FlashCardsModel()
				{
					id = 0,
					concept = "pensja",
					definition = "a salary"
				},
			
				new FlashCardsModel()
				{
					id = 1,
					concept = "kwalifikacje",
					definition = "qualifications"
				},
				new FlashCardsModel()
				{
					id = 2,
					concept = "uczciwość",
					definition = "integrity"
				},
				new FlashCardsModel()
				{
					id = 3,
					concept = "metka",
					definition = "label"
				},
				new FlashCardsModel()
				{
					id = 4,
					concept = "struktura",
					definition = "framework"
				},
				new FlashCardsModel()
				{
					id = 5,
					concept = "równość",
					definition = "equality"
				},
				new FlashCardsModel()
				{
					id = 6,
					concept = "surowce",
					definition = "raw materials"
				},

			};
			return lista;
		}


	}
	
}
