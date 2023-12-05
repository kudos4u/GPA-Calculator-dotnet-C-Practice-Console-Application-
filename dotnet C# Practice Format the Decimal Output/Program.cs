using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_C__Practice_Format_the_Decimal_Output
{
    internal class Program
    {
        static void Main(string[] args)
        {// Study note: Declaring string variables for the students name, and 5 courses.
            string assignmentTitle = "Assignment: Practice Formatting the Decimal Output";
            string studentName = "Sophia Johnson";
            string course1Name = "English 101";
            string course2Name = "Algebra 101";
            string course3Name = "Biology 101";
            string course4Name = "Computer Science I";
            string course5Name = "Psychology 101";
            string devNote = "Created using Visual Studio's dotnet IDE\nFoundational C# with Microsoft Certification Exam Practice by FreeCodeCamp.org";

            // Study note: Declaring int variables for the credit value of each course.
            int course1Credit = 3;
            int course2Credit = 3;
            int course3Credit = 4;
            int course4Credit = 4;
            int course5Credit = 3;

            // Study note: Declaring int variables for the grade value accomplished by teh student.
            int gradeA = 4;
            int gradeB = 3;

            int course1Grade = gradeA;
            int course2Grade = gradeB;
            int course3Grade = gradeB;
            int course4Grade = gradeB;
            int course5Grade = gradeA;

            // Study note: Assigning int variables.
            int totalCreditHours = 0;
            totalCreditHours += course1Credit;
            totalCreditHours += course2Credit;
            totalCreditHours += course3Credit;
            totalCreditHours += course4Credit;
            totalCreditHours += course5Credit;

            // Study note: This is an interpoalted string used to print the course name, grade, & course credit value to the output.
            // An interpolated string is defined by placing the $ symbol before the opening double quotation mark.
            // It enables the embedding of expressions or variables within the string using curly braces {}. 
            int totalGradePoints = 0;
            totalGradePoints += course1Credit * course1Grade;
            totalGradePoints += course2Credit * course2Grade;
            totalGradePoints += course3Credit * course3Grade;
            totalGradePoints += course4Credit * course4Grade;
            totalGradePoints += course5Credit * course5Grade;

            // Perform GPA calculation here
            decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

            int leadingDigit = (int)gradePointAverage;
            int firstDigit = (int)(gradePointAverage * 10) % 10;
            int secondDigit = (int)(gradePointAverage * 100) % 10;

            // Output the result
            Console.WriteLine(assignmentTitle);
            Console.WriteLine($"Student: {studentName}\n");
            Console.WriteLine("Course\t\t\tGrade\tCredit Hours");
            Console.WriteLine($"{course1Name}\t\t{course1Grade}\t\t{course1Credit}");
            Console.WriteLine($"{course2Name}\t\t{course2Grade}\t\t{course2Credit}");
            Console.WriteLine($"{course3Name}\t\t{course3Grade}\t\t{course3Credit}");
            Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
            Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");

            Console.WriteLine($"Final GPA: \t\t{leadingDigit}.{firstDigit}{secondDigit}");

            Console.WriteLine(devNote);

            // Keep the console window open
            Console.ReadLine();
        }
    }
}