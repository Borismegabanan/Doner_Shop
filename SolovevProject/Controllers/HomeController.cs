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
	}
}