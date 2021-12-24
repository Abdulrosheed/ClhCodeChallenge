using System;
using System.Collections.Generic;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectNumbers();
        }
        static void CollectNumbers ()
        {
            
            int check =0;
           int count = 0;
            Console.WriteLine("How many numbers did you want to enter");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter your target number");
            int number = int.Parse(Console.ReadLine());

            int [] numbers = new int [size];
            for (int i = 0; i < numbers.Length ; i++)
            {
                Console.WriteLine("Enter your element");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            
          
            

            
            for(int j = 0; j < numbers.Length ; j++)
            {
               
                if(numbers[j] == number && count == 0)
                {
                    
                    
                    Console.Write(j);
                    count++;
                    
                    
                }
                if(numbers[j] == number)
                {
                    check = j;
                   if(j == numbers.Length - 1)
                   {
                        Console.WriteLine($"  , {check}");
                    }
                }
                
                
    
            }
            if(count <= 0)
            {
                Console.WriteLine("-1 , -1");
            }
          

        }
        
    }
}
