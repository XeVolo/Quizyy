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
				}
			};
			return lista;
		}


	}
	
}
