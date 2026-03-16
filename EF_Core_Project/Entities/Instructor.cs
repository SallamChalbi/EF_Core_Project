using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Project.Entities
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Bouns { get; set; }
        public decimal Salary { get; set; }
        public string? Adress { get; set; }
        public double HourRate { get; set; }

        [InverseProperty(nameof(Department.Manager))]
        public Department ManageDepartment { get; set; }
        [ForeignKey(nameof(WorkFroDepartment))]
        public int? DepartmentId { get; set; }
        [InverseProperty(nameof(Department.Instructors))]
        public Department WorkFroDepartment { get; set; }

        public ICollection<CourseInstructor> InstructorCourses { get; set; } = new HashSet<CourseInstructor>();
    }
}
