using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePackage
{
    class Permutations
    {
        public string defString;
        public StringBuilder sb = new StringBuilder();
        public void subPermutation(string generate, int pointer)
        {
            if (pointer == defString.Length) sb.Append(generate + " * ");
            for (int i = pointer; i < defString.Length; i++)
            {
                subPermutation(generate + defString[i], i + 1);
            }
        }


        public Permutations()
        {
            string s = "ABC";
            defString = s;
            subPermutation("", 0);
        }

        public string test()
        {
            return sb.ToString();
        }

    }
}
