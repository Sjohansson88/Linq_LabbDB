﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_LabbDB.Models
{
    internal class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
