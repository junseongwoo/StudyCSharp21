﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingEventApp
{
    delegate void EventHandler(string message);

    class CustomNotifier
    {
        public event EventHandler SomethingHappend;

        public void DoSomething(int number)
        {
            int temp = number % 10;

            if (temp != 0 && temp % 3 ==0)
            {
                SomethingHappend($"{number} : 짝!");
            }
            else
            {
                SomethingHappend($"{number}"); // 이벤트를 사용
            }
        }
    }
    class Program
    {
        public static void MyHandler(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("이벤트 사용!");
            CustomNotifier notifier = new CustomNotifier();
            notifier.SomethingHappend += new EventHandler(MyHandler); // 이벤트를 내가만든 로직이 있는 메서드랑 연결

            for (int i = 1; i < 100; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}
