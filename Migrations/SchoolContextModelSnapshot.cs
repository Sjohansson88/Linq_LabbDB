﻿// <auto-generated />
using System;
using Linq_LabbDB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Linq_LabbDB.Migrations
{
    [DbContext(typeof(SchoolContext))]
    partial class SchoolContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Linq_LabbDB.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            CourseName = "SUT21"
                        },
                        new
                        {
                            CourseId = 2,
                            CourseName = "SUT22"
                        },
                        new
                        {
                            CourseId = 3,
                            CourseName = "SUT23"
                        });
                });

            modelBuilder.Entity("Linq_LabbDB.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.HasIndex("CourseId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            CourseId = 1,
                            StudentName = "Gabriella",
                            TeacherId = 0
                        },
                        new
                        {
                            StudentId = 2,
                            CourseId = 1,
                            StudentName = "Johan",
                            TeacherId = 0
                        },
                        new
                        {
                            StudentId = 3,
                            CourseId = 2,
                            StudentName = "Pär",
                            TeacherId = 0
                        },
                        new
                        {
                            StudentId = 4,
                            CourseId = 3,
                            StudentName = "Erik",
                            TeacherId = 0
                        },
                        new
                        {
                            StudentId = 5,
                            CourseId = 2,
                            StudentName = "Håkan",
                            TeacherId = 0
                        },
                        new
                        {
                            StudentId = 6,
                            CourseId = 1,
                            StudentName = "Jessica",
                            TeacherId = 0
                        },
                        new
                        {
                            StudentId = 7,
                            CourseId = 3,
                            StudentName = "Stina",
                            TeacherId = 0
                        },
                        new
                        {
                            StudentId = 8,
                            CourseId = 1,
                            StudentName = "Lina",
                            TeacherId = 0
                        },
                        new
                        {
                            StudentId = 9,
                            CourseId = 2,
                            StudentName = "Anders",
                            TeacherId = 0
                        },
                        new
                        {
                            StudentId = 10,
                            CourseId = 3,
                            StudentName = "Leif",
                            TeacherId = 0
                        });
                });

            modelBuilder.Entity("Linq_LabbDB.Models.StudentCourse", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("Linq_LabbDB.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectId"));

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("SubjectName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectId");

                    b.HasIndex("CourseId");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            SubjectId = 1,
                            SubjectName = "Programmering 1"
                        },
                        new
                        {
                            SubjectId = 2,
                            SubjectName = "Programmering 2"
                        },
                        new
                        {
                            SubjectId = 3,
                            SubjectName = "Avancerad .NET"
                        },
                        new
                        {
                            SubjectId = 4,
                            SubjectName = "Svenska"
                        },
                        new
                        {
                            SubjectId = 5,
                            SubjectName = "Engelska"
                        },
                        new
                        {
                            SubjectId = 6,
                            SubjectName = "Matematik"
                        },
                        new
                        {
                            SubjectId = 7,
                            SubjectName = "Idrott"
                        });
                });

            modelBuilder.Entity("Linq_LabbDB.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("TeacherName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.HasIndex("CourseId");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            CourseId = 1,
                            TeacherName = "Anas"
                        },
                        new
                        {
                            TeacherId = 2,
                            CourseId = 2,
                            TeacherName = "Reidar"
                        },
                        new
                        {
                            TeacherId = 3,
                            CourseId = 3,
                            TeacherName = "Tobias"
                        });
                });

            modelBuilder.Entity("Linq_LabbDB.Models.TeacherSubject", b =>
                {
                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("TeacherId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("TeacherSubject", (string)null);

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            SubjectId = 1
                        },
                        new
                        {
                            TeacherId = 1,
                            SubjectId = 2
                        },
                        new
                        {
                            TeacherId = 1,
                            SubjectId = 3
                        },
                        new
                        {
                            TeacherId = 2,
                            SubjectId = 4
                        },
                        new
                        {
                            TeacherId = 2,
                            SubjectId = 5
                        },
                        new
                        {
                            TeacherId = 3,
                            SubjectId = 6
                        },
                        new
                        {
                            TeacherId = 3,
                            SubjectId = 7
                        });
                });

            modelBuilder.Entity("Linq_LabbDB.Models.Student", b =>
                {
                    b.HasOne("Linq_LabbDB.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Linq_LabbDB.Models.Teacher", "Teacher")
                        .WithMany("Students")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Linq_LabbDB.Models.StudentCourse", b =>
                {
                    b.HasOne("Linq_LabbDB.Models.Course", "Course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Linq_LabbDB.Models.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Linq_LabbDB.Models.Subject", b =>
                {
                    b.HasOne("Linq_LabbDB.Models.Course", "Course")
                        .WithMany("Subjects")
                        .HasForeignKey("CourseId");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Linq_LabbDB.Models.Teacher", b =>
                {
                    b.HasOne("Linq_LabbDB.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Linq_LabbDB.Models.TeacherSubject", b =>
                {
                    b.HasOne("Linq_LabbDB.Models.Subject", "Subject")
                        .WithMany("TeacherSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Linq_LabbDB.Models.Teacher", "Teacher")
                        .WithMany("TeacherSubjects")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Linq_LabbDB.Models.Course", b =>
                {
                    b.Navigation("StudentCourses");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("Linq_LabbDB.Models.Student", b =>
                {
                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("Linq_LabbDB.Models.Subject", b =>
                {
                    b.Navigation("TeacherSubjects");
                });

            modelBuilder.Entity("Linq_LabbDB.Models.Teacher", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("TeacherSubjects");
                });
#pragma warning restore 612, 618
        }
    }
}
