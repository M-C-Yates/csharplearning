using System;
using System.Numerics;

namespace vid1
{
  class Program
  {
    static void Main(string[] args)
    {

      //   Console.WriteLine("Hello World!");
      //   for (int i = 1; i < args.Length; i++)
      //   {
      //     Console.WriteLine($"{args[i]}");
      //   }
      //   //   string[] myArgs = Environment.GetCommandLineArgs();

      //   //   Console.WriteLine(string.Join(", ", myArgs));
      //   //   Console.ReadLine();
      //   SayHello();

      // private static void SayHello()
      // {
      //   string name = "";
      //   Console.Write("What is your name: ");
      //   name = Console.ReadLine();
      //   Console.WriteLine($"Hello, {name}!");
      // }

      // the most basic c# datatype are booleans
      bool isTrue = true;
      Console.WriteLine($"{isTrue}");

      /*
      c# has several built in primitive types, these are also known as built in types
        the next most common are int types
        ex int represents 32bit signed integers
        Int Types table
        Name    | val | Minimum Val          | Max Val              | Size  
        sbyte   | 0   | -128                 | 127                  | 1byte
        byte    | 0   | 0                    | 255                  | 1byte
        short   | 0   | -32768               | 32767                | 2bytes
        ushort  | 0   | 0                    | 65535                | 2bytes
        int     | 0   | -2147483648          | -2147483647          | 4bytes
        uint    | 0u  | 0                    | 4294967295           | 4bytes
        long    | 0L  | -9223372036854775808 | 9223372036854775807  | 8bytes
        ulong   | 0u  | 0                    | 18446744073709551615 | 8bytes

        then floating point numbers
        Name    | def val | Minimum Val    | Max Val       | Size    | precision
        float   | 0.0f    | ±1.5×10 -45    | ±3.4×10 38    | 4bytes  | 7 digits
        double  | 0.0d    | +-5.0 x 10-324 | +-1.7 x 10308 | 8 bytes | 15-16 digits
        decimal | 0.0m    | +-1.0 x 10-28  | +-7.9 x 1028  | 16bytes | 28-29 decimal places

        then booleans
        bool | false | true || false | 4 bytes for interop but only 1 byte internally

        string & char
        char   | '\u0000' | 'u0000' | 'uffff' | 2byte
        string | null     | -       | -       | min 8 bytes + 2bytes for ever character in the string

        last is the object type
       */
      //   Console.WriteLine($"smallest int: {int.MaxValue}");
      //   Console.WriteLine($"biggest int: {int.MinValue}");
      //   Console.WriteLine($"biggest byte: {byte.MaxValue}");
      //   Console.WriteLine($"smallest byte: {byte.MinValue}");
      //   decimal decPiVal = 3.14159265358979m;
      //   decimal bigVal = 3.00000000000000000001m;
      //   Console.WriteLine($"decimal accuracy: {decPiVal + bigVal}");
      //   bool boolFromString = bool.Parse("true");
      //   double.Parse("1.234");
      //  int.Parse("100");
      //   Console.WriteLine($"{boolFromString}");

      //   Dates/times
      /*
          DateTime awesomeDate = new DateTime(1996, 07, 20);
          Console.WriteLine($"Day of week {awesomeDate.DayOfWeek}.)
          awesomeDate = awesomeDate.AddDays(4);
          awesomeDate = awesomeDate.AddMonths(1);
          awesomeDate = awesomeDate.AddYears(2);
          Console.WriteLine($"New Date {awesomeDate.Date}")

          TimeSpan lunchTime = new TimeSpan(12, 30, 0);
          lunchTime = lunchTime.Subtract( new TimeSpan(0, 15, 0));
          lunchTime = lunchTime.Add( new TimeSpan(1, 0, 0));
          Console.WriteLine(${lunchtime.ToString()})

       */
      var rand = new Random();
      int num = rand.Next(0, 32);
      Console.WriteLine($"{num}");
    }
  }
}
