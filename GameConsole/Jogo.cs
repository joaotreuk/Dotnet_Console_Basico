using GameConsole.Interface;
using System;

namespace GameConsole
{
    class Jogo
    {
        private readonly iJogador Jogador;
        private readonly iJogador Jogador2;

        public Jogo(iJogador jogador, iJogador jogador2)
        {
            Jogador = jogador;
            Jogador2 = jogador2;
        }

        public void IniciarJogo()
        {
            Console.Write(Jogador2.Passa());
            Console.Write(Jogador.Corre());
            Console.Write(Jogador2.Corre());
            Console.Write(Jogador.Chuta());
        }
    }
}