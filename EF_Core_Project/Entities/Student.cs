using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Project.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string? Adress { get; set; }
        public int? Age { get; set; }

        [ForeignKey(nameof(Department))]
        public int? Dept_Id { get; set; }
        public Department Department { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();
    }
}
