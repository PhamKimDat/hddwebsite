using Project.Core.Constant;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.Core.Entities
{
    public class UserRole : BaseEntity
    {
        public string CustomerId { get; set; }
        public UserRole Role { get; set; }

    }
}
