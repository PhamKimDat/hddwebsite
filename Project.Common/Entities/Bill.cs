using Project.Common.Constant;
using Project.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.Common.Entities
{
    public class Bill : BaseEntity
    {
        public int Amount { get; set; }
        public double Total { get; set; }
        public string Description { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
