using PizzaMVC.Models;
using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PizzaMVC.ViewModels.Home
{
	public class PizzaListViewModel
	{
		public IEnumerable<SelectListItem> PizzaList { get; private set; }

		public Pizza PizzaCost { get; set; }

		public PizzaListViewModel(IEnumerable<Pizza> pizzas)
		{
			PizzaList = pizzas.Select(c => new SelectListItem() { Text = c.TypeOfPizza });

			PizzaCost = pizzas.OrderByDescending(c => c.PizzaPrice).FirstOrDefault();
		}
	}
}