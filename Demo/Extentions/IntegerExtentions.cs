using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Integer_Extentions
{
    internal static class IntegerExtentions
    {
        public static int Reverse(this int num)
        { 
                int Rev = 0;
                int remender;
                while (num != 0) {
                    remender= num%10;
                    Rev =  Rev * 10 + remender ;
                    num = num / 10;
                }
                return Rev;
        }
    }
}
