using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePackage
{
    internal class Class1
    {
        public static bool valid(char c)
        {
            if ((c >= '0') && (c <= '9') || (c >= 'a') && (c <= 'f') || (c >= 'A') && (c <= 'F'))
                return true;
            return false;
            //   if((str[1]>='0')&&(str[1]<='9') || (str[1] >= 'a') && (str[1] <= 'f') || (str[1] >= 'A') && (str[1] <= 'F'))
        }

        public static bool IsValidHexCode(string str)
        {
            if (str.Length > 7) return false;
            if (str[0] == '#')
                if (valid(str[1]))
                    if (valid(str[2]))
                        if (valid(str[3]))
                            if (valid(str[4]))
                                if (valid(str[5]))
                                    if (valid(str[6]))
                                        return true;
            return false;
        }


        public static int commonDenominator(int a, int b)
        {
            if (a < b)
            {
                for (int i = a; i > 1; i--)
                    if (((a % i) == 0) && ((b % i) == 0)) return i;
            }
            else
            {
                for (int j = b; j > 1; j--)
                    if (((a % j) == 0) && ((b % j) == 0)) return j;
            }
            return 1;
        }

        public static string Simplify(string str)
        {
            string[] sd = str.Split('/');
            int a = Int32.Parse(sd[0]);
            int b = Int32.Parse(sd[1]);
            if (a == b) return "1";
            if ((a % b) == 0) return (a / b).ToString();
            if ((b % a) == 0) return "1/" + (b / a).ToString();
            int de = commonDenominator(a, b);
            return ((a / de).ToString() + "/" + (b / de).ToString());
        }





        public static bool CheckEquality(object a, object b)
        {
            if (a.GetType() == b.GetType())
                if (a.Equals(b)) return true;
            return false;
        }



        //In Nico Cipher, encoding is done by creating a numeric key and assigning
        //each letter position of the message with the provided key.


        public static string NicoCipher(string message, string key)
        {

            int ColCount = key.Length;
            int messageLen = message.Length;
            int RowCount = messageLen / ColCount;
            if ((messageLen % ColCount) != 0) RowCount++;
            string result = "";

            char[,] arr = new char[RowCount, ColCount];
            char[,] arrConverted = new char[RowCount, ColCount];
            for (int a1 = 0; a1 < RowCount; a1++)
                for (int a2 = 0; a2 < ColCount; a2++)
                    arr[a1, a2] = ' ';

            int k = 0;

            for (int row = 0; row < RowCount; row++)
                for (int col = 0; col < ColCount; col++)
                {
                    if (k < message.Length)
                        arr[row, col] = message[k];
                    k++;
                }

            int convertedArrPointer = 0;

            for (char n = '0'; n <= '9'; n++)
                for (int m = 0; m < ColCount; m++)
                    if (key[m] == n)
                    {
                        for (int t = 0; t < RowCount; t++)
                            arrConverted[t, convertedArrPointer] += arr[t, m];
                        convertedArrPointer++;
                    }

            for (char n = 'a'; n <= 'z'; n++)
                for (int m = 0; m < ColCount; m++)
                    if (key[m] == n)
                    {
                        for (int t = 0; t < RowCount; t++)
                            arrConverted[t, convertedArrPointer] += arr[t, m];
                        convertedArrPointer++;
                    }
            for (char n = 'A'; n <= 'Z'; n++)
                for (int m = 0; m < ColCount; m++)
                    if (key[m] == n)
                    {
                        for (int t = 0; t < RowCount; t++)
                            arrConverted[t, convertedArrPointer] += arr[t, m];
                        convertedArrPointer++;
                    }

    

            for (int c1 = 0; c1 < RowCount; c1++)
                for (int c2 = 0; c2 < ColCount; c2++)
                    result += arrConverted[c1, c2];

                    return result;
        }







    }
}
