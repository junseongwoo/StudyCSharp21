﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewInheritTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("동물 클래스 상속");

            Animal animal = new Animal();
            animal.Name = "동물";
            animal.Age = 100;
            animal.Breath();

            Dog dog = new Dog();
            dog.Name = "뽀삐";
            dog.Age = 2000;
            dog.Bark();
            dog.HowOld();

        }
    }
}
