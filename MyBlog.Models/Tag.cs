using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Models
{
    public class Tag
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
        public string TagDescription { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModfiedOn { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }


    }
}
