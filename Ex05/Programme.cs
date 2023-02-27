using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB
{
    internal class Programme
    {
        string name;
        const int MAX=100;
        Teacher principalLecturer;
        Student[] studentRegister;
        Course[] courses;
        Teacher[] teachers;
        public Programme(string name)
        {
            this.name = name;
            studentRegister = new Student[MAX];
            courses = new Course[MAX];
            teachers= new Teacher[MAX];
        }
        public bool AddStudent(Student student)
        {
            int i = 0;
            while (studentRegister[i] != null && i < MAX)
                i++;
            if (i < MAX)
            {
                this.studentRegister[i] = student;
                return true;
            }
            return false;
        }
        public bool AddTeacher(Teacher teacher)
        {
            int i = 0;
            while (teachers[i] != null && i < MAX)
                i++;
            if (i < MAX)
            {
                this.teachers[i] = teacher;
                return true;
            }
            return false;
        }
        public bool AddCourse(Course course)
        {
            int i = 0;
            while (courses[i] != null && i < MAX)
                i++;
            if (i < MAX)
            {
                this.courses[i] = course;
                return true;
            }
            return false;
        }
        public Student GetStudent(string name)
        {
            for (int i = 0; i < MAX; i++)
                if (studentRegister[i] != null && studentRegister[i].ToString().Contains(name))
                    return studentRegister[i];
            return null;
        }
        public Teacher GetTeacher(string name)
        {
            for (int i = 0; i < MAX; i++)
                if (teachers[i] != null && teachers[i].ToString().Contains(name))
                    return teachers[i];
            return null;
        }
        public Course GetCourse(string name)
        {
            for (int i = 0; i < MAX; i++)
                if (courses[i] != null && courses[i].ToString().Contains(name))
                    return courses[i];
            return null;
        }
        public Teacher PricipalLecturer
        {
            get { return principalLecturer; }
            set { this.principalLecturer = value; }
        }
        public void SetPricipalLecturer(Teacher teacher)
        {
            PricipalLecturer = teacher;
        }
        public Teacher GetPrincipalLecturer()
        {
            return PricipalLecturer;
        }        
        public override string ToString()
        {
            string str = $"{name}; Principal lecturer: {principalLecturer.ToString()}\n";
            foreach (Course course in courses)
            {
                if (course != null)
                    str += course.ToString()+"\n";
            }
            return str;
        }
    }
}
