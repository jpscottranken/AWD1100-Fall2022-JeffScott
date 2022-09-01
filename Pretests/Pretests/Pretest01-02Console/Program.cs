using System;

/*
 *      1-2b Rewrite C# GUI program Pretest01-02a 
 *      that converts distances from miles to 
 *      kilometers and:
 *      
 *      ●	Declare a named constant named KM_PER_MILE 
 *          which holds the number of kilometers in a mile
 *          (1.6 km per mile).
 *          
 *      ●	Prompt the user for a distance in miles.
 *      
 *      ●	Display the distance in both kilometers and miles. 
 *          For example: "3.0 miles is 4.8 kilometers"
 *          
 *      As a Console Program
 */

namespace Pretest01_02Console
{
    internal class Program
    {
        const decimal KM_PER_MILE = 1.6m;

        static void Main(string[] args)
        {
            //  Declare variables
            Console.Write("Enter Miles: ");
            decimal miles = Convert.ToDecimal(Console.ReadLine());
            decimal kilos = miles * KM_PER_MILE;

            Console.WriteLine(miles.ToString("n2") + " miles = " +
                              kilos.ToString("n2") + " kilometers");

            Console.ReadLine();
        }
    }
}
