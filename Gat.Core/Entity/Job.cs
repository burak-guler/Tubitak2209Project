using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gat.Core.Entity
{
    public class Job
    {
        public int JobID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Pay { get; set; }
        public string Adress { get; set; }
        public DateTime Date  { get; set; }
        public DateTime JobDuration { get; set; }
    }
}
