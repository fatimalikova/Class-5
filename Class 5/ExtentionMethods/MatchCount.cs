using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_5.ExtentionMethods
{
    internal static class MatchCount
    {
        public static string Match_Count(this string sentence1, string word)
        {
            int count = 0;
            if(string.IsNullOrWhiteSpace(sentence1)) return string.Empty;
            string[] strings = sentence1.Split(' ');

            for(int i = 0; i < strings.Length; i++)
            {
                if (strings[i] == word)
                    count++;
            }
            return count.ToString();
        }

        
        public static bool Polindrome(this int number)
        {
            if (number < 0)
                return false;

            string newnum = number.ToString();
            string reversed = new string(newnum.Reverse().ToArray());

            return newnum == reversed;
        }
    }
}
