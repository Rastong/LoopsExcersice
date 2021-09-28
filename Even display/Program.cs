using System;

namespace Even_display
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 100; i++)
            {
                int OddOrEven = i % 2;
                if(OddOrEven == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
