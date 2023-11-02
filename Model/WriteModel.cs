using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizyy.Model
{
	public class WriteModel
	{
		public int id { get; set; }
		public string question { get; set; }
		public string answer { get; set; }
		public string incorrectans1 { get; set; }
		public string incorrectans2 { get; set; }
		public string incorrectans3 { get; set; }


		public static List<WriteModel> CreateWriteModel()
		{
			List<WriteModel> lista = new List<WriteModel>
			{
				new WriteModel()
				{
					id = 0,
					question = "Ile to 2+2?",
					answer = "4",
					incorrectans1="5",
					incorrectans2="1",
					incorrectans3="3"
				},
				new WriteModel()
				{
					id = 1,
					question = "Ile to 2+3?",
					answer = "5",
					incorrectans1="7",
					incorrectans2="1",
					incorrectans3="3"
				},
				new WriteModel()
				{
					id = 2,
					question = "Czy koń to zwierze?",
					answer = "Tak",
					incorrectans1="Nie",
					incorrectans2="",
					incorrectans3=""
				},



			};
			return lista;
		}
	}
}
