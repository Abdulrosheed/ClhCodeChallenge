using System;
using System.Collections.Generic;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
           int [] numbers = {1,1,1,2,2,3};
           RemoveDuplicateNumbers(numbers);
            
        }
        public static void RemoveDuplicateNumbers  (int [] numbers)
        {
            int count =0;
            int count2 =0;
            string reArrange = "";
            
            for (int k = 0; k < numbers.Length; k++)
            {
                for (int m = k+1; m < numbers.Length; m++)
                {
                    
                  
                    
                    if(numbers[k] != numbers[m])
                    {
                      
                        break;
                    }
                    else if (numbers[k] == numbers[m] && m != k + 1)
                    {
                        numbers[m] = 0;
                        count2++;
                        count++; 
                        k = count;
                    }
                    
                    
                }
               
                 
                
               
            }
              if(count2 != 0)
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] != 0)
                        {
                            reArrange += $"{numbers[i]}";
                        }
                       
                    }

                        foreach (var item in reArrange)
                    {
                        Console.Write($"{item} , ");
                    }

                        
                    Console.WriteLine($" The length of the array is {reArrange.Length + 1 - count2} ");
                }
                else
                {
                    Console.WriteLine($"{String.Join(',' ,  numbers)} and the length of the array is {numbers.Length}");
                }

                
        }
    }
}
