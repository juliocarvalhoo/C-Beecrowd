using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace RPGPokemonAlpha.PokemonForm
{
    public class PokemonMold
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Type2 { get; set; }
        public int Level { get; set; }
        public string Nature { get; set;}
        public string Evolution { get; set; }
        public int Hp { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Spd { get; set; }

        public PokemonMold(string name, string type, string type2, int level, string nature, string evolution, int hp, int atk, int def, int spd)
        {
            this.Name = name;
            this.Type = type;
            this.Type2 = type2;
            this.Level = level;
            this.Nature = nature;
            this.Evolution = evolution;
            this.Hp = hp;
            this.Atk = atk;
            this.Def = def;
            this.Spd = spd;
        }

        public void WatchPokemon()
        {
            WriteLine("------------------------------------------------");
            WriteLine($"{Name}             Level: {Level}");
            WriteLine($"Tipo: {Type}           Tipo2: {Type2}");
            WriteLine($"Nature: {Nature}         Evolui: {Level}");
            WriteLine("");
            WriteLine($"HP.......: {Hp}");
            WriteLine($"ATAQUE...: {Atk}");
            WriteLine($"DEFESA...: {Def}");
            WriteLine($"SPEED....: {Spd}");
            WriteLine("------------------------------------------------");
        }
       

    }
     
}