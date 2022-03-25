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
            int count = 0;
            int count2 = 0;
            int lastIndex = 0;
            int x = 0;
            List<string> numbers2 = new List<string>();
            for (int i = 0; i < n; i++)
            {
                x++;
                numbers2.Add(x.ToString());
            }
                    Console.WriteLine(numbers2.Count);
            Console.WriteLine($"{String.Join(',', numbers2)}");
            for (int m = 0; m < -1; m++)
            {
                count++;
                if (count == k)
                {
                    numbers2.Remove(numbers2[m]);
                    count = 1;
                    lastIndex = m + 1;
                }
                count2++;
        
                if(count < numbers2.Count)
                {
                    var o = numbers2[numbers2.Count - 1];
                    numbers2.Remove(numbers2[numbers2.Count - 1]);
                    numbers2.Insert(0,o);
                    
                Console.WriteLine($"{String.Join(',', numbers2)}");
           
                }
                if(numbers2.Count == 1)
                {
                    break;
                }
              
            }
                Console.WriteLine($"{String.Join(',', numbers2)}");
           

        }


    }
}
