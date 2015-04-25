using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Models
{
    public class Post : BaseEntity
    {
        public int PostId { get; set; }
        public int BlogId{get; set;}
        public string Title { get; set; }
        public string Body { get; set; }
       
    }
}
