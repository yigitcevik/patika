using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tekToplam = 0;
            int ciftToplam = 0;

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 1) tekToplam += i;
                else ciftToplam += i;
            }
            Console.WriteLine(tekToplam);
            Console.WriteLine(ciftToplam);

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
            }

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
            }
        }
    }
}
