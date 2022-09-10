using System;

class Problem
{
    static void Main(string[] args)
    {
        int n = 2;
        for (int i = 0; i < n; i++)
        {
            double a = Convert.ToDouble(Console.ReadLine()), b = Convert.ToDouble(Console.ReadLine()), h = Convert.ToDouble(Console.ReadLine());
            double Area = ((a + b) / 2) * h;
            Console.WriteLine("Avarage ={0} ", Area);
        }
    }
}
