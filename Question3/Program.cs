using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your word");
            string word = Console.ReadLine();
            string reset = " ";
            string reset2 = " ";
            int count = 0;
            int min = 0;
            for(int i = 0; i < word.Length ; i++)
            {
                reset += word[i];
                for(int j = i +1 ; j < word.Length ; j++)
                {
                    reset += word[j];
                    for(int k = 0 , h = 1; h > i  ; k++)
                    {
                        if(reset[k] == reset[(reset.Length)/2])
                        {
                            break; 
                        }
                        else if(reset[k] == reset[reset.Length - 1 - k])
                        {
                            
                            count++;
                        }
                        if(reset[k] == reset[(reset.Length)/2])

                        h++;

                    }
                    if(count == reset.Length-1)
                    {
                        for(int m = 0 ; m <= 1 ; m++)
                        {
                            if(m == 0)
                            {
                                reset2 = reset;
                            }
                            if(m > 0 && count >= min)
                            {
                                min = count;
                                reset2 = reset;
                                
                            }
                        }
                    }
                }
                reset = " ";
                count = 0;
            }
            Console.WriteLine(reset2);
            
        }
    }
}
