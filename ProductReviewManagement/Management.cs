using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    class Management
    {
        public void Top3Records(List<Product> productreview)
        {
            // Query for Retrieve top 3 records from the list who’s rating is high using LINQ
            var productdata = (from product in productreview
                               orderby product.rating descending
                               select product).Take(3);
            // If you need the results to be in a DataTable
            foreach (var product in productdata)
            {
                Console.WriteLine("ProductID:" + product.ProductID + " " + "UserID: " + product.Userid
                    + " " + "Rating: " + product.rating + " " + "Review: " + product.Review + " " + "isLike: " + product.Islike);
                Console.WriteLine("-------------------------------------------------------------");
            }
        }
    }
}
