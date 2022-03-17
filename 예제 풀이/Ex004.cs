using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_____200제.예제_풀이
{
    class Ex004
    {
        public void Run()
        {
            string name = string.Empty;
            uint age = 0;
            double height = 0;
            
            Console.WriteLine("이름을 입력하세요 : ");
            name = Console.ReadLine();
            
            Console.WriteLine("나이를 입력하세요 : ");
            try { age =  uint.Parse(Console.ReadLine()); }
            catch (Exception e) { Console.WriteLine(e.Message); return; }

            Console.WriteLine("키를 입력하세요 (cm) : ");
            try { height = double.Parse(Console.ReadLine()); }
            catch (Exception e) { Console.WriteLine(e.Message); return; }

            Console.WriteLine("안녕하세요, {0}님!",name);
            Console.WriteLine("나이는 {0}세, 키는 {1}cm 이군요!",age,height);


        }
    }
}
