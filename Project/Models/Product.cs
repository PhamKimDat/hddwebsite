using Project.Core.Constant;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.Core.Entities
{
    public class Product : BaseEntity
    {
        [Required(ErrorMessage =CommonConstant.NAME_REQUIRED)]
        public string Name { get; set; }
        public float Price { get; set; }
    }
}
