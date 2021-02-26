using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOverrideTestApp
{
    class Mammal
    {
        public string Name { get; set; }

        public void Breathe()
        {
            Console.WriteLine($"{this.Name}이(가) 숨을 쉰다.");
        }

        public virtual void Move()
        {
            Console.WriteLine($"(부모작업) {this.Name}이(가) 이동한다.");
        }
    }
    class Dog : Mammal
    {
        /*public void Move()
        {
            Console.WriteLine($"{this.Name}이(가) 네발로 달린다.");
        }*/

        public override void Move()
        {
            base.Move(); //부모에 있는 move 실행
            Console.WriteLine($"{this.Name}이(가) 네발로 달린다.");
        }
    }
    class Human : Mammal
    {
        public new void Move() // 부모의 메서드를 숨긴다
        {
            Console.WriteLine($"{this.Name}이(가) 두발로 달린다.");
        }
    }
    class Whale : Mammal 
    {
        public void move()
        {
            Console.WriteLine($"{this.Name}이(가) 헤엄쳐서 움직인다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog reo = new Dog();
            reo.Name = "레오";
            reo.Move();

            Human junseong = new Human();
            junseong.Name = "준성";
            junseong.Move();

            Whale whale = new Whale();
            whale.Name = "고래";
            whale.move();
        }
    }
}
