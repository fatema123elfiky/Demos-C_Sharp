using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02.Models
{
    internal class Course
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

        [InverseProperty(nameof(Student.Course))]
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}
