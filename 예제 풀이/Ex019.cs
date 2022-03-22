using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_____200제.예제_풀이
{
    class Ex019
    {
        public void Run()
        {
            Console.WriteLine("int.MaxValue = {0}",int.MaxValue);
            int x = int.MaxValue, y = 0;
            checked
            {
                try
                {
                    y = x+ 10;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("int.MaxValue + 10 = {0}",y);
        }
    }
}
