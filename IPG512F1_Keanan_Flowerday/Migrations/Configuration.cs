namespace IPG512F1_Keanan_Flowerday.Migrations
{
    using IPG512F1_Keanan_Flowerday.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IPG512F1_Keanan_Flowerday.Models.PizzatoriumDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(IPG512F1_Keanan_Flowerday.Models.PizzatoriumDB context)
        {
            //  This method will be called after migrating to the latest version.
            context.Users.AddOrUpdate(new Models.User
            {
                ID = 1,
                Username = "admin",
                Password = "admin",
                Name = "Admin",
                Roles = new System.Collections.Generic.List<int> {0,1}

			});

            //context.Users.AddOrUpdate(new Models.User
            //{
            //    ID = 2,
            //    Username = "KFlowerday",
            //    Password = "KFlowerday",
            //    Name = "Keanan",
            //    Surname = "Flowerday",
            //    Roles = new System.Collections.Generic.List<int> {0}

            //});

            context.Ingredients.AddOrUpdate(i => i.ID,
      new Ingredient { ID = 23, Name = "Plain Base", SmallPrice = 7.00f, MediumPrice = 11.00f, LargePrice = 15.00f },
      new Ingredient { ID = 1, Name = "Tomato Base", SmallPrice = 7.00f, MediumPrice = 11.00f, LargePrice = 15.00f },
      new Ingredient { ID = 2, Name = "BBQ Base", SmallPrice = 7.00f, MediumPrice = 11.00f, LargePrice = 15.00f },
      new Ingredient { ID = 3, Name = "Chutney Base", SmallPrice = 7.00f, MediumPrice = 11.00f, LargePrice = 15.00f },
      new Ingredient { ID = 4, Name = "Szechuan Sauce", SmallPrice = 5.00f, MediumPrice = 9.00f, LargePrice = 13.00f },
      new Ingredient { ID = 5, Name = "BBQ Sauce", SmallPrice = 5.00f, MediumPrice = 9.00f, LargePrice = 13.00f },
      new Ingredient { ID = 6, Name = "Mayonnaise", SmallPrice = 5.00f, MediumPrice = 9.00f, LargePrice = 13.00f },
      new Ingredient { ID = 7, Name = "Sweet & Sour Sauce", SmallPrice = 5.00f, MediumPrice = 9.00f, LargePrice = 13.00f },
      new Ingredient { ID = 8, Name = "Chicken", SmallPrice = 8.00f, MediumPrice = 12.00f, LargePrice = 16.00f },
      new Ingredient { ID = 9, Name = "Beef", SmallPrice = 8.00f, MediumPrice = 12.00f, LargePrice = 16.00f },
      new Ingredient { ID = 10, Name = "Rib", SmallPrice = 8.00f, MediumPrice = 12.00f, LargePrice = 16.00f },
      new Ingredient { ID = 11, Name = "Anchovies", SmallPrice = 8.00f, MediumPrice = 12.00f, LargePrice = 16.00f },
      new Ingredient { ID = 12, Name = "Pepperoni", SmallPrice = 8.00f, MediumPrice = 12.00f, LargePrice = 16.00f },
      new Ingredient { ID = 13, Name = "Macon", SmallPrice = 8.00f, MediumPrice = 12.00f, LargePrice = 16.00f },
      new Ingredient { ID = 14, Name = "Bacon", SmallPrice = 8.00f, MediumPrice = 12.00f, LargePrice = 16.00f },
      new Ingredient { ID = 15, Name = "Banana", SmallPrice = 7.00f, MediumPrice = 11.00f, LargePrice = 15.00f },
      new Ingredient { ID = 18, Name = "Pineapple", SmallPrice = 7.00f, MediumPrice = 11.00f, LargePrice = 15.00f },
      new Ingredient { ID = 17, Name = "Ham", SmallPrice = 8.00f, MediumPrice = 12.00f, LargePrice = 16.00f },
      new Ingredient { ID = 16, Name = "Mozzerella Cheese", SmallPrice = 6.00f, MediumPrice = 10.00f, LargePrice = 14.00f },
      new Ingredient { ID = 19, Name = "Cheddar Cheese", SmallPrice = 6.00f, MediumPrice = 10.00f, LargePrice = 14.00f },
      new Ingredient { ID = 20, Name = "Feta Cheese", SmallPrice = 6.00f, MediumPrice = 10.00f, LargePrice = 14.00f },
      new Ingredient { ID = 21, Name = "Fried Chips", SmallPrice = 8.00f, MediumPrice = 12.00f, LargePrice = 16.00f },
      new Ingredient { ID = 22, Name = "Egg", SmallPrice = 8.00f, MediumPrice = 12.00f, LargePrice = 16.00f }
  );

            context.Pizzas.AddOrUpdate(p => p.ID,
                new Pizza { ID = 1, Name = "Hawaiian", DefaultIngredients = Ingredient.Get(1, 16, 15, 14) },
                new Pizza { ID = 2, Name = "Pepperoni", DefaultIngredients = Ingredient.Get(1, 10, 16) },
                new Pizza { ID = 3, Name = "Something Meaty", DefaultIngredients = Ingredient.Get(2, 5, 8, 7, 10, 12, 16) },
                new Pizza { ID = 4, Name = "Sweet Chilli Chicken", DefaultIngredients = Ingredient.Get(3, 7, 8, 16) },
                new Pizza { ID = 5, Name = "Sweet & Sour Rib", DefaultIngredients = Ingredient.Get(3, 10, 7, 16) },
                new Pizza { ID = 6, Name = "Margherita", DefaultIngredients = Ingredient.Get(1, 16) },
                new Pizza { ID = 7, Name = "Seafood", DefaultIngredients = Ingredient.Get(1, 11, 16) },
                new Pizza { ID = 8, Name = "Tropical", DefaultIngredients = Ingredient.Get(3, 15, 16, 17, 16, 7, 22) },
                new Pizza { ID = 9, Name = "Garage Special", DefaultIngredients = Ingredient.Get(2, 21, 20, 16, 17, 15) },
                new Pizza { ID = 10, Name = "Just the Base", DefaultIngredients = Ingredient.Get(23) }
            );

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
