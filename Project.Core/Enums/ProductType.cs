﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Project.Core.Enum
{
    public enum DiskType
    {
        [Description("HDD")]
        Special=0,

        [Description("SSD")]
        Normal = 1,
    }
}
