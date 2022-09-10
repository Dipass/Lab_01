using System;

class Problem
{
    static void Main(string[] args)
    {
        int n = 2;
        for (int i = 0; i < n; i++)
        {
            double a = Convert.ToDouble(Console.ReadLine()), b = Convert.ToDouble(Console.ReadLine()), c = Convert.ToDouble(Console.ReadLine());
            double Avarage = (a + b + c) / 3;
            Console.WriteLine("Avarage ={0} ", Avarage);
        }
    }
}