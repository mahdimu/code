using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Consoletest;

namespace CodePackage
{


    //public class SolutionIter : IEnumerable<int>


    public class SolutionIter : IEnumerable<int>
    {
        public List<int> sb = new List<int>();
        public int count = 0;

        public SolutionIter(Stream stream)
        {
            var memoryStream = new MemoryStream();
            stream.CopyTo(memoryStream);
            byte[] byteResult = memoryStream.ToArray();
            string res = System.Text.Encoding.ASCII.GetString(byteResult);
            string[] res2 = res.Split('\n');
            //    List<int> sb = new List<int>();
            foreach (string s in res2)
            {
                int a = 0;
                try
                {
                    a = Convert.ToInt16(s);
                    sb.Add(a);
                    count++;
                }
                catch
                {

                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            if (sb != null)
            {
                yield return sb;
            }

        }

        
        IEnumerator<int>  IEnumerable<int>.GetEnumerator()
        {
                yield return count;
        }



        public IEnumerable GetEnumerable()
        {
            if (sb != null)
            {
                yield return sb;
            }
        }
    }



        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return GetEnumerator();
        //}



    

    //public IEnumerable<int> SolutionIter(Stream stream)
    //{
    //    var memoryStream = new MemoryStream();
    //    stream.CopyTo(memoryStream);
    //    byte[] byteResult = memoryStream.ToArray();
    //    string res = System.Text.Encoding.ASCII.GetString(byteResult);
    //    string[] res2 = res.Split('\n');
    //    List<int> sb = new List<int>();
    //    foreach (string s in res2)
    //    {
    //        int a = 0;
    //        try
    //        {
    //            a = Convert.ToInt16(s);
    //            sb.Add(a);
    //        }
    //        catch
    //        {

    //        }
    //    }
    //    IEnumerable<int> result = sb;
    //    yield return sb;
    //}
}


    public class test
    {

    public void testNow()
    {

        string path = @"e:\\test.txt";

        //using (StreamReader sr = File.OpenText(path))
        //{

        //}

        byte[] fileContent = Encoding.ASCII.GetBytes(File.ReadAllText(path));
        Console.WriteLine(fileContent.Length);
        MemoryStream stream = new MemoryStream(fileContent);


        IEnumerable<int> it = new SolutionIter(stream);

        
        foreach (int t in it)
            Console.WriteLine(t);
        // int[] arr = it.ToArray();

    }

}
    


    /**
 * Example usage:
 *
 * IEnumerable<int> it = new SolutionIter(stream);
 * int[] arr = it.ToArray();
 */


