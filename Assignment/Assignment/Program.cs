using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Department cse = new Department("CSE");
            Course java = new Course("java", "311");
            cse.CourseAdding(java);

            Section annexOne = new Section("Annex_3101");
            Section annexTwo = new Section("Annex_3102");

            java.SectionAdding(annexOne);
            java.SectionAdding(annexTwo);

            Faculty TanvirAhmed = new Faculty("Tanvir Ahmed", "000-111-222", 14);
            TanvirAhmed.SectionAdding(annexOne);
            TanvirAhmed.SectionAdding(annexTwo);
            annexOne.FacultyAdding(TanvirAhmed);
            annexTwo.FacultyAdding(TanvirAhmed);

            
            TanvirAhmed.showSectionDetails();
            java.SectionAndFaculty();
        }
    }
}
