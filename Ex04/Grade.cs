using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB
{
    internal class Grade
    {
        int studentID;
        int grade;
        public Grade(int studentID, int grade)
        {
            if (studentID < 1 || studentID > 1000)
                this.studentID = 0;
            else this.studentID=studentID;
            if (grade < 0 || grade > 5) this.grade = -1;
            else this.grade = grade;
        }
        public int GetStudentID()
        {
            return this.studentID;
        }
        public int GetGrade()
        {
            return this.grade;
        }
    }
}
