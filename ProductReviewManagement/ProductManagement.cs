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
        //UC3 Retrieving Data where Rating is greater than 3 and ProductID is 1 or 4 or 9 
        public static void RetrieveRecords(List<Product> productreview)
        {
            var productdata = (from Product in productreview where (Product.Rating > 3) && (Product.ProductId == 1 || Product.ProductId == 4 || Product.ProductId == 9) select Product);

            foreach (var Product in productdata)
            {
                Console.WriteLine(Product.ProductId + " | " + Product.Userid + " | " + Product.Rating + " | " + Product.Review + " | " + Product.islike);
            }
        }


        //UC4 Retrieve count of Review
        public void RetrieveCount(List<Product> productreview)
        {
            var productdata = (from Product in productreview.GroupBy(Product => Product.ProductId) select new { count = Product.Count(), ProductId = Product.Key });

            foreach (var record in productdata)
            {
                Console.WriteLine(record.ProductId + " | " + record.count);
            }
        }

        //UC5 Retrieve only ProductId and Review from the List of Records using Select LINQ operator
        public void RetrieveProductId(List<Product> productreview)
        {
            var productdata = (from Product in productreview select new { Product.ProductId, Product.Review });

            foreach (var record in productdata)
            {
                Console.WriteLine(record.ProductId + " | " + record.Review);
            }
        }

        //UC6 Skipping Top 5 Records 
        public void SkipTop5Records(List<Product> productreview)
        {
            
            var productdata = (from Product in productreview select Product).Skip(5);

            foreach (var Product in productdata)
            {
                Console.WriteLine(Product.ProductId + " | " + Product.Userid + " | " + Product.Rating + " | " + Product.Review + " | " + Product.islike);

            }
        }

        //UC7 Retrieving only ProductId and Review from the List using LINQ Select Operator
        public void RetrieveProductIdandReview(List<Product> productreview)
        {
            //we can also write this query in this LINQ format.
            var productdata = productreview.Select(x => new { ProductId = x.ProductId, Review = x.Review });
            foreach(var record in productdata)
            {
                Console.WriteLine("ProductID : " +record.ProductId + " | " +"Review : "+ record.Review);
            }
        }
    }
}
