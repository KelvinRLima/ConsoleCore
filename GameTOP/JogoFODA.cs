using System;
using System.Collections.Generic;
using System.Text;
using GameTOP.Interface;

namespace GameTOP
{
    class JogoFoda
    {
        private readonly iJogador Jogador1;
        private readonly iJogador Jogador2;

        public JogoFoda(iJogador jogador1, iJogador jogador2)
        {
            Jogador1 = jogador1;
            Jogador2 = jogador2;
        }

        public void IniciarJogo()
        {
            Console.WriteLine(Jogador1.Chuta());
            Console.WriteLine(Jogador1.Corre());
            Console.WriteLine(Jogador1.Passa());
                         
            Console.WriteLine("\n PRÓXIMO JOGADOR");
                         
            Console.WriteLine(Jogador2.Chuta());
            Console.WriteLine(Jogador2.Corre());
            Console.WriteLine(Jogador2.Passa());
        }
    }
}
