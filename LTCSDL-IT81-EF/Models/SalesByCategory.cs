﻿using System;
using System.Collections.Generic;

#nullable disable

namespace LTCSDL_IT81_EF.Models
{
    public partial class SalesByCategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal? ProductSales { get; set; }
    }
}
