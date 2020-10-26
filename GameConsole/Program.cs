using GameConsole.lib;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogo jogo = new Jogo(new Jogador("João"), new Jogador2());
            jogo.IniciarJogo();
        }
    }
}
