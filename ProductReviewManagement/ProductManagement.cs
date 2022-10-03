﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductManagement
    {
        //UC2 Retrieving Top 3 Records
        public static void Top3Records(List<Product> productreview)
        {
            //using LINQ to fetch data
            var productdata = (from Product in productreview select Product).Take(3);

            foreach (var Product in productdata)
            {
                Console.WriteLine(Product.ProductId + " | " + Product.Userid + " | " + Product.Rating + " | " + Product.Review + " | " + Product.islike);

            }
        }
        //UC3 Retrieving Data where Rating is greater than 3 and ProductID is 1 or 4 or 9 
        public static void RetrieveRecords(List<Product> productreview)
        {
            var productdata = (from Product in productreview where (Product.Rating > 3) && (Product.ProductId == 1 || Product.ProductId == 4 || Product.ProductId == 9) select Product);

            foreach (var Product in productdata)
            {
                Console.WriteLine(Product.ProductId + " | " + Product.Userid + " | " + Product.Rating + " | " + Product.Review + " | " + Product.islike);
            }
        }
    }
}
