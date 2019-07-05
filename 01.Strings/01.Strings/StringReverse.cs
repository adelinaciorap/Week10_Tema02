using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Strings
{
    public class StringReverse
    {
        public string reverseOnlyLetters(string S)
        {
            char[] str = S.ToCharArray();
            int i = 0, j = str.Length - 1;
            while (i < j)
            {
                while (i < j && !char.IsLetter(str[i])) i++;
                while (i < j && !char.IsLetter(str[j])) j--;
                swap(str, i++, j--);
            }
            StringBuilder sb = new StringBuilder();
            sb.Append(str);
            return sb.ToString();
        }
        private void swap(char[] str, int i, int j)
        {
            char temp = str[i];
            str[i] = str[j];
            str[j] = temp;
        }
    }
}
