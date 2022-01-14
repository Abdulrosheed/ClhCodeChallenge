using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "**))";
            CheckCharactersCondition(x);
        }
        static void CheckCharactersCondition (string x)
        {
            bool check = false;
            int countRightParenthesis = 0;
            int countLeftParenthesis = 0;
            int countStar = 0;
            int difference = 0;

            foreach (var item in x)
            {
                if(item == '(')
                {
                    countLeftParenthesis++;
                }
                else if(item == ')')
                {
                    countRightParenthesis++;
                }
                else if(item == '*')
                {
                    countStar++;
                }
            }
            if(countRightParenthesis > countLeftParenthesis)
            {
                difference = countRightParenthesis - countLeftParenthesis;
            }
            if(countLeftParenthesis > countRightParenthesis)
            {
                difference = countLeftParenthesis - countRightParenthesis;
            }
            if(countLeftParenthesis == countRightParenthesis)
            {
                check = true;
            }
            if(countLeftParenthesis > countRightParenthesis && countStar >= difference)
            {
                check = true;
            }
            if (countRightParenthesis > countLeftParenthesis && countStar >= difference)
            {
                check = true;
            }
            Console.WriteLine(check);
        }
    }
}
