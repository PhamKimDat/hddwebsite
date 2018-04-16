using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Project.Core.Enum
{
    public enum UserRole
    {
        [Description("Admin")]
        Owner = 0,

        [Description("User")]
        Admin = 1,
    }
}
