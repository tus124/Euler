﻿using System.Collections.Generic;
using System.Text;

namespace LargeNumbers
{
    public static class HelperExtension
    {
        public static int[] ToIntArray(this string str)
        {
            var r = new int[str.Length];

            var charArr = str.ToCharArray();
            for (int i = 0; i < charArr.Length; i++)
            {
                r[i] = int.Parse(charArr[i].ToString());
            }

            return r;
        }

        public static List<int> ReverseList(this List<int> list)
        {
            var results = new List<int>();

            for (int i = list.Count - 1; i >= 0; i--)
            {
                results.Add(list[i]);
            }

            return results;
        }

        public static string GetString(this int[] arr)
        {
            StringBuilder sb = new StringBuilder();
            for (var i = 0; i < arr.Length; i++)
            {
                sb.Append(arr[i]);
            }
            return sb.ToString();
        }

        public static string GetString(this List<int> list, string delimiter = "")
        {
            return string.Join(delimiter, list.ToArray());
        }

        public static void Swap(ref string s, ref string r)
        {
            string temp = s;
            s = r;
            r = temp;
        }
    }
}