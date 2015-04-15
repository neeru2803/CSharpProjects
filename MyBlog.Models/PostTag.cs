using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Models
{
    class PostTag
    {
        public int TagId { get; set;}
        public int PostId { get; set; }
        public DateTime CreatedOn;
        public DateTime ModifiedOn;
        public String CreatedBy;
        public String ModifiedBy;

    }
}
