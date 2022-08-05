// See https://aka.ms/new-console-template for more information


int [] numbers = {7,1,5,2,3,1,3,2,9};
int highestNumber = numbers.Max();
int secondHighest = numbers.Where(n => n != highestNumber).Max();
bool reachedSecondHighest = false;
int stepCounter = 0;


for(int i = 0; i < numbers.Length-1;i++)
{
    if(numbers[i] == secondHighest)reachedSecondHighest = true;
    if(reachedSecondHighest)
    {
        if(numbers[i] != secondHighest && numbers[i] != highestNumber)
        {
            if(IsBlocked(i , numbers))
            {
                stepCounter += secondHighest - numbers[i];

            }
        }
    }
    else{
        if(numbers[i] > numbers[i+1])
        {
            stepCounter += numbers[i] - numbers[i+1];
        }
    }
}
Console.WriteLine(stepCounter);

// static IEnumerable<int> Yield(int [] numbers)
// {
//     foreach (var item in numbers)
//     {
//         yield return item;
//     }
// }
static bool IsBlocked(int index , int [] numbers)
{
    for(int i = index+1; i < numbers.Length; i++)
    {
        if(numbers[i] > numbers[index])return true;
       
    }
    return false;
}
