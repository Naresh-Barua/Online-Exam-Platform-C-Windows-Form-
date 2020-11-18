using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Teacher
    {
            private string teacherName 
            { set; get; }
            private string teacherId 
            { set; get; }
            public double Hours
            { set; get; }

           
            public Teacher(string teacherName, string teacherId, double Hours)
            {
                this.teacherName = teacherName;
                this.teacherId = teacherId;
                this.Hours= Hours;
            }

            public void SectionAdding(Section secName)
            {
                this.secName[SectionNo++] = secName;
                Hours += 1.5;
            }

            public void TeacherDetails()
            {
                Console.WriteLine("teacher name is " + teacherName);
                Console.WriteLine("Teacher id is " + teacherId);
            }

            public void showSectionDetails()
            {
                foreach (Section i in secName)
                {
                    i.showDetails();
                }
            }
            Section[] secName = new Section[20];
            private int SectionNo = 0;



    }
}