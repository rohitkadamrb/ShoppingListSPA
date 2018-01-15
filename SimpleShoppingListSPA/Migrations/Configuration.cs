namespace SimpleShoppingListSPA.Migrations
{
    using SimpleShoppingListSPA.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SimpleShoppingListSPA.Models.SimpleShoppingListSPAContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SimpleShoppingListSPA.Models.SimpleShoppingListSPAContext context)
        {
            context.ShoppingLists.AddOrUpdate(
              new ShoppingList
              {
                  Name = "Groceries",
                  Items = { new Item { Name="Milk"},
                  new Item { Name="CornFlakes"},
                  new Item { Name="Strawberries"}}

              }, 
              new ShoppingList
              {
                  Name = "Hardware"
              }
                );
        }
    }
}
