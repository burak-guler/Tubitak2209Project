using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Gat.Core.Entity
{
    public class Product
    {
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }    
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string ProductType { get; set; }
        public string ProductImage { get; set; }

    }
}
