using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Department
    
        
        {
            private string deptName 
            { set; get; }
            
            public Department(string deptName)
            {
                this.deptName = deptName;
            }

            public void CourseAdding(Course courseName)
            {
                this.courseName[CourseNo++] = courseName;
            }
            public void Info()
            {
                Console.WriteLine(deptName);
            }

            Course[] courseName = new Course[20];
            private int CourseNo = 0;


    }
    
}
