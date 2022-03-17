using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_____200제.예제_풀이
{
    class Ex003
    {
        public void Run()
        {
            Console.WriteLine("Hello ");
            Console.WriteLine("World!");
            Console.Write("이름을 입력하세요");

            string name = Console.ReadLine();
            Console.WriteLine("안녕하세요, ");
            Console.WriteLine("{0} 님!",name);
        }
    }
}
