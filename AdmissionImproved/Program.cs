/* 
 * This program determines whether Grade Point Average and Admission Test Scores meet the requirements for admission.
 * 
 * User inputs a grade point average (e.g., 3.2) and an admission test score (e.g., 75).
 * Program checks for reasonable inputs
 * 
 * Program outputs the message "Accept" if the input meets requirements or 
 * "Reject" if it doesn't.
 * 
 * Program loops
 */

using System;
using static System.Console;

namespace AdmissionImproved
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double MIN_GPA = 3.0;
            const int LOW_TEST_SCORE = 60;
            const int HIGH_TEST_SCORE = 80;

            double gradePointAverage;
            int admissionTestScore;
            string userInput;

            //Prompt for Grade Point Average
            Write("Please enter your Grade Point Average: ");
            userInput = ReadLine();

            //Check for reasonable GPA input
            while (!double.TryParse(userInput, out gradePointAverage) || gradePointAverage < 0 || gradePointAverage > 4)
            {
                WriteLine("Invalid entry! Enter a positive value up to 4.0: ");
                userInput = ReadLine();
            }

            //Prompt for Admission Test Score
            Write("Enter your Admission Test Score: ");
            userInput = ReadLine();

            //Check for reasonable Test Score input
            while (!int.TryParse(userInput, out admissionTestScore) || admissionTestScore < 0 || admissionTestScore > 100)
            {
                WriteLine("Invalid entry! Enter a positive value up to 100: ");
                userInput = ReadLine();
            }

            //Calculate and output result
            WriteLine((gradePointAverage >= MIN_GPA && admissionTestScore >= LOW_TEST_SCORE) || (gradePointAverage < MIN_GPA && admissionTestScore >= HIGH_TEST_SCORE) ? "Accept" : "Reject");
        }
    }
}
