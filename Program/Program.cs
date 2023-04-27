﻿using System;

namespace GitHubTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(MyMath.Add(1, 2));
            Console.WriteLine(MyMath.Sqrt(2));
        }
    }

    public class MyMath
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Sqrt(double a)
        {
            return Math.Sqrt(a);
        }
    }
}
