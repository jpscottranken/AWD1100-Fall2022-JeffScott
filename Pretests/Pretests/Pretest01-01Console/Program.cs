using System;

/*
 *  1-1b.	Rewrite C# GUI program Pretest01-01a 
 *          that calculates the average grade for a student:
 *          
 *          ●	Prompt the user for four test scores
 *          
 *          ●	Displays each test score and the average 
 *              of all test scores.
 *              
 *          As a Console Program
 */

namespace Pretest01_01Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Declare each testScore variable.
            Console.Write("Please Enter Test Score #1: ");
            int testScore1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nPlease Enter Test Score #2: ");
            int testScore2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nPlease Enter Test Score #3: ");
            int testScore3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nPlease Enter Test Score #4: ");
            int testScore4 = Convert.ToInt32(Console.ReadLine());

            //  totScore is the sum of the four test scores
            int totScore = testScore1 + testScore2 +
                           testScore3 + testScore4;

            //  avgScore is the totScore divided by 4 (# of tests)
            decimal avgScore = totScore / 4.0m;

            Console.WriteLine("Test Score 1: " + testScore1.ToString());
            Console.WriteLine("Test Score 2: " + testScore2.ToString());
            Console.WriteLine("Test Score 3: " + testScore3.ToString());
            Console.WriteLine("Test Score 4: " + testScore4.ToString());
            Console.WriteLine("Test Score Avg: " + avgScore.ToString("n2"));

            Console.ReadLine();
        }
    }
}
