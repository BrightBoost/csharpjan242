using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniExercises.objectsMethodsOOP.SchoolManagementSystem
{
    public class Course
    {
        public string CourseName { get; set; }
        public Teacher CourseTeacher { get; set; }
        public List<Student> Students { get; set; }

        public Course(string courseName, Teacher courseTeacher)
        {
            CourseName = courseName;
            CourseTeacher = courseTeacher;
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }
}
