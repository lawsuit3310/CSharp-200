using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_____200제.예제_풀이
{
    class Ex005
    {
        public void Run()
        {
            string a = "hello";
            string b = "h";

            b = b + "ello";
            Console.WriteLine(a==b);
            Console.WriteLine("b = " + b);

            int x = 10;
            string c = b + '!' + " " + x;
            Console.WriteLine("c = " + c);
        }
    }
}
