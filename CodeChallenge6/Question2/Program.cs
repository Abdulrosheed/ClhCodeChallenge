using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = {6,4,7,8,9,2,10,13};
            FindLongestIncreasingSubsequence(numbers);
        }
        public  static void FindLongestIncreasingSubsequence (int [] numbers)
        {
            
            int max = 0;
            int count = 1;
            int number = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                
                for (int k = i; k < numbers.Length - 1; k++)
                {
                   if( numbers[k] < numbers[k+1] )
                    {
                        count++;
                        
                        number = numbers[k];
                    }
                
                    else
                    {
                        continue;
                    }
                } 
                if(count > max)
                {
                    max = count;
                }
                count = 1;
            }
            Console.WriteLine(max);
        }
    }
 
}
