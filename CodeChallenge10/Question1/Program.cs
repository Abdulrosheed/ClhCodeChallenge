using System;
using System.Collections.Generic;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckSherlock("aaaaaaaab");
        }
        public static void CheckSherlock(string words)
        {
            List<int> counts = new List<int>();
            List<string> numbers = new List<string>();


            int count = 1;
            int count2 = 0;
            int count3 = 1;
            int mostFrequentlyOccured = 0;
        
            for (int j = 0; j < words.Length; j++)
            {

                for (int i = j + 1; i < words.Length; i++)
                {
                    
                    
                
                    if (words[j] == words[i])
                    {
                        count++;
                    }
                      
                

                }
                if(numbers.Contains(words[j].ToString()))
                {

                }
                else
                {
                    counts.Add(count);
                    numbers.Add(words[j].ToString());
                }
                
                count = 1;

            }
            if(counts.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }
            mostFrequentlyOccured = counts[0];
        
            for(int l = 0; l < counts.Count; l++)
            {
                for(int t = l+1 ; t < counts.Count; t++)
                {
                    if(counts[l] == counts[t])
                    {
                        count3++;
                    }
                }
                if(count3 > mostFrequentlyOccured)
                {
                    mostFrequentlyOccured = counts[l];
                }
                count3 = 1;
                
            }
            Console.WriteLine(mostFrequentlyOccured);
            for(int k = 0; k < counts.Count; k++)
            {
                if(mostFrequentlyOccured == counts[k])
                {
                    count2++;
                }
            }
            if(count2 == counts.Count)
            {
                Console.WriteLine("Yes");
                return;
            }
            else if(counts.Count - count2 == 1)
            {
                
                Console.WriteLine("Yes");
                return;
            }
            else{
                Console.WriteLine("No");
                return;
            }
        

        }
    }
}
