using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_____200제.예제_풀이
{
    class Ex010
    {
        public void Run()
        {
            Console.Clear(); // 콘솔창에 출력 되어있던 내용 초기화
            Console.WriteLine("Standard Numeric Format Specifiers");

            Console.WriteLine(
                "(C) Currency : {0,20:C}\n"+ //통화 형식 지정자로 출력, 만약 형식 지정을 (C3) 으로 했을 경우 소수점 아래 3번째 자리까지만 출력 
                "(D) Decimal : {0:D}\n"+ //십진수 형식 지정자로 출력
                "(E) Scientific : {1:E}\n"+ //지수 형식 지정자로 출력
                "(F) Fixed point : {1:F}\n"+ //고정 자리수 형식 지정자로 출력
                "(G) General : {0:G}\n"+ //일반 형식 지정자로 출력
                "(N) Number : {0:N}\n"+ //천단위로 구분 기호를 넣는 형식 지정자로 출력
                "(P) Percent : {1:P}\n" + // 퍼센트 형식 지정자로 출력
                "(R) Round-trip : {1:R}\n"+ //라운드 트립 형식 지정자로 출력하나 무시됨.
                "(X) Hexadecimal {0:X}\n",-12345678,1234.5678f //16진수 형식 지정자로 출력

                //형식지정자 앞의 숫자 + 콜론은, 앞의 숫자 만큼 칸을 차지하며, 차지하였으나 사용되지 않는 부분은 빈칸으로 출력됨.
                );
        }
    }
}
