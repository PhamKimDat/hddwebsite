using Project.Core.Constant;
using Project.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.Core.Entities
{
    public class Bill : BaseEntity
    {

        public int Amount { get; set; }
        public double Total { get; set; }
        public string Description { get; set; }
        public virtual List<Product> Products { get; set; }

        //tam thoi
        public string Email { get; set; }
    }
}
