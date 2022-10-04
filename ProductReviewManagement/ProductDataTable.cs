using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductDataTable
    {
        //UC8 Create DataTable of Existing Records

        //To query datatable using linq we call the AsEnumerable() method of the DataTable.
        //Calling this method on the DataTable returns an object which implements the IEnumerable<T> interface.
        //Now we can perform LINQ queries on this object.

        public static DataTable producttable = new DataTable(); 

        public static void InsertdatainTable()
        {
            producttable.Columns.Add("ProductId", typeof(Int32));
            producttable.Columns.Add("Userid", typeof(Int32));
            producttable.Columns.Add("Rating", typeof(Int32));
            producttable.Columns.Add("Review", typeof(string));
            producttable.Columns.Add("islike", typeof(bool));

            producttable.Rows.Add(1, 1, 5, "Very Good", true);
            producttable.Rows.Add(2, 2, 4, "Good", true);
            producttable.Rows.Add(3, 3, 3, "Fine", false);
            producttable.Rows.Add(4, 4, 2, "Poor", false);
            producttable.Rows.Add(5, 5, 3, "Fine", false);
            producttable.Rows.Add(6, 6, 4, "Good", true);
            producttable.Rows.Add(7, 7, 4, "Good", true);
            producttable.Rows.Add(8, 8, 3, "Fine", false);
            producttable.Rows.Add(9, 9, 2, "Poor", false);
            producttable.Rows.Add(10, 10, 5, "Very Good", true);
            producttable.Rows.Add(11, 11, 4, "Good", true);
            producttable.Rows.Add(12, 12, 4, "Good", true);
            producttable.Rows.Add(13, 13, 4, "Good", true);
            producttable.Rows.Add(14, 14, 4, "Good", true);
            producttable.Rows.Add(15, 15, 4, "Good", true);
            producttable.Rows.Add(16, 16, 5, "Very Good", true);
            producttable.Rows.Add(17, 17, 3, "Fine", false);
            producttable.Rows.Add(18, 18, 2, "Poor", false);
            producttable.Rows.Add(19, 19, 3, "Fine", false);
            producttable.Rows.Add(20, 20, 3, "Fine", false);
            producttable.Rows.Add(21, 21, 4, "Good", true);
            producttable.Rows.Add(22, 22, 4, "Good", true);
            producttable.Rows.Add(23, 23, 5, "Very Good", true);
            producttable.Rows.Add(24, 24, 2, "Poor", false);
            producttable.Rows.Add(25, 25, 5, "Very Good", true);


            var dataTable = producttable.AsEnumerable().Select(x => new
            {
                ProductId = x.Field<int>("ProductId"),
                Userid = x.Field<int>("Userid"),
                Rating = x.Field<int>("Rating"),
                Review = x.Field<string>("Review"),
                isLike = x.Field<bool>("isLike")
            });

            foreach (var x in dataTable)
            {
                Console.WriteLine(x.ProductId + " | " + x.Userid + " | " + x.Rating + " | " + x.Review + " | " + x.isLike);

            }
        }

    }
}
