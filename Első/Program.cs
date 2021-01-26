using System;

namespace Első
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long DIVSUM = 0;
            if (N >= 1 && N <= 99999999)
            {
                for (int i = 1; i <= N; i++)
                {
                    DIVSUM += i * (N / i);
                }
            }
            Console.WriteLine("1-" + N + "-ig a számok osztóinak összege: " + DIVSUM + ".");
        }
    }
}
