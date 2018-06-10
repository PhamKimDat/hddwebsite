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
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public double Total { get; set; }

        public virtual List<BillDetail> BillDetails { get; set; }

    }
}
