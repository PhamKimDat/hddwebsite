using System;
namespace Project.Web.Items
{
    public class CartItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public int Qty { get; set; }
    }
}
