using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_LabbDB.Models
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Course Course { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<TeacherSubject> TeacherSubjects { get; set; }
    }
}
