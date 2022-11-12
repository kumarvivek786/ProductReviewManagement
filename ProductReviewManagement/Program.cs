using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Program
    {
       static void Main(string[] args)
        {   //UC1
            // add elements of the custom classes using the collection-initializer syntax.
            // The following adds objects of the ProductReview class in the List<ProductReview>.

            Console.WriteLine("Product review Management");
            List<Product> productReviewList = new List<Product>()
            {
                new Product(){ProductID=1,Userid=1,rating=2,Review="bad",Islike=true},
                new Product(){ProductID=2,Userid=2,rating=3,Review="Average",Islike=true},
                new Product(){ProductID=3,Userid=3,rating=2,Review="bad",Islike=true},
                new Product(){ProductID=4,Userid=4,rating=4,Review="good",Islike=true},
                new Product(){ProductID=5,Userid=5,rating=5,Review="good",Islike=true},
                new Product(){ProductID=6,Userid=6,rating=5,Review="good",Islike=true},
                new Product(){ProductID=7,Userid=7,rating=5,Review="good",Islike=true},
                new Product(){ProductID=8,Userid=8,rating=4,Review="good",Islike=true},
                new Product(){ProductID=9,Userid=9,rating=4,Review="good",Islike=true},
                new Product(){ProductID=10,Userid=10,rating=1,Review="bad",Islike=true},
                new Product(){ProductID=11,Userid=11,rating=1,Review="bad",Islike=true},
                new Product(){ProductID=12,Userid=12,rating=1,Review="bad",Islike=true},
                new Product(){ProductID=13,Userid=13,rating=3,Review="Average",Islike=true},
                new Product(){ProductID=14,Userid=14,rating=3,Review="Average",Islike=true},
                new Product(){ProductID=15,Userid=15,rating=3,Review="Average",Islike=true},
                new Product(){ProductID=16,Userid=16,rating=4,Review="good",Islike=true},
                new Product(){ProductID=17,Userid=17,rating=5,Review="good",Islike=true},
                new Product(){ProductID=18,Userid=18,rating=5,Review="good",Islike=true},
                new Product(){ProductID=19,Userid=19,rating=1,Review="bad",Islike=true},
                new Product(){ProductID=20,Userid=20,rating=1,Review="bad",Islike=true},
                new Product(){ProductID=21,Userid=21,rating=4,Review="good",Islike=true},
                new Product(){ProductID=22,Userid=22,rating=5,Review="good",Islike=true},
                new Product(){ProductID=23,Userid=23,rating=5,Review="good",Islike=true},
                new Product(){ProductID=24,Userid=24,rating=1,Review="bad",Islike=true},
                new Product(){ProductID=25,Userid=25,rating=1,Review="bad",Islike=true},

            };
            //foreach (var product in productReviewList)
            //{
            //    Console.WriteLine("--------------------------------");
            //    Console.WriteLine(product.ProductID+"|"+product.Userid+"|"+product.rating+"|"+product.Review+"|"+product.Islike);

            //}
            Console.WriteLine("Count of each productId: \n");
            Management objManagement = new Management();
            objManagement.Top3Records(productReviewList);
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
