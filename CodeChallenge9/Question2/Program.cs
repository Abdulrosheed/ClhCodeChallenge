using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckPassWord("aayurtt2Zeyegvhdb1");
        }
        static  void CheckPassWord (string s)
        {
            string a = "";
            int count = 0;
            bool checker1 = false;
            bool checker2 = false;
            bool checker3 = false;
            int g = 0;

        
            int value = 0;
             string x = "abcdefghijklmnopqrstuvwxyz";
           
            if( s.Length > 5 && s.Length <= 20)
            {
                count++;
                count++;
            }
            for(int i = 0; i < s.Length; i++)
            {
              
                if((s[i].ToString() == s[i].ToString().ToLower() && x.Contains(s[i].ToString().ToLower())))
                {
                   checker1 = true;
                   
                }
                if(int.TryParse(s[i].ToString() , out value))
                {
                    checker2 = true;
                }
                if((s[i].ToString() == s[i].ToString().ToUpper() && x.Contains(s[i].ToString().ToLower())))
                {
                    checker3 = true;
                }
                for(int k = 0; k < 3;k++)
                {
                    a += s[i];
                }
                if(s.Contains(a))
                {
                    g = 1;
                }
                a = "";
             
            }
           
            if(g != 1)
            {
                count++;
            }
            if(checker1 && checker2 && checker3)
            {
                count = count + 3;
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
