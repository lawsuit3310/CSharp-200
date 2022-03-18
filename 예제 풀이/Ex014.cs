using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_____200제.예제_풀이
{
    class Ex014
    {
        public void Run()
        {
            string input;
            int value;

            Console.WriteLine("1. int형으로 변환할 문자열을 입력하세요");
            input = Console.ReadLine();

            try
            {
                value = int.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            Console.WriteLine("int '{0}'으로 변환 되었습니다.",value);

            double result;
            Console.WriteLine("2. double형으로 변환할 문자열을 입력하세요");
            input = Console.ReadLine();

            try
            {
                result = double.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            Console.WriteLine("double '{0}'으로 변환 되었습니다.", result);
        }
    }
}
