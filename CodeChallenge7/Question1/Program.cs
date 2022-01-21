using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            FindCompleteStairCaseRow(2);
        }
        
        static void FindCompleteStairCaseRow(int num)
        {
            int count = 0;
            int stairCase = 0;
            for (int i = 1; i <= num; i++)
            {
                stairCase += i;
                if(stairCase <= num)
                {
                    count++;
                }
                if(stairCase > num)
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}