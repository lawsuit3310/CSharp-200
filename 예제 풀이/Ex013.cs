using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_____200제.예제_풀이
{
    class Ex013
    {
        public void Run()
        {
            int num = int.MaxValue; //원문은 2^31-1이 적혀있었음.
            long bigNum = num; //암시적 형변환
            Console.WriteLine(bigNum);

            double x = 1234.5;
            int a;
            a = (int)x; //명시적 형변환
            Console.WriteLine(a);
        }
    }
}
