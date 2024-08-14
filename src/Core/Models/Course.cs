using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Course
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string FullDetails { get; set; }
        public Teacher Teacher { get; set; }
    }
}
