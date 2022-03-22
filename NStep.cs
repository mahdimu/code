using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePackage
{
    internal class NStep
    {

      
        public int[] Set;
        public List<string> result = new List<string>();
        public NStep(int n, int[] set)
        {
            Set = set;
            stepsMaker(n, "");
        }

        private void stepsMaker(int n,string steps)
        {
                foreach (int i in Set)
                {
                    int r = n - i;
                    if (r > 0)
                        stepsMaker(r, steps + i + ",");
                    else if (r == 0) { result.Add(steps + i); }
                }
        }

        public string StepTest()
        {
            string stepResult = "";
            foreach (string s in result)
                stepResult += s + "\n";
            return stepResult;

        }

    }
}
