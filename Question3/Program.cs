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
            int count = 0;
            int count2 = 0;
            int min = 0;
            foreach(var item in word)
            {
                count++;
                for(int k = 0; k < count ; k++)
                {
                    reset += item;
                    if(count > 1)
                    {
                    
                        for(int i = 0; i < reset.Length; i++)
                        {
                            if(reset[i] == reset[reset.Length - i - 1])
                            {
                                
                                count2++;
                            }
                        }
                        foreach(var character in reset )
                        {
                            if(count2 == reset.Length)
                            {
                                reset2 += character; 
                            }
                          
                        }
                            
                        for (int j = 1; j > 0 ; j++ )
                        {
                            if(j == 1)
                            {
                                min = count2;
                            }
                            if(j > 1 && count2 <= min )
                            {
                                Console.WriteLine(reset2);
                                break;
                            }
                            
                        }
                }
                }
                
            }
            
        }
    }
}
