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
           //count of each product id
            var productdata = productreview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            
            foreach (var product in productdata)
            {
                Console.WriteLine("ProductID:" + product.ProductID +"count : " + product.Count);
                Console.WriteLine("-------------------------------------------------------------");
            }
        }
    }
}
