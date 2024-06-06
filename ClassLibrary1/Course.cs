using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public string Description{ get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; } 
    }
}
