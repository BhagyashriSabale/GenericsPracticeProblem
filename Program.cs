﻿namespace GenericsPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Find Maximum numer Problem");

            int[] intArray = { 100, 200, 300 };
            MaximumNum<int> maximum = new MaximumNum<int>(intArray);
            maximum.PrintMaxVlue();

            double[] doubleArray = { 435.3, 12.4, 187.45 };
            MaximumNum<double> maximum1 = new MaximumNum<double>(doubleArray);
            maximum1.PrintMaxVlue();
        }
    }
}