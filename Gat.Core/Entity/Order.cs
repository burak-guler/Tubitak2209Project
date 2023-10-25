using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gat.Core.Entity
{
    public class Order
    {
        public int OdersID { get; set; }
        public int UserID { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public string State { get; set; }
        public string Adress { get; set; }
    }
}
