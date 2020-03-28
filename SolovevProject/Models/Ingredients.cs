﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolovevProject.Models
{
	public class Ingredients
	{
		//Id игрединета
		public int ingredientId { get; set; }
		//наименование
		public string Name { get; set; }
		//описание
		public string Description { get; set; }
		//количество
		public int Number { get; set; }
		//закупочная цена
		public int Price { get; set; }

	}
}