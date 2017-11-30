namespace IPG512F1_Keanan_Flowerday.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IPG512F1_Keanan_Flowerday.Models.PizzatoriumDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
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
                Roles = new System.Collections.Generic.List<int> {0}

			});
			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data.
		}
    }
}
