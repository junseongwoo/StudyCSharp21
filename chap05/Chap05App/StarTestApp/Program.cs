﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 첫번째 별모양
            Console.WriteLine("별모양찍기");

            /*for (int i = 0; i<5; i ++)
            {
                for (int j =0; j < i + 1; j ++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }*/
            #endregion

            #region 두번째 별모양
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5-i; j++)
                {
                    Console.Write(" ");
                }
                for (int j =0; j <  i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            #endregion


        }
    }
}
