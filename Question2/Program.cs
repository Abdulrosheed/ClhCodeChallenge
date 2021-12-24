using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectNumbers();
        }
        static void CollectNumbers ()
        {
            Console.WriteLine("How many numbers did you want to enter");
            int size = int.Parse(Console.ReadLine());
            int [] numbers = new int [size];
            for (int i = 0; i < numbers.Length ; i++)
            {
                Console.WriteLine("Enter your element");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter your target number");
            int targetNumber = int.Parse(Console.ReadLine());
            string getNumbers = " ";
            int count = 1;
            

    

            for (int  j = 0;  j < numbers.Length;  j++)
            {
               for(int m = j+1; m < numbers.Length ; m++)
               {
                   if(targetNumber == numbers[j] + numbers[m] && count == 1)
                {
                    getNumbers += $" {j} , {m}";
                    count++; 
                }
               } 
                
                
            }
            if(count > 1)
            {
                
                Console.WriteLine(getNumbers); 
            }
            else
            {
                Console.WriteLine("No answer found");
            }
          

        }
    }
}
