using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintProfile("성명건", "010-6683-7732");

            if (PrintProfile(null, "010-1111-2222") == -1)
            {
                Console.WriteLine("프로필 출력시 오류가 발생했습니다.");
            }

            /*PrintProfile(phone: "010-1234-1234", name: "홍길동");
            PrintProfile(phone: "010-1234-1234", name: "홍길동");*/

            PrintProfile("우준성");
        }

        public static int PrintProfile(string name, string phone = "입력 하지 않음") // defult 파라미터는 무조건 뒤에서 부터 넣어야한다.
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("이름을 정확히 입력하세요.");
                return -1;
            }

            // 프로필 출력
            Console.WriteLine($"이름 : {name}, 폰번호 : {phone}");
            return 0;
        }
    }
}
