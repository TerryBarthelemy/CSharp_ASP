using PizzaMVC.Models;
using PizzaMVC.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaMVC.Controllers
{
    public class PizzaController : Controller
    {
		private PizzaStore Db = new PizzaStore();
        public ActionResult PizzasList()
        {
			var store = new PizzaStore();

			var ViewModel = new PizzaListViewModel(store.Pizzas);

			return View(ViewModel);
        }

		public ActionResult ListofPizzas(string searchCriteria)
		{
			var store = new PizzaStore();

			IQueryable<Pizza> pizzas = store.Pizzas.OrderBy(p => p.TypeOfPizza);

			if (searchCriteria != null)
			{
				pizzas = pizzas.Where(p => p.TypeOfPizza.Contains(searchCriteria));
			}

			var pizzalist = pizzas.Take(10).ToList();

			return View(pizzalist);
		}

		public ActionResult Details(int id)
		{
			var store = new PizzaStore();

			Pizza found = store.Pizzas.Where(p => p.Pizza_ID == id).FirstOrDefault();

			return View(found);
		}
    }
}