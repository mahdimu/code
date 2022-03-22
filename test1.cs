using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolution1
{
    internal class test1
    {
       public int countSquares(int N)
        {
            int count = 0;

            for (int i = 1; i < N; i++)
                if ((i * i) < N)
                {
                    count++;
                }
                else break;
            return count;
        }



        public string getDayOfWeek(int d, int m, int y)
        {
           // DateTime d = new DateTime()
            return "tursday";
        }

        public double reverse_digit(double n)
        {
            string s = n.ToString();
            s.Reverse();
            return Convert.ToDouble(s);

        }

       public bool findSumOfTwo(int[] A, int val)
        {
           // Is HashSet faster than List C#?
           //HashSet becomes faster for 10 % only if we List is without specified capacity
           //and checks each value before adding through whole list.
           //If items count reduced to 4 then List again wins even in worst scenario(with 10 % difference).
            HashSet<int> list = new HashSet<int>();
            foreach (int k in A)
            {
                int num = val - k;
                var t = list.FirstOrDefault(d => d == num);
                Console.Write("["+t+"]");
                if (t > 0) return true;
                else 
                    list.Add(k);
            }
            return false;
        }






    }
}
