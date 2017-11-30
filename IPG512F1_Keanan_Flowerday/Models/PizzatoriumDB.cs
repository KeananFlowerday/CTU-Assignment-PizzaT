using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IPG512F1_Keanan_Flowerday.Models
{
	public class PizzatoriumDB :DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Address> Addresses { get; set; }
		public DbSet<Pizza> Pizzas { get; set; }
		public DbSet<Ingredient> Ingredients { get; set; }
		public DbSet<Area> Areas { get; set; }
		public DbSet<Delivery> Deliverys { get; set; }

        private static PizzatoriumDB DBData = new PizzatoriumDB();

        public static PizzatoriumDB Data { get { return DBData; } }
    }
} 