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
            var productdata = productreview.Select(x => new { x.ProductID, x.Review });

            foreach (var product in productdata)
            {
                Console.WriteLine("ProductID:" + product.ProductID + "  Review : " + product.Review);
                Console.WriteLine("-------------------------------------------------------------");
            }
        }
    }
}
