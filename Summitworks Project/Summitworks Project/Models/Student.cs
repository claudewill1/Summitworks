using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Summitworks_Project.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        public List<Course> Courses { get; set; }
        
    }
}
