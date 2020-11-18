using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Course
    {
            private string courseName
            { set; get; }
            private string courseId
            { set; get; }

            public Course(string courseName, string courseId)
            {
                this.courseName = courseName;
                this.courseId = courseId;
            }

            public void SectionAdding(Section secName)

            {
                this.secName[SectionNo++] = secName;
            }
            public void SectionAndFaculty()
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
