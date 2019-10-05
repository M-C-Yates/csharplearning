using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

using System.Globalization;

namespace VS2019
{
    class Program
    {
        static void Main(string[] args)
        {
            //use var for implicit typing
            //var intval = 1;
            // in c# all types have a base type of object
            // this mean you could make an object[] array to store values of different types in a single array;
            // multi dimensional arrays are created via the following syntax
            // int[5,5]
            //ex
            //string[,] custNames = new string[2, 2] { {"bob", "smith" }, {"tom", "jerry" } };
            //for (int i = 0; i < custNames.GetLength(0); i++)
            //{
            //    for (int j = 0; j < custNames.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"{custNames[i, j]} [{i},{j}]");
            //    }
            //}

            //int[] srcArray = { 1, 2, 3 };
            //int[] destArray = new int[2];
            //int startInd = 0;
            //int length = 2;
            //Array.Copy(srcArray, startInd, destArray, startInd, length);
            //Array.ForEach(destArray, Console.WriteLine);

            // since strings are immutable in c# the only way to change a string without creating a new one
            // is by using a string builder
            StringBuilder sb = new StringBuilder("Lorem Ipsum");
            StringBuilder sb2 = new StringBuilder("More Lorem Ipsum", 256);
            Console.WriteLine($"{sb.Capacity} {sb2.Capacity}");
            Console.ReadLine();
        }
    }
}
