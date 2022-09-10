using System;

class Problem
{
    static void Main(string[] args)
    {
        bool Result;
        for (int i = 0; i < 6; i++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 9 == 0 || n % 11 == 0 || n % 13 == 0)
            {
                Result = true;
                Console.WriteLine(Result);
            }
            else
            {
                Result = false;
                Console.WriteLine(Result);
            }
        }
    }
}