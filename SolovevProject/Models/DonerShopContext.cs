using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SolovevProject.Models
{
	public class DonerShopContext : DbContext
	{
		public DbSet<Ingredient> Ingredients { get; set; }
		public DbSet<Doner> Doners { get; set; }

	}
}