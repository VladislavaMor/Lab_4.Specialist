using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public int Age { get; set; }
        public List<Course> Courses { get; set; }
    }
}
