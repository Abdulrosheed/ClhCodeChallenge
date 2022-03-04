using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckPassWord("ayurteyegvhdb");
        }
        static  void CheckPassWord (string s)
        {
            string a = "";
            int count = 0;
            int count2 = 0;
            int g = 0;
            int value = 0;
           
            if( s.Length > 5 && s.Length <= 20)
            {
                count++;
                count++;
            }
            for(int i = 0; i < s.Length; i++)
            {
                
                if(s[i].ToString() == s[i].ToString().ToLower() && s[i].ToString() == s[i].ToString().ToUpper() && int.TryParse(s[i].ToString() , out value))
                {
                    count++;
                    count++;
                    count++;
                }
                foreach(var item in s)
                {
                    if(a == item.ToString())
                    {
                        count2++;
                    }
                    if(count2 == 3)
                    {
                        g  = 1;
                    }
                }
            }
            if(g == 0)
            {
                count++;
            }
            if(count == 6)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(6 - count);
            }
        }
    }
}
