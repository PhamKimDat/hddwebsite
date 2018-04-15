using Project.Core.Constant;
using Project.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.Core.Entities
{
    public class Disk : BaseEntity
    {
        public string CPUId { get; set; }


        public DiskType DiskType { get; set; }
        public double Price { get; set; }
        public int Memory { get; set; }
    }
}
