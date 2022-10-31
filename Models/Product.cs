﻿using System;
using System.Collections.Generic;

namespace CoffeeShop.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public string? Category { get; set; }
    }
}
