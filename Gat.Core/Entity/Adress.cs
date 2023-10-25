using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gat.Core.Entity
{
    public class Adress
    {
        public int AdressID { get; set; }
        public int UserID { get; set; }
        public string AdressType { get; set; }
        public string Street { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }
    }
}
