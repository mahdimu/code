using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePackage
{
    class SortSearchArrays
    {
        private int sortedIndex(int[] array, int value)
        {
            int low = 0;
            int high = array.Length;

            while (low < high)
            {
                var mid = (low + high) >> 1;
                if (array[mid] < value) low = mid + 1;
                else high = mid;
            }
            return low;
        }

        private int sortedIndex(List<int> array, int value)
        {
            int low = 0;
            int high = array.Count;

            while (low < high)
            {
                var mid = (low + high) >> 1;
                if (array[mid] < value) low = mid + 1;
                else high = mid;
            }
            return low;
        }


        public List<int> sortedList(int[] inputArr)
        {
            List<int> SortedArray = new List<int>();
            foreach(int i in inputArr)
            {
                int p = sortedIndex(SortedArray, i);
                SortedArray.Insert(p, i);
            }
            return SortedArray;
        }


        public int[] sortedListInt(int[] inputArr)
        {
            return sortedList(inputArr).ToArray();
        }


        public string test()
        {
            string result = "";
            int[] v = sortedListInt(new int[] { 5, 7, 1, 4, 1, 8, 9, 12, 2, 6, 12, 1, 8, 9, 4, 5, 7, 8 });
            foreach (int i in v)
            {
                result += "[" + i + "] ";
            }
            return result;
        }

    }
}
