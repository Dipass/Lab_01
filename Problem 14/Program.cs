using System;

class Problem
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 2; i++)
        {
            int a = Convert.ToInt32(Console.ReadLine()), b = Convert.ToInt32(Console.ReadLine()), c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("Max = {0}",a);
                }
                else
                {
                    Console.WriteLine("Max = {0}", c);
                }
            }
            else if (b > c)
            {
                Console.WriteLine("Max = {0}", b);
            }
            else
            {
                Console.WriteLine("Max = {0}", c);
            }
        }
    }
}
