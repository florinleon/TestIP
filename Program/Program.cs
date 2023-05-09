using System;

namespace GitHubTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(MyMathSimple.Add(1, 2));
            Console.WriteLine(MyMathAdvanced.Sqrt(2));
            Console.WriteLine(MyMathAdvanced.Sin(0.5));
            Console.WriteLine(MyMathAdvanced.Cos(0.2));
        }
    }

    public class MyMathSimple
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }
    }

    public class MyMathAdvanced
    {
        public static double Sqrt(double a)
        {
            return Math.Sqrt(a);
        }

        public static double Cos(double a)
        {
            return Math.Cos(a);
        }

        public static double Sin(double a)
        {
            return Math.Sin(a);
        }
    }
}
