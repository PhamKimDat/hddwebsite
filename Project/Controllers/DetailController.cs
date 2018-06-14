using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Common.Entities;
using Project.SQLServer.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Web.Controllers
{
    public class DetailController : Controller
    {
        #region fields
        private readonly ApplicationDbContextSQL _context;
        //MySQL
        //private readonly ApplicationDbContext _context;

        #endregion

        #region Constructor
        public DetailController(
            ApplicationDbContextSQL context
            //ApplicationDbContext context (MySQL)
            )
        {
            _context = context;
        }
        #endregion
        // GET: /<controller>/
        public IActionResult Index(string ID)
        {
            ViewData["ID"] = ID;
            var product = (Product)_context.Products.SingleOrDefault(x => x.Id == ID);
            return View(product);
        }
    }
}
