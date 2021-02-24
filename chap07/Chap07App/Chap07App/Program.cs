using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap07App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("객체 사용");

            /*Cat cat1 = new Cat(); // 생성자는 new를 적어줘서 객체를 실체화 한다. 
            cat1.Name = "야옹이";
            cat1.Color = "갈색";
            cat1.Meow();

            Cat kitty = new Cat();
            kitty.Name = "헬로키티";
            kitty.Color = "하얀색";
            kitty.Meow();

            Cat nero = new Cat();
            nero.Name = "네로";
            nero.Color = "검은색";
            nero.Meow();*/

            Cat yomi = new Cat("요미", "흰색", "암컷");
            yomi.Meow();

        }
    }

    class Cat
    {
        public Cat() { }

        public Cat(string Name)
        {
            this.Name = Name;
        }


        public Cat(string Name, string Color) : this(Name)
        {
            this.Color = Color;
        }

        public Cat(string Name, string Color, string Gender) : this(Name, Color)
        {
            this.Gender = Gender;
        }

        public string Name;
        public string Color;
        public string Gender;

        public void Meow()
        {
            Console.WriteLine($"(색상 {this.Color} / 성별 {this.Gender}) {this.Name} : 야옹!");
        }
    }
}
