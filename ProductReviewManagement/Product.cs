﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Product
    {
        public int ProductId { get; set; }
        public int Userid { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public bool islike { get; set; }
    }
}
