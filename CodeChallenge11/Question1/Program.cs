// See https://aka.ms/new-console-template for more information
int [] number1 = {5,2,3,1,20,9};
int [] number2 = {1,3,3,7,12,9};

CheckGallonAtFillingStation(number1  , number2  );

static void CheckGallonAtFillingStation(int [] gallons , int [] costs)
{
    string index = null;
    int currentGallonStation = 0;
    int totalGallon = 0;
    int count = 0;
    bool check = false;
    int number = 0;

    for(int i = 0; i < gallons.Length; i++)
    {
        currentGallonStation = gallons[i];
        


    

        for(int k =i; k < costs.Length;k++)
        {
            if(currentGallonStation < costs[k] && k == i)
            {
                break;
            }
            else if(k == costs.Length - 1 )
            {
                 totalGallon += gallons[k];
                 totalGallon -= costs[k];
                 count++;
                for(int j = 0; j < i ; j++)
                {
                    
                        totalGallon += gallons[j];
                        totalGallon -= costs[j];
                        count++;
                    
                }
            }
            else 
            {
                totalGallon += gallons[k];
                totalGallon -= costs[k];
                count++;
            }
        }
        if(count == gallons.Length && totalGallon >= 0)
        {
           check = true;
           index = i.ToString();
           Console.WriteLine(totalGallon);
           break;
        }
      
            totalGallon = 0;
            count = 0;

       
      
    }
    if(check)Console.WriteLine(index);
    else{
        Console.WriteLine(-1);
    }
}
