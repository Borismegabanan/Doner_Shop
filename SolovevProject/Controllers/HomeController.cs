﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SolovevProject.Models;

namespace SolovevProject.Controllers
{
	public class HomeController : Controller
	{
		readonly DonerShopContext _db = new DonerShopContext();

		public ActionResult Index()
		{
			IEnumerable<Doner> doners = _db.Doners;
			ViewBag.Doners = doners;

			return View();
		}

		[HttpGet]
		public ActionResult Buy(int id)
		{
			ViewBag.Id = id;
			ViewBag.Name = _db.Doners.FirstOrDefault(x => x.Id == id).Name;
			return View();
		}
		[HttpPost]
		public string Buy(Purchase purchase)
		{
			purchase.Date = DateTime.Now;
			_db.Purchases.Add(purchase);
			_db.SaveChanges();
			return "Спасибо, за покупку! Заходите ещё!";
		}

		[HttpGet]
		public ActionResult Contains(int id)
		{
			ViewBag.Id = id;
			ViewBag.Ingredients = _db.Doners.FirstOrDefault(x => x.Id == id).StructToString();
			return View();
		}
		
	}
}