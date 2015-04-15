using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Models
{
   public class PostTag
    {
        public int TagId { get; set;}
        public int PostId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public String CreatedBy { get; set; }
        public String ModifiedBy { get; set; }
    }
}
