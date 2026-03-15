using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Project.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public string? Description { get; set; }

        [ForeignKey(nameof(Topic))]
        public int? Top_Id { get; set; }
        public Topic Topic { get; set; }

        public ICollection<StudentCourse> CourseStudents { get; set; } = new HashSet<StudentCourse>();
        public ICollection<CourseInstructor> CourseInstructors { get; set; } = new HashSet<CourseInstructor>();
    }
}
