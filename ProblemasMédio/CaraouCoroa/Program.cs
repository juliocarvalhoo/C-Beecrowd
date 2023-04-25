using static System.Console;

public class Program
{
    static void Main()
    {
        while (true)
        {
            int numberofEntries = int.Parse(ReadLine());
            if (numberofEntries == 0)
            {
                break;
            }
            string[] arrayValores = ReadLine().Split(" ");
            int contadorMaria = 0;
            int contadorJoao = 0;

            foreach (var item in arrayValores)
            {
                if (item == "0")
                {
                    contadorMaria += 1;

                }
                else
                {
                    contadorJoao +=1;
                }
                
            }
            WriteLine($"Mary won {contadorMaria} times and John won {contadorJoao} times");

        // var meuHashSet = new HashSet<string>(arrayValores); //Tirar valores repetidos
        }


    }
}