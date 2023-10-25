using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gat.Core.Entity
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
