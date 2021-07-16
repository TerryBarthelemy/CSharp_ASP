using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PizzaMVC.Models
{
	public class PizzaStore : DbContext
	{
		public DbSet<Pizza> Pizzas { get; set; }

		public PizzaStore() : base("name=DefaultConnection")
		{
			Database.SetInitializer(new PizzaInitializer());
		}
	}

	public class PizzaInitializer : DropCreateDatabaseIfModelChanges<PizzaStore>
	{
		protected override void Seed(PizzaStore context)
		{
			{
				context.Pizzas.Add(new Pizza() { TypeOfPizza = "Hand Tossed", PizzaPrice = 11.35, Toppings = "Cheese", PizzaSize = "Medium" });

				context.Pizzas.Add(new Pizza() { TypeOfPizza = "New York", PizzaPrice = 13.79, Toppings = "Pineapple", PizzaSize = "One Size All" });

				context.Pizzas.Add(new Pizza() { TypeOfPizza = "Neapolitan", PizzaPrice = 16.88, Toppings = "N/A", PizzaSize = "Large" });
			}
		}
	}
}