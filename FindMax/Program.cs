using System;

namespace FindMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();
            int S = 0;
            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int max = array[0];
            int min = array[0];
            foreach (int a in array)
            {
                if (a > max)
                    max = a;
            foreach (int b in array)
                    if (b < min)
                    min = b;
            }
            S = max + min;
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(S);
            Console.ReadKey();
        }
    }
}
