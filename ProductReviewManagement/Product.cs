using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    internal class Product
    {
        public int ProductID { get; set; }
        public int Userid { get; set; }
        public int rating { get; set; }
        public string Review { get; set; }  
        public bool Islike { get; set; }
    }
}
