using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Section
    {
        
            private string secName
            { get; set; }
            Faculty facultyName;

            public Section(string secName)
            {
                this.secName = secName;
            }

            public void FacultyAdding(Faculty facultyName)
            {
                if (facultyName.Hours < 21)
                {
                    this.facultyName = facultyName;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }

            }

            public void showDetails()
            {
                Console.WriteLine("Section is " + secName);
                facultyName.FacultyDetails();
            }
        
    }
}
