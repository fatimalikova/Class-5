using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_5.ExtentionMethods
{
    internal static class ExtentionMethods
    {
        public static bool IsOdd(this int num)
        {
            return num % 2 != 0;
        }

        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }

        public static bool IsContainsDigit(this string str)
        {
            if (string.IsNullOrEmpty(str)) return false;
            return str.Any(char.IsDigit);
        }

        public static string ToCapitalize(this string word)
        {
            if (word == null) return word;
            return char.ToUpper(word[0]) + word.Substring(1);

        }

        public static int[] GetValueIndexes(this string word, char letter)
        {
            int[] array = new int[word.Length];
            int k = 0;
            if (string.IsNullOrEmpty(word)) return ['0'];
            for (var i = 0; i < word.Length; i++)
            {
                if (word[i] == letter)
                {
                    array[k] = i;
                    k++;
                }
            }
            if (k == 0) return [];
            else Array.Resize(ref array, k);
            return array;
        }
    }
}
