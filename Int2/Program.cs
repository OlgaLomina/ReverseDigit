using System;
/*Given a 32-bit signed integer, reverse digits of an integer.

Example 1:

Input: 123
Output: 321
Example 2:

Input: -123
Output: -321
Example 3:

Input: 120
Output: 21
Note:
Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. 
For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.
 * */
namespace Int2
{
    //MinValue = -2147483648
    //MaxValue = 2147483647
    class Program
    {
        static int Reverse(int x)
        {
            int res = x, rem = 0, temp = 0;
            while (res != 0)
            {
                rem = res % 10;
                res = res / 10;
                if (temp > Int32.MaxValue / 10 || (temp == Int32.MaxValue / 10 && rem > 7)) return 0;
                if (temp < Int32.MinValue / 10 || (temp == Int32.MinValue / 10 && rem < -8)) return 0;
                temp = temp * 10 + rem;
            }
            return temp;
        }

        static void Main(string[] args)
        {
            int num = 1534236469;
            int number = Reverse(num);
        }
    }
}
