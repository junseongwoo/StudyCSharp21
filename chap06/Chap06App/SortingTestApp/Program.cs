using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 47, y = 5;
            Console.WriteLine($"Before Swap {x}, {y}");

            Program.swap(x, y); // 정렬 기반 

            Program.ref_swap(ref x,ref y); // 정렬 기반 

            Console.WriteLine($"After Swap {x}, {y}");
        }

        private static void swap(int p1, int p2)
        {
            int temp = p1;
            Console.WriteLine($"tmep : {temp}, p1 : {p1}, p2 : {p2}");
            p1 = p2;
            Console.WriteLine($"tmep : {temp}, p1 : {p1}, p2 : {p2}");
            p2 = temp;
            Console.WriteLine($"tmep : {temp}, p1 : {p1}, p2 : {p2}");

        }
        private static void ref_swap(ref int p1, ref int p2)
        {
            int temp = p1;
            Console.WriteLine($"tmep : {temp}, p1 : {p1}, p2 : {p2}");
            p1 = p2;
            Console.WriteLine($"tmep : {temp}, p1 : {p1}, p2 : {p2}");
            p2 = temp;
            Console.WriteLine($"tmep : {temp}, p1 : {p1}, p2 : {p2}");

        }
    }
}
