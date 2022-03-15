using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePackage
{
    class anagram
    {
        public string sortInt(int[] A)
        {
            StringBuilder result = new StringBuilder();
            List<int> items = new List<int>();
            foreach (int i in A)
                items.Add(i);
            items.Sort();
            foreach (int j in items)
                result.Append(j + "  ");

            return result.ToString();
        }

        public string subAnagram(string[] s)
        {
            List<char> arr1 = s[0].ToList<char>();
            List<char> arr2 = s[1].ToList<char>();
            arr1.Sort();
            arr2.Sort();

            for (int i = 0; i < arr1.Count; i++)
                if (arr1[i] != arr2[i]) return "No";
            return "Yes";
        }

        public string test()
        {
            string result = "";
            string[] s1 = "abcd bcda".Split(' ');
            string[] s2 = "bad daa".Split(' ');
            string[] s3 = "a1b2c3 abc123".Split(' ');
            result += (subAnagram(s1));
            result += (subAnagram(s2));
            result += (subAnagram(s3));
            return result;
        }
    }
}
