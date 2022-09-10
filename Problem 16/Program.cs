using System;

class Problem
{
    static void Main(string[] args)
    {
        int n;
        
        do
        {
            Console.WriteLine("select a day from 1 to 7. Select a number by range to exit  = ");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Thuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("not valid");
                    break;
            }
        }
        while (n >=1 && n <=7);
    }
}
