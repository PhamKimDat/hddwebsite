using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace Project.Web.Items
{
    public class ListCartItem
    {
        public ListCartItem()
        {
            this.Items = new List<CartItem>();
        }
        public List<CartItem> Items
        {
            get;
            set;
        }
    }
}
