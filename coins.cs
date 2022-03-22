using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePackage
{
    internal class Coins
    {
        public int[] availableCoins = { 200, 100, 50, 20, 10, 5 };



        //public subchange()

        public string change(int input)
        {
            string result = "";
            int num = input;
            int count = 0;

            foreach (int i in availableCoins)
            {

                if (i <= num)
                {
                    count++;
                    result += i + ",";
                    num = num - i;
                }
                if (num == 0) return (count + ":" + result);
                else if (num < 5) return (-1 + ":" + result);
            }
            return (-1 + ":" + result);



        }



    }
}
