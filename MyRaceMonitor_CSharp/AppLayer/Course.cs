using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLayer
{
    public class Course
    {
        public float CourseLength { get; set; }

        public Course(float length)
        {
            CourseLength = length;
        }
    }
}
