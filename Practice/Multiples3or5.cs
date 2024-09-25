// Project Euler - Project 1

using System;

namespace Practice
{
    class Multiples
    {
        public static void Main()
        {
            int total = 0;
            for (int i=0; i<1000; i++)
            {
                if (i % 3 == 0)
                {
                    total = total + i;
                }
                else if (i % 5 == 0)
                {
                    total = total + i;
                }
            Console.WriteLine(total);
            }
        }
    }
}
