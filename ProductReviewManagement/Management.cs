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
           //show only product id and review
            var productdata = productreview.Select(x => new { ProductID = x.ProductID, Review = x.Review });
            foreach (var product in productdata)
            {
                Console.WriteLine("ProductID:" + product.ProductID +"  Review : " + product.Review);
                Console.WriteLine("-------------------------------------------------------------");
            }
        }
    }
}
