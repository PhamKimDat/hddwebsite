using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.Common.Entities;
//using Project.SQLServer.Data;
using Project.MySQL.Data;
using Project.Web.Items;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        #region fields
        //private readonly ApplicationDbContextSQL _context;
        //MySQL
        private readonly ApplicationDbContext _context;

        #endregion

        #region Constructor
        public HomeController(
             //ApplicationDbContextSQL context
             ApplicationDbContext context //(MySQL)
            )
        {
            _context = context;
        }
        #endregion
        public IActionResult Index()
        {
            //init session if needed
            if (HttpContext.Session.Get<ListCartItem>("cart") == null)
            {
                HttpContext.Session.Set<ListCartItem>("cart", new ListCartItem());
            }
            //get all product
            var products = _context.Products.ToList();
            return View(products);
        }

        [HttpGet]
        public ActionResult LoadAllCartItem()
        {
            var cart = HttpContext.Session.Get<ListCartItem>("cart");

            return Json(cart);
        }

        [HttpGet]
        public ActionResult AddCartItem(String Id, int qty = 1)
        {
            var product = (Product)_context.Products.SingleOrDefault(x => x.Id == Id);
            var cartItem = new CartItem();
            cartItem.Id = product.Id;
            cartItem.ImageUrl = product.ImageUrl;
            cartItem.Name = product.Name;
            cartItem.Price = product.Price;
            cartItem.Qty = qty;

            var cart = HttpContext.Session.Get<ListCartItem>("cart");
            cart.Items.Add(cartItem);
            HttpContext.Session.Set<ListCartItem>("cart", cart);

            return Json(cart);
        }

        public ActionResult RemoveCartItem(String Id)
        {
            var cart = HttpContext.Session.Get<ListCartItem>("cart");
            foreach (var item in cart.Items)
            {
                if (item.Id == Id)
                {
                    cart.Items.Remove(item);
                    break;
                }
            }
            HttpContext.Session.Set<ListCartItem>("cart", cart);

            return Json(cart);
        }
    }

    public static class SessionExtensions
    {
        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) :
                                  JsonConvert.DeserializeObject<T>(value);
        }
    }
}
