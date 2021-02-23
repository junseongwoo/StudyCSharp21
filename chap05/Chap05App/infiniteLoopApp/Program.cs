using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infiniteLoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            byte idx = 0;

            while(true)
            {
                Console.WriteLine($"idx = {idx++}");
            }
        }
    }
}
