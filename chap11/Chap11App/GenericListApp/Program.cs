﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListApp
{
    class Program
    {
        //실무에서 가장 많이 사용되는 컬렉션1
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
            list.Reverse();

            Console.WriteLine("역정렬");
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
