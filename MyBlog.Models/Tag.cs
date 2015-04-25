using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Models
{
    public class Tag : BaseEntity
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
        public string TagDescription { get; set; }
       

    }
}
