using System;

namespace GitHubTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(MyMath.Add(1, 2));
            Console.WriteLine(MyMath.Sqrt(2));
            Console.WriteLine(MyMath.Sin(0.5));
            Console.WriteLine(MyMath.Cos(0.2));
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

        public static double Cos(double a)
        {
            return Math.Cos(a);
        }

        public static double Sin(double a)
        {
            return Math.Sin(a);
        }

        // alta metoda dupa
    }
}
