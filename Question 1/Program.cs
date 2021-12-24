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
            List <int> numbers1 = new List<int>();
           
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
               
                if(numbers[j] == number )
                {
                    
                    
                    numbers1.Add(j);
                    count++;
                    
                    
                }
            
                
                
    
            }
            if(count > 0)
            {
                Console.Write($"{numbers1[0]} , {numbers1[Math.Abs(numbers1.Count - 1) ]} ");
            }
                
   
                
            if(count <= 0)
            {
                Console.WriteLine("-1 , -1");
            }
          

        }
        
    }
}
