using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Models
{
    class Tag
    {
        public int TagId { get; set; }
        public string TagName;
        public string TagDescription;
        public DateTime CreatedOn;
        public DateTime ModfiedOn;
        public string CreatedBy;
        public string ModifiedBy;


    }
}
