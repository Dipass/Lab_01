using System;

class Problem
{
    static void Main(string[] args)
    {
        bool Result;
        for (int i = 0; i < 4; i++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 20 && (n % 2) == 1)
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