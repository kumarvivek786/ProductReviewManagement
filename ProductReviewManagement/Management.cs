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
           //skip top 5 record
            var productdata = (from product in productreview
                               select product).Skip(5);
            foreach (var product in productdata)
            {
                Console.WriteLine("ProductID:" + product.ProductID + " " + "UserID: " + product.Userid
                    + " " + "Rating: " + product.rating + " " + "Review: " + product.Review + " " + "isLike: " + product.Islike);
                Console.WriteLine("-------------------------------------------------------------");
            }
        }
    }
}
