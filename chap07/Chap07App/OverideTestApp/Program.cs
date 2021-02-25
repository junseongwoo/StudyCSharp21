using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverideTestApp
{
    class Program
    {
        class ArmorSuite
        {
            public virtual void Initialize() // 버츄얼 쓰는 이유 : 자식클래스에서 재정의 
            {
                Console.WriteLine("ArmorSuite 초기화!");
            }
        }

        class IronMan : ArmorSuite
        {

        }

        class WarMachine : ArmorSuite
        {
            public override void Initialize()
            {
                /*base.Initialize();*/
                Console.WriteLine("무기 장착!");
                Console.WriteLine("보조 무기 장착!");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ArmorSuite 생산");
            ArmorSuite suite = new ArmorSuite();
            suite.Initialize();

            Console.WriteLine("워머신 생산");
            WarMachine machine = new WarMachine();
            machine.Initialize();

        }
    }
}
