using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = {1,1,1};
            FindLongestHarmoniousArray(numbers);
        }
           public static void FindLongestHarmoniousArray (int [] numbers)
        {
            int count = 0;
            int max = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if(numbers[i] - numbers[j] == 1 )
                    {
                        count++;
                    }
                    if(numbers[j] == numbers[i])
                    {
                        count++;
                    }
                    if(count > max)
                    {
                        max = count;
                    }

                }
                count = 0;
            }
            if(max == numbers.Length)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(max);
            }
           
        }
    }
}
