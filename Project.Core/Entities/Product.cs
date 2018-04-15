﻿using Project.Core.Constant;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.Core.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public bool isSold { get; set; }

        public string BillId { get; set; }
        public virtual Bill Bill { get; set; }

        public virtual MainBoard MainBoard { get; set; }
        

    }
}
