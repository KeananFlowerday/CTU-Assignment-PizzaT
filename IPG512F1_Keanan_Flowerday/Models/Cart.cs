using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IPG512F1_Keanan_Flowerday.Models
{
	public class Cart
	{
		public int ID { get; set; }
		public List<Pizza> Pizzas { get; set; }
	}
}