using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address
{
    class AdInfo
    {
        public string name;
        public string phone;
        public string address;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("0. 주소 입력");
            Console.WriteLine("1. 주소 검색");
            Console.WriteLine("2. 주소 수정");
            Console.WriteLine("3. 주소 삭제");
            Console.WriteLine("4. 주소 전체 출력");
            Console.WriteLine("5. 프로그램 종료");
            Console.WriteLine("----------------------");
            

            while(true)
            {
                Console.Write("메뉴를 선택하세요 >>>  ");
                switch (Console.ReadLine())
                {
                    case "0":
                        Console.WriteLine("Your result:");
                        return;
                    case "1":
                        Console.WriteLine("Your result: ");
                        return;
                    case "2":
                        Console.WriteLine("Your result: ");
                        return;
                    case "3":
                        Console.WriteLine("Your result: ");
                        return;
                    case "4":
                        Console.WriteLine("Your result: ");
                        return;
                    case "5":
                        Console.WriteLine("Your result: ");
                        break;
                }
            }
        }


    }
}

