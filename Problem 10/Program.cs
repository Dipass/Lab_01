using System;

class Problem
{
    static void Main(string[] args)
    {
        int q = 3;
        for (int i = 0; i < q; i++)
        {
            double n = Convert.ToDouble(Console.ReadLine());
            double result = n % 10;
            Console.WriteLine(result);
        }
    }
}
