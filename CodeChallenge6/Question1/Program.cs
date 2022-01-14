using System;
using System.Collections.Generic;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = {2,10};
            RearrangeNumbers(numbers);
        }
        static void RearrangeNumbers(int [] numbers)
        {
            int [] numbers2 = new int[numbers.Length];
            List<string> tenth = new List<string>();
            List<string> tenthRearrange = new List<string>();
            int ConvertBack2 = 0;
            int ConvertBack = 0;
            int count = 0;
            string reArrange = "";
            
            for (int i = 0; i < numbers.Length; i++)
            {
                tenth.Add(numbers[i].ToString());
            
            }
            for (int i = 0; i < tenth.Count; i++)
            {
                ConvertBack = int.Parse(tenth[i].Substring(0,1));
                for (int k = i + 1; k < tenth.Count; k++)
                {
                    ConvertBack2 = int.Parse(tenth[k].Substring(0,1));
                    if (ConvertBack > ConvertBack2)
                    {
                        count++;  
                    }
                }
                for (int j = 0; j < tenth.Count; j++)
                {
                    if(count == j)
                    {
                        numbers2[j] = int.Parse(tenth[i]);
                    }
                }

                for (int m = 0; m < numbers2.Length; m++)
                {
                    reArrange += numbers2[i].ToString();
                }
            }
            Console.WriteLine(reArrange);

        }
    }
}
