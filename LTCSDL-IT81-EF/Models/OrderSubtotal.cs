﻿using System;
using System.Collections.Generic;

#nullable disable

namespace LTCSDL_IT81_EF.Models
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
