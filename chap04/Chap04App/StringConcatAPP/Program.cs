using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            /* var c = 123 + 456;
             var a = "123" + "456";
             var b = "123" + 456;
             int b1 = 456;
             string b2 = "123";
             var b3 = b1 + b2;
             Console.WriteLine(c.GetType());
             Console.WriteLine(a.GetType());
             Console.WriteLine(b3.GetType());*/

            int a1 = 30, a2 = 30;
            Console.WriteLine(a1 < a2);
            Console.WriteLine(a1 > a2);
            Console.WriteLine(a1 <= a2);
            Console.WriteLine(a1 >= a2);
            Console.WriteLine(a1 == a2);
            Console.WriteLine(a1 != a2);

            // 논리 연산자
            Console.WriteLine(10>9 && a1>0);
            Console.WriteLine(a1>a2 || a2>0);
            Console.WriteLine(!(a1<a2));

            // 조건 연산잔 단항 if문을 대체
            int a = 30;
            string result;

            if (a == 30)
                result = "a는 30";
            else
                result = "a는 30이 아님";

            string result1 = a == 30 ? "30" : "30아님";

            Console.WriteLine(result);
            Console.WriteLine(result1);

            Console.WriteLine("NULL 병합 연산자");
            int? d = null;
            Console.WriteLine($"{d}");

        }
    }
}
