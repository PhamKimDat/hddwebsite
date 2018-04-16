﻿using Project.Core.Constant;
using Project.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.Core.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string AvatarUrl { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public string Salt { get; set; }
        public bool isSupperAdmin { get; set; }
    }
}
