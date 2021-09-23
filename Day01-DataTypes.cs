// https://www.hackerrank.com/challenges/30-data-types/problem
using System;

namespace Challenges
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";
            
            // Declare second integer, double & string variables
            int i2;
            double d2;
            string s2;
            
            // Read & save integer, double & string to variables
            i2 = Convert.ToInt32(Console.ReadLine());
            d2 = Convert.ToDouble(Console.ReadLine());
            s2 = Console.ReadLine();
            
            // Print the sum of i plus your int variable on a new line.
            Console.WriteLine(i + i2);
            
            // Print the sum of d plus your double variable to a scale of one decimal place on a new line
            Console.WriteLine((d + d2).ToString("F1"));
            
            // Concatenate s with the string you read as input and print the result on a new line
            Console.WriteLine($"{s}{s2}");
        }
    }
}