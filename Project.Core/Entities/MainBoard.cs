using Project.Core.Constant;
using Project.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.Core.Entities
{
    public class MainBoard : BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }

        //du lieu thieu

    }
}
