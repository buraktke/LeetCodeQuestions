using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    internal class QPalindromeNumber
    {
        public bool PalindromeNumber(int x) {

           string d = x.ToString();
            string result = "";
            for (int i = d.Length-1; i >= 0; i--)            
                 result += d[i];         

            if(x.ToString()==result)           
                return true;
            
            return false;
        }
    }
}
