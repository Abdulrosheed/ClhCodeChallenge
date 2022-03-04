using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] words = {"efghtyyvgm" , "ac", "nv" , "Jhnhavnnnx" , "Bukller" ,"muybt" , "hgdf"};
            CheckWords(words);
        }
        static  void CheckWords(string [] words)
        {
            int max = 0;
            int maximumLength = 0;
            int check = 0;
            string word = "";
            bool contains = true;

            for(int i = 0 ; i < words.Length ; i++)
            {
                max = words[i].Length;
                for(int j = i + 1; j < words.Length; j++)
                {
                    check = words[j].Length;
                    foreach(var item in words[j])
                    {
                        if(words[i].Contains(item))
                        {
                            contains = false;
                        }
                    }
                    
                    if(max == check && maximumLength < max && contains)
                    {
                        word = words[i];
                        maximumLength = max;
                    }
                    contains = true;
                }
                
                
            }
            if(word == null)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(Math.Pow(word.Length , 2));
            }
        }
    }
}
