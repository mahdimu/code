using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePackage
{
    class examples
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

            //foreach (char c in arr1)
            //    Console.Write(c + " ");

            //foreach (char c in arr2)
            //    Console.Write(c + " ");


            for (int i = 0; i < arr1.Count; i++)
                if (arr1[i] != arr2[i]) return "No";
            return "Yes";
        }


        public void anagram()
        {

            //int count = Convert.ToInt16(Console.ReadLine());
            //string s1 = Console.ReadLine();
            //string s2 = Console.ReadLine();
            //string s3 = Console.ReadLine();
            string[] s1 = "abcd bcda".Split(' ');
            string[] s2 = "bad daa".Split(' ');
            string[] s3 = "a1b2c3 abc123".Split(' ');
            Console.WriteLine(subAnagram(s1));
            Console.WriteLine(subAnagram(s2));
            Console.WriteLine(subAnagram(s3));
        }

    }
}
