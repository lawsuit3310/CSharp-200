using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_____200제.예제_풀이
{
    class Ex007
    {
        public void Run()
        {
            bool b = true;
            char c = 'A'; //char 형은 작은 따옴표, string 형은 큰 따옴표
            decimal d = 1.234m; //m은 decimal 형에 붙이는 접미사
            double e = 1.23456789;
            float f = 1.23456789f; //f는 float 형에 붙이는 접미사
            int i = 1234;
            string s = "Hello";

            Console.WriteLine(b);
            Console.Write(c); //Console.Write는 줄 바꿈 없이, Console.WriteLine 내용이 끝날 때마다 줄 바꿈
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(i);
            Console.WriteLine(s);
        }
    }
}
