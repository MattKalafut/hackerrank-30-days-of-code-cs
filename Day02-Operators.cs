// https://www.hackerrank.com/challenges/30-operators/problem
using System;

public class Program
{
    public static void Solve(double mealCost, int tipPercent, int taxPercent)
    {
        // tip = mealCost * (tip_percent/100)
        var tip = mealCost * (tipPercent / 100.0);

        // tax = mealCost * (tax_percent/100)
        var tax = mealCost * (taxPercent / 100.0);

        // totalCost = mealCost + tip + tax
        var totalCost = mealCost + tip + tax;

        // round to the nearest integer (Math.Round(double))
        totalCost = Math.Round(totalCost);
        Console.WriteLine(totalCost);
    }

    public static void Main(string[] args)
    {
        double mealCost = Convert.ToDouble(Console.ReadLine().Trim());

        int tipPercent = Convert.ToInt32(Console.ReadLine().Trim());

        int taxPercent = Convert.ToInt32(Console.ReadLine().Trim());

        Solve(mealCost, tipPercent, taxPercent);
    }
}