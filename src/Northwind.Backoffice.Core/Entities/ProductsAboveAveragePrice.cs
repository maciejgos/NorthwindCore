﻿using System;
using System.Collections.Generic;

namespace Northwind.Backoffice.Core.Entities
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
