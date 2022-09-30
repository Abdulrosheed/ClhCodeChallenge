// See https://aka.ms/new-console-template for more information
Console.WriteLine($"{String.Join(',' , Case(new int[4,2]{{100,100} , {200,100},{600,100},{500,700}}))}");
static List<int> Case (int [,] array)
{
    List<int> heightAll = new List<int>();
    var previousTotalWidth = 0;
    var height = 0;
   
    for(int i = 0; i < array.GetLength(0) ; i++)
    {
        var totalWidth = 0;
        
        for(int j = 0; j < array.GetLength(1); j++)
        {
            totalWidth += array[i,j];
           if(j == 1 && height <= array[i,j]  && previousTotalWidth < array[i,j-1])
           {
                height = array[i,j];
           }
           else if(j ==1 &&previousTotalWidth > array[i,j-1] )
           {
                height += array[i,j];
           }

            
        }
        previousTotalWidth = totalWidth;
        heightAll.Add(height);
    }
   
   return heightAll;
}
