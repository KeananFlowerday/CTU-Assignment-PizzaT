using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IPG512F1_Keanan_Flowerday.Models
{
	public class Address
	{
		[Key]
		public int ID { get; set; }
		public string StreetNumber { get; set; }
		public string StreetName { get; set; }
		public string Suburb { get; set; }
		public string City { get; set; }
		public string ZipCode { get; set; }
		public string Province { get; set; }
		public string Country { get; set; }
	}
}