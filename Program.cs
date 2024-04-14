using Linq_LabbDB.Data;
using Microsoft.EntityFrameworkCore;

namespace Linq_LabbDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var mathTeachers = context.Teachers
          .Where(teacher => teacher.Subjects.Any(subject => subject.SubjectName == "Matematik"))
          .ToList();

                foreach (var teacher in mathTeachers)
                {
                    Console.WriteLine($"Matematik lärare: {teacher.TeacherName}");
                }

                Console.WriteLine("--------------------------");


                var studentsWithTeachers = context.Students
                .Where(student => student.CourseId != null) 
                .Join(
                    context.Teachers,
                    student => student.CourseId,
                    teacher => teacher.CourseId,
                    (student, teacher) => new
                 {
                    TeacherName = teacher.TeacherName,
                    StudentName = student.StudentName
                 })
                    .OrderBy(entry => entry.TeacherName) 
                    .ThenBy(entry => entry.StudentName) 
                    .ToList();

                string currentTeacher = "";
                foreach (var entry in studentsWithTeachers)
                {
                    if (entry.TeacherName != currentTeacher)
                    {
                        Console.WriteLine($"Lärare: {entry.TeacherName}");
                        
                        currentTeacher = entry.TeacherName;
                        
                    }
                    
                    Console.WriteLine($"  Student: {entry.StudentName}");
                    
                }

                Console.WriteLine("-------------------------");


                var containsProgramming1 = context.Subjects.Any(subject => subject.SubjectName == "Programmering 1");

                if (containsProgramming1)
                {
                    Console.WriteLine("Ämnet Programmering 1 finns i tabellen.");
                }
                else
                {
                    Console.WriteLine("Ämnet Programmering 1 finns inte i tabellen.");
                }


                Console.WriteLine("-------------------------");

                var subjectToUpdate = context.Subjects.FirstOrDefault(s => s.SubjectName == "Programmering 2");

                if (subjectToUpdate != null)
                {
                    subjectToUpdate.SubjectName = "OOP";


                    Console.WriteLine("Ämnet har uppdaterats till OOP.");
                }
                else
                {
                    Console.WriteLine("Ämnet Programmering 2 hittades inte i tabellen.");
                }

                Console.WriteLine("-------------------------");
                

            }
        }
    }
}


