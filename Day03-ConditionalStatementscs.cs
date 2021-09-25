// https://www.hackerrank.com/challenges/30-conditional-statements/problem
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        if (n % 2 != 0)
        {
            Console.WriteLine("Weird");
        }

        if (n % 2 == 0)
        {
            if (n >= 2 && n <= 5)
            {
                Console.WriteLine("Not Weird");
            }

            if (n >= 6 && n <= 20)
            {
                Console.WriteLine("Weird");
            }

            if (n > 20)
            {
                Console.WriteLine("Not Weird");
            }
        }
    }
}