using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SimpleShoppingListSPA.Models
{
    public class SimpleShoppingListSPAContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public SimpleShoppingListSPAContext() : base("name=SimpleShoppingListSPAContext")
        {
        }

        public System.Data.Entity.DbSet<SimpleShoppingListSPA.Models.ShoppingList> ShoppingLists { get; set; }

        public System.Data.Entity.DbSet<SimpleShoppingListSPA.Models.Item> Items { get; set; }
    }
}
