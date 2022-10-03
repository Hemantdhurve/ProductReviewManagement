using System;
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
    }
}
