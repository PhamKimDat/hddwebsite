using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Project.Common.Enum
{
    public enum ProductType
    {
        [Description("Hot Products")]
        HotProduct=0,

        [Description("New Products")]
        NewProduct = 1,
    }
}
