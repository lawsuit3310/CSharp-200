using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_____200제.예제_풀이
{
    class Ex011
    {
        public void Run()
        {
            Console.WriteLine("{0:N2}",1234.5678); //소수 둘째 자리까지만 출력
            Console.WriteLine("{0:D8}",1234); //총 8자리 출력하되, 남는 부분은 0으로 출력
            Console.WriteLine("{0:F3}",1234.56); //소수 셋째 자리까지만 출력 단, 빈자리는 0으로 출력
            Console.WriteLine("{0,8}",1234); //총 8자리 출력하되, 빈자리는 출력 하지 않고 비워둠
            Console.WriteLine("{0,-8}",1234); //왼쪽 정렬하여 총 8자리 출력, 빈자리는 출력 안하고 비워둠

            string s;
            s = string.Format("{0:N2}", 1234.5678);
            Console.WriteLine(s);
            s = string.Format("{0:D8}", 1234);
            Console.WriteLine(s);
            s = string.Format("{0:F3}",1234.56);
            Console.WriteLine(s);

            Console.WriteLine(1234.5678.ToString("N2"));
            Console.WriteLine(1234.ToString("D8"));
            Console.WriteLine(1234.56.ToString("F3"));

            Console.WriteLine("{0:#.##}",1234.5678);
            Console.WriteLine("{0:0,0.00}",1234.5678); // 천 단위로 구분 점 찍힘
            Console.WriteLine("{0:#,#.##}",1234.5678);
            Console.WriteLine("{0:000000.00}",1234.5678);

            Console.WriteLine("{0:#,#:##;(#,#.##);zero}",1234.567);
            Console.WriteLine("{0:#,#:##;(#,#.##);zero}",-1234.567);
            Console.WriteLine("{0:#,#:##;(#,#.##);zero}",0);

        }
    }
}
