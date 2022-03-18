﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_____200제.예제_풀이
{
    class Ex015
    {
        public void Run()
        {
            int x, y;

            Console.WriteLine("첫 번째 숫자를 입력하세요 : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("두 번째 숫자를 입력하세요 : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}",x,y,x+y);

            short value = short.MaxValue; // ==Int16.MaxValue
            Console.WriteLine("\n2진수, 8진수, 10진수, 16진수로 출력하기");

            int baseNum = 2;
            string s = Convert.ToString(value,baseNum);
            int i = Convert.ToInt32(s,baseNum);
            Console.WriteLine("i = {0}, {1,2}진수= {2,16}",i, baseNum, s);
            
            baseNum = 8;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2}진수= {2,16}", i, baseNum, s);

            baseNum = 10;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2}진수= {2,16}", i, baseNum, s);

            baseNum = 16;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2}진수= {2,16}", i, baseNum, s);
        }
    }
}
