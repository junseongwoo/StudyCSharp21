using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateChainApp
{
    delegate void AllCalc(int a, int b);
    class Program
    {
        static void Plus(int a, int b) { Console.WriteLine($"a + b = {a + b} "); }
        static void Minus(int a, int b) { Console.WriteLine($"a - b = {a - b} "); }
        static void Multiple(int a, int b) { Console.WriteLine($"a * b = {a * b} "); }
        static void Divide(int a, int b) { Console.WriteLine($"a / b = {a / b} "); }
        static void Main(string[] args)
        {
            AllCalc allCalc = Plus;
            allCalc += Minus;
            allCalc += Multiple;
            allCalc += Divide;

            allCalc(10, 5);

            Console.WriteLine("곱셈 메서드 제거");
            allCalc -= Multiple;
            allCalc(10, 5);
        }
    }
}
