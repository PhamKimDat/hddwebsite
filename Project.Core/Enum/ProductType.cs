using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Project.Core.Enum
{
    public enum ProductType
    {
        [Description("Special")]
        Special=0,

        [Description("Normal")]
        Normal = 1,
    }
}
