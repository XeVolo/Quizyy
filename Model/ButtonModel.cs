using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizyy.Model
{
	public class ButtonModel
	{
		public string Name { get; set; }
		public int positionx { get; set; }
		public int positiony { get; set; }
		

		public ButtonModel(string name, int positionx, int positiony, int length)
		{
			this.Name = name;
			this.positionx = positionx;
			this.positiony = positiony;
			
		}
		
	}
}
