using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Content { get; set; }
        public int PostId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string CreatedBy { get; set; }
        public String ModifiedBy { get; set; }
    }
}
