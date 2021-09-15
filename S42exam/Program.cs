using System;
using System.Threading;

namespace S42exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int noOfStudents = 7;
            int noOfExamQuestion = 6, noOfExamQuestionChoises = 10, noOfCaseChoices = 6, noOfCases = 3;

            Random generator = new();

            string header = "   0 1 2 3 4 5 6 7 8 9 A B C D E F\n";

            for(int i = 0; i < noOfStudents; i++)
            {
                string row = $"{i + 1}: ";
                for(int j = 0; j < noOfExamQuestionChoises; j++)
                {
                    row += $"{generator.Next(1, noOfExamQuestion + 1)} ";
                    Thread.Sleep(10);
                }
                for(int j = 0; j < noOfCaseChoices; j++)
                {
                    row += $"{generator.Next(1, noOfCases + 1)} ";
                    Thread.Sleep(10);
                }
                row += "\n";
                header += row;
            }
            Console.WriteLine(header);
        }
    }
}
