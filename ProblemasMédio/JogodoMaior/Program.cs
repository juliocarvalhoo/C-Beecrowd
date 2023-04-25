using JogodoMaior.Class;
using static System.Console;

public class Program
{
    static void main()
    {
        List<Jogadores> infoPlayer = new List<Jogadores>();

        WriteLine("Quantidade de player: ");
        int amountPlayers = int.Parse(ReadLine());
        List<string> listPlayers = new List<string>();
        for (int i = 0; i < amountPlayers; i++)
        {   
            WriteLine($"Nome jogador {i}: ");
            string? ThePlayer = Console.ReadLine();
            listPlayers.Add(ThePlayer);

        }

        WriteLine("Insira a quantidade de Rounds: ");
        int rounds = int.Parse(ReadLine());

        for (int i = 0; i < rounds; i++)
        {
            string[] game = ReadLine().Split(" ");

        }

    }
}