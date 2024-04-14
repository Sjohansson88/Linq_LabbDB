using Linq_LabbDB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_LabbDB.Data
{
    internal class SchoolContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<TeacherSubject> TeacherSubjects { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = LAPTOP-GIGGNJEG;Initial Catalog=School;Integrated security = true; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>()
        .HasMany(t => t.Subjects)
        .WithMany(s => s.Teachers)
        .UsingEntity<TeacherSubject>(
            j => j
                .HasOne(ts => ts.Subject)
                .WithMany(s => s.TeacherSubjects)
                .HasForeignKey(ts => ts.SubjectId),
            j => j
                .HasOne(ts => ts.Teacher)
                .WithMany(t => t.TeacherSubjects)
                .HasForeignKey(ts => ts.TeacherId),
            j =>
            {
                j.HasKey(ts => new { ts.TeacherId, ts.SubjectId });
                j.ToTable("TeacherSubject");
            }
        );

            modelBuilder.Entity<StudentCourse>()
    .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCourses)

                .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(sc => sc.CourseId);




            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Subjects)
                .WithMany(s => s.Teachers)
            .UsingEntity(j => j.ToTable("TeacherSubject"));

            modelBuilder.Entity<Course>()
                .HasMany(c => c.Subjects)
                .WithOne(s => s.Course);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Teacher)
                .WithMany(t => t.Students);

            modelBuilder.Entity<Subject>()
                .HasMany(s => s.Teachers)
                .WithMany(t => t.Subjects)
                .UsingEntity(j => j.ToTable("TeacherSubject"));

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Teacher)
                .WithMany(t => t.Students)
                .HasForeignKey(s => s.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);




            modelBuilder.Entity<Teacher>().HasData(
               new Teacher { TeacherId = 1, TeacherName = "Anas", CourseId = 1 },
               new Teacher { TeacherId = 2, TeacherName = "Reidar", CourseId = 2 },
               new Teacher { TeacherId = 3, TeacherName = "Tobias", CourseId = 3 }
           );

            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, StudentName = "Gabriella", CourseId = 1 },
                new Student { StudentId = 2, StudentName = "Johan", CourseId = 1 },
                new Student { StudentId = 3, StudentName = "Pär", CourseId = 2 },
                new Student { StudentId = 4, StudentName = "Erik", CourseId = 3 },
                new Student { StudentId = 5, StudentName = "Håkan", CourseId = 2 },
                new Student { StudentId = 6, StudentName = "Jessica", CourseId = 1 },
                new Student { StudentId = 7, StudentName = "Stina", CourseId = 3 },
                new Student { StudentId = 8, StudentName = "Lina", CourseId = 1 },
                new Student { StudentId = 9, StudentName = "Anders", CourseId = 2 },
                new Student { StudentId = 10, StudentName = "Leif", CourseId = 3 }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course { CourseId = 1, CourseName = "SUT21" },
                new Course { CourseId = 2, CourseName = "SUT22" },
                new Course { CourseId = 3, CourseName = "SUT23" }
            );

            modelBuilder.Entity<Subject>().HasData(
                new Subject { SubjectId = 1, SubjectName = "Programmering 1" },
                new Subject { SubjectId = 2, SubjectName = "Programmering 2" },
                new Subject { SubjectId = 3, SubjectName = "Avancerad .NET" },
                new Subject { SubjectId = 4, SubjectName = "Svenska" },
                new Subject { SubjectId = 5, SubjectName = "Engelska" },
                new Subject { SubjectId = 6, SubjectName = "Matematik" },
                new Subject { SubjectId = 7, SubjectName = "Idrott" }
            );

            modelBuilder.Entity<TeacherSubject>().HasData(
                new TeacherSubject { TeacherId = 1, SubjectId = 1 },
                new TeacherSubject { TeacherId = 1, SubjectId = 2 },
                new TeacherSubject { TeacherId = 1, SubjectId = 3 },
                new TeacherSubject { TeacherId = 2, SubjectId = 4 },
                new TeacherSubject { TeacherId = 2, SubjectId = 5 },
                new TeacherSubject { TeacherId = 3, SubjectId = 6 },
                new TeacherSubject { TeacherId = 3, SubjectId = 7 }
                );


            base.OnModelCreating(modelBuilder);
        }
    }
    }

