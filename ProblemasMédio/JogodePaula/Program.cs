using static System.Console;

public class Program
{
    static void Main()
    {
        int numberTimes = int.Parse(ReadLine());
        var list = (Enumerable.Range('a', 'z' - 'a' + 1).Select(charCode => (char)charCode)).ToList();
        //LISTA DE A - Z EM MINUSCULO !!!!!!!!

        for (int i = 0; i < numberTimes; i++)
        {
            string entryNumbers = ReadLine();
            bool logic = false;

            char numberA = entryNumbers[0];
            char letter = entryNumbers[1];
            char numberB = entryNumbers[2];

            int numberOne = (int)Char.GetNumericValue(numberA); //CONVERTER CHAR PARA NUMERICO !!!
            int NumberTwo = (int)Char.GetNumericValue(numberB);
            
            if (numberOne == NumberTwo)
            {
                WriteLine(numberOne*NumberTwo);
            }    
            else
            {
                foreach (char item in list)
                {
                    if (item == letter)
                    {
                        
                        WriteLine(NumberTwo+numberOne);
                        logic = true;
                    }
                    
                }
                if(logic == false)
                {
                    WriteLine(NumberTwo-numberOne);
                }
                
            }
            
            
        }
        

    }
}