using System;

class Problem
{
    static void Main(string[] args)
    {
        int n, number;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter number = ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Output the nth digit of the number from the end = ");
            n = Convert.ToInt32(Console.ReadLine());
            int abs;
            if (number <= 99 && number >= 0)
            {
                if (n == 1)
                {
                    abs = number % 10;
                    Console.WriteLine("Your number = {0} ", abs);
                }
                else if (n == 2)
                {
                    abs = (number % 100) / 10;
                    Console.WriteLine("Your number = {0} ", abs);
                }

            }
            if (number <= 999 && number > 99)
            {
                if (n == 1)
                {
                    abs = number % 10;
                    Console.WriteLine(abs);
                }
                else if (n == 2)
                {
                    abs = (number % 100) / 10;
                    Console.WriteLine(abs);
                }
                else if (n == 3)
                {
                    abs = (number % 1000) / 100;
                    Console.WriteLine(abs);
                }
            }
            if (number <= 9999 && number > 999)
            {
                if (n == 1)
                {
                    abs = number % 10;
                    Console.WriteLine(abs);
                }
                else if (n == 2)
                {
                    abs = (number % 100) / 10;
                    Console.WriteLine(abs);
                }
                else if (n == 3)
                {
                    abs = (number % 1000) / 100;
                    Console.WriteLine(abs);
                }
                else if (n == 4)
                {
                    abs = (number % 10000) / 1000;
                    Console.WriteLine(abs);
                }
            }
        }

    }
}