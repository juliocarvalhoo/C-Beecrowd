using static System.Console;
using RPGPokemonAlpha.PokemonForm;

namespace RPGPokemonAlpha.PokemonForm
{
    public class Program
    {
        static void Main()
        {
            
            PokemonMold Bulbasaur = new PokemonMold("Bulbasaur","Grass","Poison",17,"Jolly","Lvl",100,55,65,60);
            Bulbasaur.WatchPokemon();

        }
    }
}