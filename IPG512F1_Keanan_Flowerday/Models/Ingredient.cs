using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IPG512F1_Keanan_Flowerday.Models
{
	public class Ingredient
	{
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public float SmallPrice { get; set; }
        public float MediumPrice { get; set; }
        public float LargePrice { get; set; }
        public static List<Ingredient> Get(int _ID)
        {
            return PizzatoriumDB.Data.Ingredients.Where(i => _ID == i.ID).ToList();
        }

        public static List<Ingredient> Get(params int[] _IDs)
        {
            return PizzatoriumDB.Data.Ingredients.Where(i => _IDs.Contains(i.ID)).ToList();
        }

        public static List<Ingredient> Get(List<int> _IDs)
        {
            return PizzatoriumDB.Data.Ingredients.Where(i => _IDs.Contains(i.ID)).ToList();
        }
    }
}