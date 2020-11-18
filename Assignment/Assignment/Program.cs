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

            Teacher TanvirAhmed = new Teacher("Tanvir Ahmed", "000-111-222", 14);
            TanvirAhmed.SectionAdding(annexOne);
            TanvirAhmed.SectionAdding(annexTwo);
            annexOne.TeacherAdding(TanvirAhmed);
            annexTwo.TeacherAdding(TanvirAhmed);

            java.SectionAndTeacher();
            TanvirAhmed.showSectionDetails();

        }
    }
}
