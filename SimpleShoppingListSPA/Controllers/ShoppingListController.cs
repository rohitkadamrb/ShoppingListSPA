﻿using SimpleShoppingListSPA.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleShoppingListSPA.Controllers
{
    public class ShoppingListController : ApiController
    {
        // GET: api/ShoppingList


        public static List<ShoppingList> shoppingLists = new List<ShoppingList> {
            new ShoppingList(){Id = 0 ,Name = "Groceries" ,Items = {
                new Item{Id = 0,Name = "Milk" ,ShoppingListId = 0},
                new Item{Id = 1,Name = "Cornflakes" ,ShoppingListId = 0},
                new Item{Id = 2,Name = "Strawberries" ,ShoppingListId = 0}}} ,
             new ShoppingList(){Id = 1 ,Name = "Hardware"}
        };
        // GET: api/ShoppingList/5
        public IHttpActionResult Get(int id)
        {
            ShoppingList result = shoppingLists.FirstOrDefault(s => s.Id == id);
            if(result == null)
            {
                return NotFound();
            }
            
            return Ok(result);
        }

        // POST: api/ShoppingList
        public IEnumerable Post([FromBody]ShoppingList newlist)
        {
            newlist.Id = shoppingLists.Count;
            shoppingLists.Add(newlist);
            return shoppingLists;
        }

        // PUT: api/ShoppingList/5
         
    }
}
