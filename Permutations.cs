using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePackage
{
    internal class Permutations
    {
        
            public string defString;
            public StringBuilder sb = new StringBuilder();
            // string stringPointer

            public void subPermutation(string generate, int pointer)
            {
                if (pointer == defString.Length) sb.Append(generate + " * ");

                for (int i = pointer; i < defString.Length; i++)

                {
                    subPermutation(generate + defString[i], i + 1);
                }
            }


            public Permutations(string s)
            {
                defString = s;
                subPermutation("", 0);
            }

            public void print()
            {
                Console.WriteLine(sb.ToString());
            }

        }
        
       
}
