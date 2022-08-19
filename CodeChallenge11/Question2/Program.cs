// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int [] numbers = {1,2,3,7,8};
PlayGame(numbers);
static void PlayGame(int[] numbers)
{
    int firstPalayer = 0;
    int secondPlayer = 0;
    bool check = true;
    var checker = new List<int>();
    if (numbers.Length <= 1)
    {
        Console.WriteLine("There is no winner");
    }
    for (int i = 0; i < numbers.Length; i++)
    {
        checker.Add(numbers[i]);
    }

    while (check)
    {
        if (checker.Count >= 2)
        {
            Console.WriteLine("Enter number for first player");
            int num1 = int.Parse(Console.ReadLine());
            firstPalayer += num1;
            for (int k = 0; k < checker.Count; k++)
            {
                if (k == 0 && checker[k] == num1)
                {
                    checker.Remove(checker[k]);
                }
                else if (k == checker.Count - 1 && checker[k] == num1)
                {
                    checker.Remove(checker[k]);
                }
            }

            Console.WriteLine("Enter number for second player");
            int num2 = int.Parse(Console.ReadLine());
            secondPlayer += num2;
            for (int k = 0; k < checker.Count; k++)
            {
                if (k == 0 && checker[k] == num2)
                {
                    checker.Remove(checker[k]);
                }
                else if (k == checker.Count - 1 && checker[k] == num2)
                {
                    checker.Remove(checker[k]);
                }
            }
        }

        else 
        {
            check = false;
        }

    }
 Console.WriteLine(firstPalayer >= secondPlayer ? true : false);
}
