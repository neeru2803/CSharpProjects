using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Models
{
   public class PostTag : BaseEntity
    {
        public int TagId { get; set;}
        public int PostId { get; set; }
       
    }
}
