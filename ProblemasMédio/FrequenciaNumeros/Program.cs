using static System.Console;
Main();

static void Main()
{
    List<int> newList = new List<int>();
    List<int> newList2 = new List<int>();

    int inputValue = int.Parse(ReadLine());

    for (int i = 0; i < inputValue; i++)
    {
        int temporaryValue = int.Parse(ReadLine());
        newList.Add(temporaryValue);               
    }
    newList.Sort();

    var newList3  = newList.Distinct();
    


    foreach (var item in newList3)
    {
        WriteLine($"{item} aparece {newList.Count(item)}");        
    }

}

 //[[0,1];[0,5]]

    
    


    
