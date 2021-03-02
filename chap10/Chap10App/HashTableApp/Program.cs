using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableApp
{
    class Program  
    {
        static void Main(string[] args)
        {
            Console.WriteLine("해쉬테이블 예제");   // 파이썬의 딕셔너리와 동일

            Hashtable ht = new Hashtable();
            ht["일"] = "One";
            ht["이"] = "Two";
            ht["삼"] = "Three";
            ht["사"] = "Four";

            foreach (var item in ht)
            {
                Console.WriteLine(item);
            }

        }
    }
}
