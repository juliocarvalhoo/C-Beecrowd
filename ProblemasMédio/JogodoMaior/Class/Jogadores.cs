namespace JogodoMaior.Class
{
    public class Jogadores
    {
        public string Player { get; set; }
        public int[]? Choices { get; set; }
        public Jogadores(string player, int[] choices)
        {
            this.Player = player;
            this.Choices = choices;
        }
        
    }
}