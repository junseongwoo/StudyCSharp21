using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap13App
{
    class Program
    {
        delegate int MyDelegate(int a, int b); // 대리자로 호출하는 것은 타입과 변수가 동일 해야한다.
        class Calculator
        {
            
            public int Plus(int a, int b)
            {
                return a + b;
            }
            public int Minus(int a, int b)
            {
                return a - b;
            }
        }
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            MyDelegate Callback;

            Callback = new MyDelegate(calc.Plus);
            Console.WriteLine($"result = {Callback(3,4)}");

            Callback = new MyDelegate(calc.Minus);
            Console.WriteLine($"result = {Callback(5, 4)}");
        }
    }
}
