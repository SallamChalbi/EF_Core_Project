using System;
using System.Collections.Generic;
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
    }
}
