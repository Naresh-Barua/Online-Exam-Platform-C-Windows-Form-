using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Faculty
    {
        private string facultyName
        { set; get; }
        private string facultyId
        { set; get; }
        public double Hours
        { set; get; }


        public Faculty(string facultyName, string facultyId, double Hours)
        {
            this.facultyName = facultyName;
            this.facultyId = facultyId;
            this.Hours = Hours;
        }

        public void SectionAdding(Section secName)
        {
            this.secName[SectionNo++] = secName;
            Hours += 1.5;
        }

        public void FacultyDetails()
        {
            Console.WriteLine("Faculty name is " + facultyName);
            Console.WriteLine("Faculty id is " + facultyId);
        }

        public void showSectionDetails()
        {
            foreach (Section x in secName)
            {
                x.showDetails();
            }
        }
        Section[] secName = new Section[20];
        private int SectionNo = 0;
    }
}
