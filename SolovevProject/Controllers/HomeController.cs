using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SolovevProject.Models;

namespace SolovevProject.Controllers
{
	public class HomeController : Controller
	{
		DonerShopContext db = new DonerShopContext();

		public ActionResult Index()
		{
			IEnumerable<Doner> doners = db.Doners;
			ViewBag.Doners = doners;

			return View();
		}

		[HttpGet]
		public ActionResult Buy(int id)
		{
			ViewBag.Id = id;
			return View();
		}
		[HttpPost]
		public string Buy(Purchase purchase)
		{
			purchase.Date = DateTime.Now;
			// добавляем информацию о покупке в базу данных
			db.Purchases.Add(purchase);
			// сохраняем в бд все изменения
			db.SaveChanges();
			return "Спасибо, за покупку! Заходите ещё!";
		}
	}
}