using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Summitworks_Project.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        
        public List<Student> Students { get; set; }
        public int StudentForeignKey { get; set; }
    }
}
