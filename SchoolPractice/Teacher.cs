using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Teacher
    {
        public Teacher
        {
            private static int nextTeacherID = 1;
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int TeacherID { get; set; }
            public string Subject { get; set; }
        public int YearsTeaching { get; set; } = 0;

        public Teacher(string firstName, string lastName, int teacherID, string subject, int yearsTeaching)
        {
            FirstName = firstName;
            LastName = lastName;
            TeacherID = teacherID;
            Subject = subject;
            YearsTeaching = yearsTeaching;
        }

        public Teacher(string firstName, string lastName, int teacherID, string subject): this(firstName, lastName, teacherID, subject, 0) { }

        public Teacher(string firstName): this(firstName, nextTeacherID)
        {
            nextTeacherID++;
        }
        }
    }
}

