using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Models
{
    class comment
    {
        public int CommentId { get; set; }
        public string UserName;
        public string UserEmail;
        public string Content;
        public int PostId { get; set; }
        public DateTime CreatedOn;
        public DateTime ModifiedOn;
        public string CreatedBy;
        public String ModifiedBy;


    }
}
