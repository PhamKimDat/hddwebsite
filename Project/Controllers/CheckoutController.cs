using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Controllers;
using Project.SQLServer.Data;
using Project.Web.Items;
using Project.Common.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Web.Controllers
{
    public class CheckoutController : Controller
    {
        #region fields
        private readonly ApplicationDbContextSQL _context;
        ////MySQL
        //private readonly ApplicationDbContext _context;

        #endregion

        #region Constructor
        public CheckoutController(
            ApplicationDbContextSQL context
            //ApplicationDbContext context //(MySQL)
            )
        {
            _context = context;
        }
        #endregion

        [HttpPost]
        public ActionResult Order()
        {
            var cart = HttpContext.Session.Get<ListCartItem>("cart");
            var bill = new Bill
            {
                CreatedAt = DateTime.UtcNow,
            };
            _context.Bills.Add(bill);
            _context.SaveChanges();
            double totalMoney = 0;
            var billDetails = new List<BillDetail>();
            foreach (var item in cart.Items)
            {
                var detail = new BillDetail
                {
                    BillId = bill.Id,
                    ProductId = item.Id,
                    Price = item.Price,
                    Amount = item.Qty
                };
                totalMoney += (item.Price * item.Qty);
                billDetails.Add(detail);
            }

            bill.Total = totalMoney;
            _context.Bills.Update(bill);
            _context.BillDetails.AddRange(billDetails);
            _context.SaveChanges();

            cart = null;
            HttpContext.Session.Clear();
            return RedirectToPage("Home");
        }
        // GET: /<controller>/
        public IActionResult Index(bool click)
        {
            var cart = HttpContext.Session.Get<ListCartItem>("cart");
            if (click == true)
            {
                Order();
                return RedirectToAction("Index", "Home");
            }

            return View(cart);
        }
    }
}
