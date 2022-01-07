using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your word");
            string word = Console.ReadLine();
            string reset = "";
            string reset2 = "";
            int min = 0;
            int count = 0;
            for(int i = 0; i < word.Length; i++)
            {
                
                for(int j =i; j < word.Length; j++)
                {
                    
                    reset += word[j];
                    for(int k = 0; k < reset.Length; k++)
                    {
                        if (reset[k] == reset[reset.Length - k -1])
                        {
                            count++;
                        }
                        
                    }
                    if (count  == reset.Length && count > min)
                    {
                        reset2 = reset;
                    
                        min = count;
                    }
                    count = 0;
                 
                
                }
                   reset = "";
            }
            Console.WriteLine(reset2);
        

            
        }
    }
}
