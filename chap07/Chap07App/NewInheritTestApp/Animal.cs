using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewInheritTestApp
{
    class Animal
    {   

       
        public string Name { get; set; } // 프러퍼티
        public int Age { get; set; }

        public void Breath()
        {
            Console.WriteLine($"{this.Name} 이 숨을 쉽니다.");
        }

        public void HowOld()
        {
            Console.WriteLine($"{this.Name}의 나이는 {this.Age}살");
        }

    }
}
