﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap11App
{
    class Program  // 일반화를 하게 되면 타입이 다른 같은 일들을 하나로 만들어 편하게 사용한다. 
    {
        static void Main(string[] args)
        {
            int[] source = { 11, 21, 33, 45, 56 }; // 5개 int 배열
            int[] target = new int[source.Length]; // 5개 int 배열 초기화

            CopyArray(source, target);             // int 배열 복사

            Console.WriteLine("배열복사 1");
            foreach (var item in target)
            {
                Console.WriteLine(item);
            }

            string[] source2 = { "원", "투", "쓰리", "포", "파이브" };
            string[] target2 = new string[source2.Length];

            CopyArray(source2, target2);

            Console.WriteLine("배열복사 2");
            foreach (var item in target2)
            {
                Console.WriteLine(item);
            }

            float[] source3 = { 1.1f, 2.2f, 3.3f, 4.4f, 5.5f };
            float[] target3 = new float[source2.Length];

            CopyArray(source3, target3);

            Console.WriteLine("배열복사 3");
            foreach (var item in target3)
            {
                Console.WriteLine(item);
            }

        }

        private static void CopyArray(float[] source, float[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }

        private static void CopyArray(string[] source, string[] target)
        {
            for(int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }

        private static void CopyArray(int[] source, int[] target)
        {
            for(int i= 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
    }
}
