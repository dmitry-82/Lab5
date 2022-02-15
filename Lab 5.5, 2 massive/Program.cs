using System;

namespace Lab_5._5__2_massive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] 
            {
                { 1, 0, 1, 0, 1 }, 
                { 0, 1, 0, 1, 0 }, 
                { 1, 0, 1, 0, 1 }, 
                { 0, 1, 0, 1, 0 }, 
                { 1, 0, 1, 0, 1 }
            };
            Console.WriteLine(array [2, 1]);
            Console.ReadKey();
        }
    }
}
