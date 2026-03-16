using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Project.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public string? Description { get; set; }

        //[ForeignKey(nameof(Topic))] // if the foreign key is 'Name of property + Id/ID' like property 'Topic' and foreign key 'TopicId' or 'TopicID' don't use data annotation cause the EF Core will Generate a hiding property like it and make nullable=false even if use '?'
        public int? TopicId { get; set; }
        public virtual Topic Topic { get; set; }

        public virtual ICollection<StudentCourse> CourseStudents { get; set; } = new HashSet<StudentCourse>();
        public virtual ICollection<CourseInstructor> CourseInstructors { get; set; } = new HashSet<CourseInstructor>();
    }
}
