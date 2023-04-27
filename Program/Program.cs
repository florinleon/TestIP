using System;

namespace GitHubTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(MyMath.Add(1, 2));
        }
    }

    public class MyMath
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }
    }
}
