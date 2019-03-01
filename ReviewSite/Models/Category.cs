using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public virtual IEnumerable<Course> Courses { get; set; }
    }
}
