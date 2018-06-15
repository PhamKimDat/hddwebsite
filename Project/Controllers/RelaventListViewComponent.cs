using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.MySQL.Data;
using Project.Common.Entities;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Project.Web.Controllers
{
    public class RelaventListViewComponent : ViewComponent
    {
        //MySQL
        private readonly ApplicationDbContext db;

        public RelaventListViewComponent(ApplicationDbContext context)
        {
            this.db = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(
            Product p)
        {
            var products = await GetItemsAsync(p);
            return View(products);
        }
        private Task<List<Product>> GetItemsAsync(Product p)
        {
            return db.Products.Where(x => x.ProductType == p.ProductType).ToListAsync();
        }
    }
}
