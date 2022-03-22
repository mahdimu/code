using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePackage
{

    class SortObj
    {
        public int Value { get; set; }
        public string Obj { get; set; }
    }


    class SortSearchArrays
    {
        public List<int> listInt = new List<int>();
        public List<string> listString = new List<string>();
        public List<SortObj> listObj = new List<SortObj>();

        //counstructor
        public SortSearchArrays()
        {

        }

        //add integer item to sorted list
        public void addInt(int a)
        {
            this.listInt.Insert(sortedIndex(this.listInt, a), a);
        }

        //add string item to sorted list
        public void addstring(string a)
        {
            this.listString.Insert(sortedIndexString(this.listString, a), a);
        }

        //add Obj item to sorted list
        public void addObj(SortObj a)
        {
            this.listObj.Insert(sortedIndexObj(this.listObj, a), a);
        }

        public int sortedIndex(int[] array, int value)
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

        public int sortedIndex(List<int> array, int value)
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

        public int sortedIndexString(List<string> array, string value)
        {
            int low = 0;
            int high = array.Count;

            while (low < high)
            {
                var mid = (low + high) >> 1;
                if (stringABCompare(array[mid], value)) low = mid + 1;
                else high = mid;
            }
            return low;
        }

        public int sortedIndexObj(List<SortObj> array, SortObj value)
        {
            int low = 0;
            int high = array.Count;

            while (low < high)
            {
                var mid = (low + high) >> 1;
                if (array[mid].Value > value.Value) low = mid + 1;
                else high = mid;
            }
            return low;
        }

        public List<int> sortedList(int[] inputArr)
        {
            List<int> SortedArray = new List<int>();
            foreach (int i in inputArr)
            {
                int p = sortedIndex(SortedArray, i);
                SortedArray.Insert(p, i);
            }
            return SortedArray;
        }

        public bool stringABCompare(string a, string b)
        {
            int min = 0;
            if (a.Length > min)
                min = a.Length;
            if (b.Length > min)
                min = b.Length;
            for (int i = 0; i < min; i++)
                if (a[i] < b[i]) return true;
            return false;
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
