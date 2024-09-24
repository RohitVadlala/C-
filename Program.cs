using System;

namespace SchoolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of MiddleSchool and HighSchool
            MiddleSchool middleSchool = new MiddleSchool("SVM School", "Mr. Dhoni", 600, 5, 8);
            HighSchool highSchool = new HighSchool("SVM School", "Ms. Deepika", 1000, "Main Field");

            // Displaying information
            Console.WriteLine("Middle School Info:");
            middleSchool.DisplayInfo();

            Console.WriteLine("\nHigh School Info:");
            highSchool.DisplayInfo();
        }
    }
}
