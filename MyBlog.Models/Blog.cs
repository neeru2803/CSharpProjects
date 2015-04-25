using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Models
{
    public class Blog : BaseEntity
    {
        public int BlogId { get; set; }
        public string BlogName { get; set; }
        public string OwnerName { get; set; }
        
    }
}

