using System;

namespace SolovevProject.Models
{
	public class Purchase
	{
		//Id покупки
		public int PurchaseId { get; set; }
		//Тип шаурмы
		public int DonerId { get; set; }
		//Дата покупки
		public DateTime Date { get; set; }
	}
}