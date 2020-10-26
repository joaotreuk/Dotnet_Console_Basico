using GameConsole.Interface;

namespace GameConsole.lib
{
    public class Jogador : iJogador
    {
        public readonly string Nome;

        public Jogador(string nome = "Ronaldo")
        {
            Nome = nome;
        }

        public string Chuta()
        {
            return $"{Nome} está chutando!\n";
        }

        public string Corre()
        {
            return $"{Nome} está correndo!\n";
        }

        public string Passa()
        {
            return $"{Nome} está passando!\n";
        }
    }
}