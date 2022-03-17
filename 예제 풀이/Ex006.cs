using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_____200제.예제_풀이
{
    class Ex006
    {
        public void Run()
        {
            int i;
            double x;

            i = 5;
            x = 3.141592;
            Console.WriteLine("i = {0}, x= {1}",i,x);

            x = i;
            i = (int)x; // double -> int는 명시적 형변환을 해주어야 하며, 만야갸 string -> int 일 경우엔 int.parse() 를 사용함.
            Console.WriteLine("i = {0}, x= {1}", i, x);
        }
    }
}
