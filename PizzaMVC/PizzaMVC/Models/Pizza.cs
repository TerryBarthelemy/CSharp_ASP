using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PizzaMVC.Models
{
	public class Pizza
	{
		[Key]
		public int Pizza_ID { get; set; }
		public string TypeOfPizza { get; set; }
		public double PizzaPrice { get; set; }
		public string Toppings { get; set; }
		public string PizzaSize { get; set; }
	}
}