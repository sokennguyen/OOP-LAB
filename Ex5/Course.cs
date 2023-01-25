using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB
{
    internal class Course
    {
        string name;
        int credits;
        const int MAX_STUDENTS = 100;
        Teacher teacher;
        Student[] students = new Student[MAX_STUDENTS];
        public Course(string name, int credits)
        {
            this.name = name;
            this.credits = credits;
            teacher = new Teacher("NN");
        }
        public Course(string name, int credits, Teacher teacher) : this(name, credits)
        {
            this.teacher = teacher;
        }
        public void SetTeacher(Teacher teacher)
        {
            this.teacher = teacher;
        }
        public bool AddStudent(Student student)
        {
            if (this.students[Array.IndexOf(students, null)] == null)
            {
                this.students[Array.IndexOf(students, null)] = student;
                return true;
            }
            return false;
        }
        public string ToString()
        {
            string output = $"Course {name} {credits} ECTS:\r\nTeacher: {teacher.ToString()},\r\nstudents:\r\n";
            for (int i = 0; i < (Array.IndexOf(this.students, null)) - 1; i++)
            {
                output += students[i].ToString() + "\n";
            }
            return output;
        }
        public Student GetStudent(string name)
        {
            bool found = false;
            int index = 0;
            while (!found || index < Array.IndexOf(this.students, null)-1 && index < MAX_STUDENTS)
            {
                if (students[index].GetName() == name)
                {
                    found = true;
                    return students[index];
                }
                index++;
            }
            return null;
        }
        public void RemoveStudent(Student student)
        {
            student = null;
        }
    }
}
