using Project.Common.Constant;
using Project.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.Common.Entities
{
    public class BillDetail : BaseEntity
    {
        public string BillId { get; set; }
        public virtual Bill Bill { get; set; }

        public int Amount { get; set; }
        public double Total { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public string ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}
