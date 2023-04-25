using static System.Console;

public class Program
{
    static void Main()
    {
        List<Pessoa> listJogadores = new List<Pessoa>();       
        string[] letras = {"A","B","C","D","E","F","G"};

        
        while (true)
        {
            string[] entrada = ReadLine().Split();
            int contadorUm = 0;
            int contadorZero = 0;
            for (int i = 0; i < entrada.Length; i++)
            {
                listJogadores.Add(new Pessoa(letras[i],int.Parse(entrada[i])));                
            }
            foreach (Pessoa item in listJogadores)
            {
                if(item.Escolha == 1)
                {
                    contadorUm +=1;
                }
                else
                {                        
                    contadorZero+=1;
                }
            }
            if(contadorZero ==1)
            {
                foreach (var item in listJogadores)
                {
                    if (item.Escolha == 0)
                    {
                        WriteLine(item.Jogador);
                        
                    }
                    
                }
                break;
            }

            if(contadorUm ==1)
            {
                foreach (var item in listJogadores)
                {
                    if (item.Escolha == 1)
                    {
                        WriteLine(item.Jogador);
                        
                    }
                    
                }
                break;
            }
            listJogadores.Clear();
            
        }
            

        }

    }

    
    public class Pessoa
    {
        public string Jogador { get; set; }
        public  int Escolha {get; set;}

        public Pessoa(string Jogador, int escolha)
        {
            this.Jogador = Jogador;
            this.Escolha = escolha;
        }
}






    


