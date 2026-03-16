using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Project.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string? Adress { get; set; }
        public int? Age { get; set; }

        //[ForeignKey(nameof(Department))] // if the foreign key is 'Name of property + Id/ID' like property 'Department' and foreign key 'DepartmentId' or 'DepartmentID' don't use data annotation cause the EF Core will Generate a hiding property like it and make nullable=false even if use '?'
        public int? DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();
    }
}
