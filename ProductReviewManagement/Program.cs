using System;

namespace ProductReviewManagement
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Product review Management Program");

           List<Product> productlist = new List<Product>()
           {

                new Product(){ProductId=1,Userid=1,Rating=5,Review="Very Good",islike=true},
                new Product(){ProductId=2,Userid=2,Rating=4,Review="Good",islike=true},
                new Product(){ProductId=3,Userid=3,Rating=3,Review="Fine",islike=false},
                new Product(){ProductId=4,Userid=4,Rating=2,Review="Poor",islike=false},
                new Product(){ProductId=5,Userid=5,Rating=3,Review="Fine",islike=false},
                new Product(){ProductId=6,Userid=6,Rating=4,Review="Good",islike=true},
                new Product(){ProductId=7,Userid=7,Rating=4,Review="Good",islike=true},
                new Product(){ProductId=8,Userid=8,Rating=3,Review="Fine",islike=false},
                new Product(){ProductId=9,Userid=9,Rating=2,Review="Poor",islike=false},
                new Product(){ProductId=10,Userid=10,Rating=5,Review="Very Good",islike=true},
                new Product(){ProductId=11,Userid=11,Rating=4,Review="Good",islike=true},
                new Product(){ProductId=12,Userid=12,Rating=4,Review="Good",islike=true},
                new Product(){ProductId=13,Userid=13,Rating=4,Review="Good",islike=true},
                new Product(){ProductId=14,Userid=14,Rating=4,Review="Good",islike=true},
                new Product(){ProductId=15,Userid=15,Rating=4,Review="Good",islike=true},
                new Product(){ProductId=16,Userid=16,Rating=5,Review="Very Good",islike=true},
                new Product(){ProductId=17,Userid=17,Rating=3,Review="Fine",islike=false},
                new Product(){ProductId=18,Userid=18,Rating=2,Review="Poor",islike=false},
                new Product(){ProductId=19,Userid=19,Rating=3,Review="Fine",islike=false},
                new Product(){ProductId=20,Userid=20,Rating=3,Review="Fine",islike=false},
                new Product(){ProductId=21,Userid=21,Rating=4,Review="Good",islike=true},
                new Product(){ProductId=22,Userid=22,Rating=4,Review="Good",islike=true},
                new Product(){ProductId=23,Userid=23,Rating=5,Review="Very Good",islike=true},
                new Product(){ProductId=24,Userid=24,Rating=2,Review="Poor",islike=false},
                new Product(){ProductId=25,Userid=25,Rating=5,Review="Very Good",islike=true},

           };

            Console.WriteLine("PLease Select the Option from Below:\n" +
              "1) Getting all the Records from List\n" +
              "2) Retrieve Top 3 Records From the List\n" +
              "3) Retrieving Record where Rating is greater than 3 and ProductID is 1 or 4 or 9\n" +
              "4) Retrieving Count of the Review for each ProductID using GroupBy LINQ Operator\n" +
              "5) Retrieve only ProductId and Review from the List using Select LINQ operator\n" +
              "6) Skipping Top 5 Records from the Record and Displaying on Console Window\n"+
              "7) Retrieving ProductId and Review using Select Operator\n" +
              "8) Creating DataTable and add Values\n");

            int option = Convert.ToInt32(Console.ReadLine());

            ProductManagement manage = new ProductManagement();
            switch (option)
            {
                case 1:
                    foreach (var Product in productlist)
                    {
                        Console.WriteLine(Product.ProductId + " | " + Product.Userid + " | " + Product.Rating + " | " + Product.Review + " | " + Product.islike);
                    }
                    break;

                case 2:
                    ProductManagement.Top3Records(productlist);
                    break;

                case 3:
                    Console.WriteLine("::::::::::::::::::::::::::::::::");
                    ProductManagement.RetrieveRecords(productlist);
                    break;

                case 4:
                    Console.WriteLine("::::::::::::::::::::::::::::::::");
                   
                    manage.RetrieveCount(productlist);
                    break;

                case 5:
                    Console.WriteLine("::::::::::::::::::::::::::::::::");
                    manage.RetrieveProductId(productlist);
                    break;

                case 6:
                    Console.WriteLine("::::::::::::::::::::::::::::::::");
                    manage.SkipTop5Records(productlist);
                    break;

                case 7:
                    Console.WriteLine("::::::::::::::::::::::::::::::::");
                    manage.RetrieveProductIdandReview(productlist);
                    break;

                case 8:
                    ProductDataTable.InsertdatainTable();
                    break;

                default:
                    Console.WriteLine("Please Choose Proper Options.");
                    break;

            }

        }
    }
}