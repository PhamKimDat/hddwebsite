using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Project.Common.Enum
{
    public enum Trend
    {
        [Description("New Product")]
        NewProduct = 0,

        [Description("Hot Product")]
        HotProduct,

        [Description("Normal Product")]
        NormalProduct ,
    }

    public enum ProductType
    {
        [Description("Camera")]
        Camera = 0,
        [Description("Latop")]
        Laptop,
        [Description("Tablet")]
        Tablet,
        [Description("Phone")]
        Phone,
        [Description("Headphone")]
        Heaphone,
        [Description("Accessory")]
        Accessory,
    }
}
