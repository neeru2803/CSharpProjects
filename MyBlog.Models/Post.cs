using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public int BlogId{get; set;}
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
