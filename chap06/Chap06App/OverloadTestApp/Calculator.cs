using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadTestApp
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("계산기!");

            int x = Calculator.Plus(3, 4);
            Console.WriteLine($"3 + 4 = {x}");

            int total = 0;
            total = Sum(1, 2);

            Console.WriteLine($"10까지의 합은 {Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)}");

            int[] arrs = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };  // 배열을 만들어서 바로 적용함 
            Console.WriteLine($"10까지의 합은 {Sum(arrs)}"); 
        }

        private static int Sum(params int[] args)  //가변길이 매개변수 params
        {
            int result = 0;

            foreach (var arg in args)
            {
                result += arg;
            }
            return result;
        }

        private static int Plus(params int[] args)
        {
            int result = 0;

            foreach (var arg in args)
            {
                result += arg; 
            }
            return result;
        }
    }
}
