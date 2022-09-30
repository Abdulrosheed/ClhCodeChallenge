// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine($"{String.Join(',' , ReturnAsteriods(new int[] { 10, 2,5}))}");

static List<int> ReturnAsteriods(int[] numbers)
{
    var finalList = new List<int>();
    if (!(numbers.Any(x => x < 0) && numbers.Any(x => x > 0)))
    {
        return numbers.ToList();
    }

    else
    {
        var listOfAsteriods = new List<string>();
        foreach (var item in numbers)
        {
            listOfAsteriods.Add(item.ToString());
        }
        for (int i = 0; i < listOfAsteriods.Count; i++)
        {
            if (i == 0 || int.Parse(listOfAsteriods[i]) >= 0) continue;
            else
            {
                for (int k = i; k == i; k++)
                {
                    for (int j = k - 1; j >= 0; j--)
                    {
                        int num;
                        if (int.TryParse(listOfAsteriods[j], out num) )
                        {
                            if ( Math.Abs(int.Parse(listOfAsteriods[j])) < Math.Abs(int.Parse(listOfAsteriods[k])))
                            {
                                listOfAsteriods[j] = "";

                            }
                            else if (Math.Abs(int.Parse(listOfAsteriods[j])) > Math.Abs(int.Parse(listOfAsteriods[k])))
                            {
                                listOfAsteriods[k] = "";
                                break;
                            }
                            else if (Math.Abs(int.Parse(listOfAsteriods[j])) == Math.Abs(int.Parse(listOfAsteriods[k])))
                            {
                                listOfAsteriods[k] = "";
                                listOfAsteriods[j] = "";
                                break;
                            }
                        }
                        else
                        {
                            continue;
                        }

                    }
                }
                

            }
          
           
            


        }
         foreach (var item in listOfAsteriods)
        {
            if(item != "")finalList.Add(int.Parse(item));
        }
        return finalList;


    }
  

}
