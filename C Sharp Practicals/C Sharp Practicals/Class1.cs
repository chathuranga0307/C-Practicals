using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practicals
{
    class Class1
    {
        private int num1, num2, sum,mul;

        public void setval(int a, int b)
        {
            num1 = a;
            num2 = b;
        }
        public int  getsum()
        {
            sum = num1 + num2;
            return sum;

        }
        public int getmul()
        {
            mul = num1 * num2;
            return mul;
        }

    }
}
