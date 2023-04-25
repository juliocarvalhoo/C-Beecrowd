using static System.Console;
// dada a hora corrente e a hora do alarme, determine o número de minutos que ela poderia dormir.


static int[] ValoresEntrada()
{
    string[] entrada = ReadLine().Split(" ");
    int horarioAtual= Convert.ToInt32(entrada[0])*60+Convert.ToInt32(entrada[1]);
    int horarioDespertar= Convert.ToInt32(entrada[2])*60+Convert.ToInt32(entrada[3]);
    int[] arrayInteiros = new int[2]{horarioAtual,horarioDespertar};
    return arrayInteiros;
}

static int[] TempoDescanso()
{
    int[] array2 = ValoresEntrada();
    //int[] horarioAtual,horarioDespertar;
    int horarioAtual = array2[0];
    int horarioDespertar = array2[1];
    
    if(horarioAtual>horarioDespertar)
    {
        horarioDespertar += 24*60;
        WriteLine(horarioDespertar-horarioAtual);
    }
    else
    {
        WriteLine(horarioDespertar-horarioAtual);
    }
    return array2;
}

while (true)
{
    int[] array3 =TempoDescanso();
    int horarioAtual = array3[0];
    int horarioDespertar = array3[1];    

    if(horarioAtual == 0 && horarioDespertar == 0)
    {
        
        break;
    }
   
}

