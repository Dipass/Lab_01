using System;

class Problem
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 3; i++)
        {
            double a = Convert.ToDouble(Console.ReadLine()), b = Convert.ToDouble(Console.ReadLine()), c = Convert.ToDouble(Console.ReadLine());
            double Sign;
            Sign = a * b * c;
            Console.WriteLine(Sign > 0 ? "Positive" : "Negative");
        }
    }
}
