using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays's disadvantage is you cannot move out of the array's area. For example you can't add fourth element to an array which has three elements ideally.
            // C# solves this problem by using collections. 

            List<string> names1 = new List<string> {"Mustafa", "Enes", "Sadık", "Taylan"};
            Console.WriteLine(names1[0]);
            Console.WriteLine(names1[1]);
            Console.WriteLine(names1[2]);
            Console.WriteLine(names1[3]);
            names1.Add("Arda");
            Console.WriteLine(names1[4]);
            Console.WriteLine(names1[0]);
        }
    }
}
