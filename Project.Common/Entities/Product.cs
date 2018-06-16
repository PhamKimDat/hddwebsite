using Project.Common.Constant;
using Project.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.Common.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public string Description { get; set; }

        public ProductType ProductType { get; set; }

        public Trend Trend { get; set; }

        public string ImageUrl { get; set; }

        public float Discount { get; set; }

        public int Amount { get; set; }

        public int Rating { get; set; }

        public virtual List<BillDetail> BillDetails { get; set; }

    }
}
