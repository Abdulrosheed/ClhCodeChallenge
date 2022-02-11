using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckIfItContainsPermutation("abc" , "babcdfera");
        }
        static void CheckIfItContainsPermutation(string s1 , string s2)
        {
            int factorial = s1.Length;
            
            int sum = 1;
            var arr = s1.ToCharArray();
            string x = "";
            bool isSucess = false;
            int l = 0;
        
            for (int k = 1; k <= factorial; k++)
            {
                sum *=  k;
            }
        
            for (int i = 0; i < sum; i++)
            {
                for (int j = 0; j < s1.Length-1; j++)
                {
                    
                    x = arr[j].ToString();
                    arr[j] = arr[j+1];
                    arr[j+1] = char.Parse(x);
                    string m = new string(arr);
                
                    isSucess = Check(m ,s2, factorial);
            
                    
                
                }
                if(isSucess)
                {
                    l = 1;
                    break;
                
                }
            }
            if(l == 0)
            {
                Console.WriteLine("false");
            }
            else if(l == 1)
            {
                Console.WriteLine("true");
            }
        }
        static bool Check(string arr , string s2 , int length)
        {
            
            string checker = "";
            
                for (int j = 0; j < s2.Length - length; j++)
                {
                   var x = s2.Substring(j , length);
                   for (int m = x.Length-1 ; m >= 0 ; m--)
                   {
                       checker += x[m];
                   }
                   if(checker == arr || x == arr )
                   {
                       
                       
                       return true;
                   }
                }
               return false;
            
        }
    }
}
