using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_LabbDB.Models
{
    internal class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
