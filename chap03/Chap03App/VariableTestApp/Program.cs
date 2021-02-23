using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int v1 = 30, v2 = 40;
            int result = v1 + v2;
            Console.WriteLine("결과는 " + result);*/

            // byte 형
            sbyte sbMaxVal = sbyte.MaxValue;
            sbyte sbMinVal = sbyte.MinValue;
            Console.WriteLine($"sbyte 최대, 최소값은 {sbMaxVal}, {sbMinVal} 입니다.");
            byte bMinVal = byte.MinValue, bmaxVal = byte.MaxValue;
            Console.WriteLine($"byte 최대, 최소값은 {bmaxVal}, {bMinVal} 입니다.");

            // short 형
            short shMaxVal = short.MaxValue, shMinVal = short.MinValue;
            Console.WriteLine($"short 최대, 최소값은 {shMaxVal}, {shMinVal} 입니다.");
            ushort ushMaxVal = ushort.MaxValue, ushMinVal = ushort.MinValue;
            Console.WriteLine($"ushort 최대, 최소값은 {ushMaxVal}, {ushMinVal} 입니다.");
            
            // int 형
            int intMaxVal = int.MaxValue, intMinVal = int.MinValue;
            Console.WriteLine($"int 최대, 최소값은 {intMaxVal}, {intMinVal} 입니다.");
            uint uintMaxVal = uint.MaxValue, uintMinVal = uint.MinValue;
            Console.WriteLine($"uint 최대, 최소값은 {uintMaxVal}, {uintMinVal} 입니다.");

            // long 형 
            long lnMaxVal = long.MaxValue, lnMinVal = long.MinValue;
            Console.WriteLine($"long 최대, 최소값은 {lnMaxVal}, {lnMinVal} 입니다.");
            ulong ulnMaxVal = ulong.MaxValue, ulnMinVal = ulong.MinValue;
            Console.WriteLine($"ulong 최대, 최소값은 {ulnMaxVal}, {ulnMinVal} 입니다.");
        }
    }
}
