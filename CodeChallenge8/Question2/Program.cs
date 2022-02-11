using System;
using System.Collections;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintPossibilities(7);
        }
        static void PrintPossibilities(int number)
        {
            var upper = new Stack();
            var lower = new Stack();
            string x = "";
            int count = 0;
            string y = "(";
            string j = ")";
            string w = "";
            string d = "";

                for (int i = 0; i < number; i++)
                {
                    count++;
                    upper.Push(y);
                    lower.Push(j);
                    

                    
                    for (int k = 0; k < number - count; k++)
                    {
                        x += "()";
                        
                    }
                    for (int l = 0; l < count; l++)
                    {
                        x += upper.Peek();
                    
                    }
                    for (int l = 0; l < count; l++)
                    {
                        x += lower.Peek();
                    
                    }
                   
                       for (int l = 0; l < count; l++)
                    {
                        w += upper.Peek();
                    
                    }
                    for (int l = 0; l < count; l++)
                    {
                        w += lower.Peek();
                    
                    }
                       for (int k = 0; k < number - count; k++)
                    {
                        w += "()";
                        
                    }
                      
                    for (int l = 0; l < count; l++)
                    {
                        d += upper.Peek();
                    
                    }
                  
                    for (int k = 0; k < number - count; k++)
                    {
                        d += "()";
                        
                    }
                      for (int l = 0; l < count; l++)
                    {
                        d += lower.Peek();
                    
                    }
                    
                    Console.WriteLine(x);
                    if(w != x )
                    {
                        Console.WriteLine(w);
                    }
                   else if(d != x)
                    {
                        Console.WriteLine(d);
                    }

                   else if(d != w)
                    {
                        Console.WriteLine(d);
                    }
                    
                    
                     x = null;
                     w = null;
                     d = null;
                }
               
           
           
        }
    }
}
