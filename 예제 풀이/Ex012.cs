using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_____200제.예제_풀이
{
    class Ex012
    {
        public void Run()
        {
            float flt = 1f / 3;
            double dbl = 1d / 3;
            decimal dcm = 1m / 3;

            Console.WriteLine("float : {0}\ndouble : {1}\ndecimal : {2}\n",flt,dbl,dcm);
            Console.WriteLine("float : {0} bytes \ndouble : {1} bytes \ndecimal : {2} bytes \n",sizeof(float),sizeof(double),sizeof(decimal));
            Console.WriteLine("float : {0}~{1}",float.MinValue,float.MaxValue);
            Console.WriteLine("double : {0}~{1}", double.MinValue, double.MaxValue);
            Console.WriteLine("decimal : {0}~{1}", decimal.MinValue, decimal.MaxValue);
        }
    }
}
