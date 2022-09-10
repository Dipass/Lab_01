using System;

class Problem
{
    static void Main(string[] args)
    {
        int factorial = 1, q = 2;
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < n; i++)
        {
            factorial = factorial * i;
            Console.WriteLine(factorial);
        }
    }
}