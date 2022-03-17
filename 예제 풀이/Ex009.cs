using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_____200제.예제_풀이
{
    class Ex009
    {
        public void Run()
        {
            int v1 = 100;
            double v2 = 1.234;

            //Console.WriteLine(v1,v2);  에러 발생 (int -> string 캐스팅 과정에서)
            Console.WriteLine(v1.ToString(),v2.ToString()); //,ToString으로 명시적 형변환
            Console.WriteLine("v1 = " + v1 + ", v2 = " + v2);
            Console.WriteLine("v1 = {0}, v2 = {1}",v1,v2);
            Console.WriteLine($"v1 = {v1}, v2 = {v2}"); //형식 문자열 앞에 $를 쓰면 {}의 안에 직접 변수명을 쓸 수 있음.
        }
    }
}
