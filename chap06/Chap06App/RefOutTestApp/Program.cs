using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 22, b = 3;
            int val = 0;
            int rem = 0;
            /*DivideOut(a, b, out val, out rem);*/
            DivideRef(a, b, ref val, ref rem);
            Console.WriteLine($"{a} / {b} : {val}");
            Console.WriteLine($"{a} % {b} : {rem}");

            bool isSucceed = float.TryParse("1000", out float result);
            Console.WriteLine($"변환결과 {isSucceed}, result 값 {result}");
        }

        private static void DivideRef(int a, int b, ref int quotient, ref int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        static void DivideOut(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b; 
            remainder = a % b;

        }

    }
}
