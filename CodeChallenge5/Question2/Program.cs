using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
           int [] numbers = {10,5,-3,3,2,0,11,3,-2,0,1}; 
            PrintNumberOfPath(numbers,8);
        }
        static void PrintNumberOfPath (int [] numbers , int targetNumber)
        {
            int count = 0;
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum+=numbers[i];
               
                
                for (int m = i + 1 ; m < numbers.Length; m++)
                {
                    sum+=numbers[m];
                    if (sum == targetNumber)
                    {
                        count++;
                        
                    }
                    else if(sum > targetNumber)
                    {
                        sum = numbers[i];
                    }
                }
                sum = 0;
            }
            Console.WriteLine(count);
        }
    }
}
