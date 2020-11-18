using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Section
    {
        
            private string secName
            { get; set; }
            Teacher teacherName;

            public Section(string secName)
            {
                this.secName = secName;
            }

            public void TeacherAdding(Teacher teacherName)
            {
                if (teacherName.Hours < 21)
                {
                    this.teacherName = teacherName;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }

            }

            public void showDetails()
            {
                Console.WriteLine("Section is " + secName);
                teacherName.TeacherDetails();
            }
        
    }
}
