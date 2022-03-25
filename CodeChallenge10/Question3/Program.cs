using System;
using System.Collections.Generic;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            checkFriend(2, 5);
        }
        static void checkFriend(int k, int n)
        {
           var mod = n%k;
           Console.WriteLine(mod + k);
        }


    }
}
