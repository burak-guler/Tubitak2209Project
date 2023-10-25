using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gat.Core.Entity
{
    public class ProductOperations
    {
        public int OperationID { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public string OperationType { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public DateTime DateStart { get; set; } 
        public DateTime DateEnd { get; set; }

    }
}
