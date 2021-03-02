using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 80, 74, 81, 90, 34 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            Console.WriteLine("크기 변경");
            Array.Resize(ref array, 6);

            Console.WriteLine("81 인덱스 찾기");
            int idx = Array.IndexOf(array, 81);
            for (int i = array.Length - 1; i >=idx; i--)
            {
                array[i] = array[i - 1];
                
            }
            array[idx] = 50;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            /*Console.WriteLine($"Type of array : {array.GetType()}");
            Console.WriteLine($"Type of array : {array.GetType().BaseType}");


            Console.WriteLine("정렬 후 ");
            Array.Sort(array);  // 반대는 Reverse
            Console.WriteLine("for");
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }
            *//*Console.WriteLine("foreach");
            var idx = 0;
            foreach (var item in array)
            {
                Console.WriteLine($"{idx++}번째 값 : {item}");
            }*//*
            Console.WriteLine("위치 찾기 ");
            int idx = Array.IndexOf(array, 34);
            Console.WriteLine($"34의 인덱스 : {idx}");

            Console.WriteLine("배열 삭제 ");
            Array.Clear(array, 3, 2);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }*/
        }

            
    }
}
