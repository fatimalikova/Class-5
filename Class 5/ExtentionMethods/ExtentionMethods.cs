using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

        public static string GetFirstSentence(this string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
                return string.Empty;

            string[] parts = sentence.Split('.');

            if (parts.Length > 0)
                return parts[0].Trim();

            return string.Empty;
        }

        

        public static string GetSecondWord(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            string[] words = text.Split(' ');

            if (words.Length < 2)
                return string.Empty;

            return words[1].Trim();
        }

    }
}
