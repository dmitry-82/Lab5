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
            int[] array = new int[7];
            array [0] = 24;
            array [1] = 5;
            array [2] = 2;
            array [3] = 9;
            array [4] = 12;
            array [5] = 8;
            array [6] = 19;
            float S = 0;
            for (int i = 0; i < 7; i++)
            {
                S += array[i];
                Console.Write("{0} ", array[i]);
            }
            Console.Write("{0,10:f2}", S / 7);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
