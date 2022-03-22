using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePackage
{
    internal class parenthesesBalanced
    {
        // public string inputString;
        public System.Collections.Stack st = new System.Collections.Stack();
        public bool balanceCheck(string inputString)
        {
            for (int i = 0; i < inputString.Length; i++)
                if (inputString[i].ToString() == "(") st.Push("(");
                else if (inputString[i].ToString() == "{") st.Push("{");
                else if (inputString[i].ToString() == "[") st.Push("[");
                else if (inputString[i].ToString() == ")")
                {
                    if (st.Count == 0) return false;
                    var v = st.Pop();
                    if (v.ToString() != "(") return false;
                }
                else if (inputString[i].ToString() == "]")
                {
                    if (st.Count == 0) return false;
                    var v2 = st.Pop();
                    if (v2.ToString() != "[") return false;
                }
                else if (inputString[i].ToString() == "}")
                {
                    if (st.Count == 0) return false;
                    var v3 = st.Pop();
                    if (v3.ToString() != "{") return false;
                }


            if (st.Count > 0) return false;
            return true;

        }
    }
}
