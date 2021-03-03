using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // string 보다 성능면에서 우수하다.
            //

            StringBuilder sb = new StringBuilder("Hello World\n");
            sb.Append("My name is Hugo\n");
            sb.Append("I'm \"47years \" old\n");
            sb.Append("Book price is 30,000 won.\n");
            sb.Insert(6, "New");
            sb.Replace("Book", "시계");

            Console.WriteLine(sb);
        }
    }
}
