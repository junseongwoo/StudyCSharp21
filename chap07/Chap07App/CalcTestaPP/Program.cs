﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTestApp
{
    class Program
    {
        class Mathz
        {
            public int Plus(int a, int b)
            {
                return 1;
            }

            public void PrintEven(int val)
            {
                if (val % 2 ==0)
                {
                    Console.WriteLine($"값 : {val}");
                }
            }
        }

        static void Main(string[] args)
        {
            Mathz mathz = new Mathz();
            int x;

            x = 5;
            /*if (x%2 ==0)
            {
                Console.WriteLine($"x의 값 : {x}");
            }*/

            mathz.PrintEven(x);
            
            x = 10;
            /*if (x%2==0)
            {
                Console.WriteLine($"x의 값 : {x}");
            }*/

            mathz.PrintEven(x);

            
        }
    }
}
