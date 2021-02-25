using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypeCastApp
{
    class 포유류
    {
        public void 키우다()
        {
            Console.WriteLine("자식을 키우다");
        }
    }

    class 강아지 : 포유류
    {
        public void 멍멍()
        {
            Console.WriteLine("멍멍");
        }
    }

    class 고양이 : 포유류
    {
        public void 냐옹()
        {
            Console.WriteLine("냐옹");
        }
    }

    class Program
    {
      


        static void Main(string[] args)
        {
            포유류 p = new 포유류();
            p.키우다();

            p = new 강아지();

            p = new 고양이();

            강아지 뽀삐 = (강아지) new 포유류();
            고양이 나비 = (고양이) new 포유류();

        }
    }
}
