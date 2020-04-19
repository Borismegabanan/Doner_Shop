using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SolovevProject.Models
{
	public class DonerDbInitializer:DropCreateDatabaseAlways<DonerShopContext>
	{
		protected override void Seed(DonerShopContext db)
		{
			db.Doners.Add(new Doner(){Name = "Обычная шаурма",Price = 100});
			db.Doners.Add(new Doner() { Name = "Обычная шаурма с сыром", Price = 110 });
			db.Doners.Add(new Doner() { Name = "Обычная шаурма с летним салатом", Price = 120 });
			db.Doners.Add(new Doner() { Name = "Обычная шаурма с капустным салатом", Price = 115 });

			base.Seed(db);
		}
	}
}