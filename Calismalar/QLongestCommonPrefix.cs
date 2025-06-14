using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonPrefix
{
    internal class QLongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            string eleman1 = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (!(strs[i].StartsWith(eleman1)))
                {
                    eleman1 = eleman1.Substring(0, eleman1.Length - 1);

                    if (eleman1 == "")
                        return "";
                }
            }

            return eleman1;
        }

        public string BaskaCozum(string[] strs)
        {
            string prefix = "";
            int minL = int.MaxValue;
            foreach (string s in strs) //burdak strs dizisindeki en küçük length'e sahip eleman bulunuyor
            {
                if (s.Length < minL)
                {
                    minL = s.Length;
                    prefix = s;
                }
            }

            for (int i = 0; i < strs.Length; i++) //eleman indexleri belirleniyor
            {
                while (prefix.Length > 0) 
                {
                    if (strs[i].Substring(0, prefix.Length).Contains(prefix)) //kontrol edilen eleman'ın 0.index ile prefix'in uzunluğu kadar olan kısmı Contains ile kontrol ediliyor. True ise bir sonraki elaman aynı prefix ile tekrar kontrol edilecek değilse prefix'den -1 length küçültülüp kontrole devam edilecek
                    {
                        break;
                    }
                    prefix = prefix.Substring(0, prefix.Length - 1);
                }
            }
            return prefix;
        }
    }
}
