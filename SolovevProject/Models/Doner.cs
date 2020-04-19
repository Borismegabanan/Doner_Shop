using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolovevProject.Models
{
	public class Doner
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Price { get; set; }
		public IEnumerable<Ingredient> Structure { get; set; }

		public string StructToString()
		{
			return string.Join(",", Structure.Select(x => x.Name));
		}
	}
}