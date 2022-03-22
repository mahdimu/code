using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePackage
{
    internal class repeatedElements
    {
        // delete the repeated elements
        public string deleteRepeated(string s)
        {
            string result = "";
            string[] sd = s.Split(',');
            Dictionary<string, int> list = new Dictionary<string, int>();
            foreach(string item in sd)
            {
                if(!list.ContainsKey(item))
                {
                    list.Add(item, 1);
                    result += item+',';
                }
            }
            return result;
        }
    }
}
