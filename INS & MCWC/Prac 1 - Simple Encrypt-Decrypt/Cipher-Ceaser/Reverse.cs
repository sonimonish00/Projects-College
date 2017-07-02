using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher_Ceaser
{
    public class Reverse
    {
        public int rev(int num)
        {

            int  rem, sum = 0, rev;
            while (Convert.ToBoolean(num))
            {
                rem = num % 10;  //for getting remainder by dividing with 10
                num = num / 10; //for getting quotient by dividing with 10
                sum = sum * 10 + rem;
            }
            rev = sum;
            return rev;
        }
    }
}
