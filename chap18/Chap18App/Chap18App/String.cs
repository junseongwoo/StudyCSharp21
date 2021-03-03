using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap18App
{
    class String
    {
        static void Main(string[] args)
        {
            Console.WriteLine("문자열 연습 시작");

            /*// 기본 선언
            string message1 = null;
            Console.WriteLine($"null 문자열 : {message1}");

            string message2 = string.Empty;
            Console.WriteLine($"empty 문자열 : {message2}");

            string oldPath = "C:\\Program Files\\Bandizip"; //폴더, 파일 경로
            string newPath = @"C:\Program Files\Bandizip";

            string greeting = "Hello Wolrd";
            var temp1 = "Local Variable String";

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string hello = new string(letters);
            Console.WriteLine($"{hello}");

            string s1 = "Hello";
            string s2 = "Wolrd";
            s1 += s2;
            Console.WriteLine($"{s1}");
            Console.WriteLine("------");

            string row = "Row1\r\nRow2\r\nRow3";
            Console.WriteLine(row);

            Console.WriteLine("------");
            string row2 = "Row1\nRow2\nRow3";
            Console.WriteLine(row2);

            Console.WriteLine("------");
            Console.WriteLine();
            Console.Write($"R1{Environment.NewLine}R2{Environment.NewLine}R3{Environment.NewLine}");

            Console.WriteLine("------");
            string oldline = "Test " +
                "Test2 " +
                "Test3 ";
            string multiline = @"New Test
These are multiline
end";

            Console.WriteLine(oldline);
            Console.WriteLine("------");
            Console.WriteLine(multiline);

            var book = (lastname: "박", firstName: "상현", title: "이것이 C#이다.", company: " 한빛미디어",
                releaseDate : "2018-07-01", price : 30000, page: 812);

            Console.WriteLine($"{book.lastname}{book.firstName} 저자의 {book.title} ({book.company})");
            Console.WriteLine($"{DateTime.Parse(book.releaseDate).ToString("yyyy년 MM월 dd일")} 출간,");
            Console.WriteLine($"페이지수 {book.page}p, 금액 : {book.price:#,###}원");*/

            Console.WriteLine("문자열 조작(함수사용)");
            string s5 = "      Visual C# Express";

            Console.WriteLine(s5);
            Console.WriteLine(s5.Trim()); //여백 삭제
            var s6 = s5.Trim();

            Console.WriteLine(s6.Substring(7));
            Console.WriteLine(s6.Substring(7,2));

            Console.WriteLine(s6.Replace("C#","Basic"));
            Console.WriteLine(s6.Replace(s6.Substring(7,2),"Basic"));

            Console.WriteLine(s6.IndexOf("C"));
            Console.WriteLine(s6.Length);
            Console.WriteLine(s6.ToLower());
            Console.WriteLine(s6.ToUpper());

            // null 문자열 빈문자열
            Console.WriteLine("null/빈문자열 처리");

            string str = "hello";
            string nullstr = null;
            string emptystr = string.Empty;

            Console.WriteLine(str + nullstr);
            Console.WriteLine(nullstr == emptystr);

            try
            {
                Console.WriteLine(nullstr.Equals(emptystr));
            }
            catch (Exception ex)
            {

                Console.WriteLine($"예외 발생 : {ex.Message}");
            }

            Console.WriteLine(emptystr.Length);
            //Console.WriteLine(nullstr.Length); // null 문자열은 길이가 없다
        }
    }
}
