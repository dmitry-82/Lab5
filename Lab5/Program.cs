using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int elements = int.Parse (Console.ReadLine());
            int[] array = new int[7];
            Random random = new Random();
            float S = 0;
            for (int i = 0; i < 7; i++)
            {
                array[i] = elements(0,7);
                S += array[i];
                Console.Write("{0} ", array[i]);
            }
            Console.Write("{0,7:f2}", S / 7);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
