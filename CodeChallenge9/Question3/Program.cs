using System;
using System.Collections.Generic;
using System.Linq;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            SplitString("the day is sunny sunny is is the the");
        }
        static   void SplitString (string s)
        {
            string [] words = s.Split(" ");
            string x = "";
            Dictionary<string , int> word = new Dictionary<string, int>();
            int count = 1;
            string y ="";
            
            bool contains = false;

            List<int> num = new List<int>();
          
            
            for(int i = 0; i < words.Length; i++)
            {
                x = words[i];
               
                contains = y.Contains(words[i]);
                y+=words[i];
                if(!contains)
                {
                    for(int j = i+1 ; j < words.Length;j++)
                    {
                        if(x == words[j])
                        {
                            count++;
                        }
                    }
                    word.Add(words[i].ToString() , count);
                    num.Add(count);
                 
                  
                    count = 1;
                }
               
                
            }
            var descendingOrder = num.OrderByDescending(i => i);

            foreach (var item in descendingOrder)
            {
                var myKey = word.FirstOrDefault(x => x.Value == item).Key;
                Console.WriteLine($" {myKey} {item}");
                word.Remove(myKey);
            }
        
            
        }
    }
}
