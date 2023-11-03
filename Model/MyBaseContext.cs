using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Quizyy.Model
{
	
	public class MyBaseContext : DbContext
	{

		public DbSet<FlashCardsModel> FlashCards { get; set; }
		public DbSet<WriteModel> Writes { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=E:\\Studia\\kck\\Quizyy\\database.db;");
		}
	}
	
}
