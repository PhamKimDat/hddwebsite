using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.SQLServer.Data;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        #region fields
        private readonly ApplicationDbContextSQL _context;
        //MySQL
        //private readonly ApplicationDbContext _context;

        #endregion

        #region Constructor
        public HomeController(
            ApplicationDbContextSQL context
             //ApplicationDbContext context (MySQL)
            )
        {
            _context = context;
        }
        #endregion
        public IActionResult Index()
        {
            //get all product
            var products = _context.Products.ToList();
            return View(products);
        }
    }
}
