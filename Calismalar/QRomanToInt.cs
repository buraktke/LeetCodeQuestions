using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInt
{
    internal class QRomanToInt
    {
        public int RomanToInt(string s)
        {
            /*
I             1
V             5
X             10
L             50
C             100
D             500
M             1000           
             */

            //char[] symbols = new char[] { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            //int[] numbers = new int[] { 1, 5, 10, 50, 100, 500, 1000 };

            Dictionary<char, int> roman = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && roman[s[i]] < roman[s[i + 1]])
                {
                    result -= roman[s[i]];
                }
                else
                {
                    result += roman[s[i]];
                }
            }

            return result;

        }
    }
}
