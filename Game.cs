using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Jokenpo
{
    class Game
    {
        public enum Resultado
        {
            Ganhar, Perder, Empatar
        }

        public Image[] images =
        {
            Image.FromFile("imagens/Pedra.png"),
            Image.FromFile("imagens/Papel.png"),
            Image.FromFile("imagens/Tesoura.png")
        };

        public Image ImgPC { get; private set; }

        public Image imgJogador { get; private set; }
            
        public Resultado Jogar (int jogador)
        {
            int pc = JogadaPC();

            imgJogador = images[jogador];
            ImgPC = images[pc];

            if(jogador == pc)
            {
                return Resultado.Empatar;
            }
            else if((jogador == 0 && pc == 2) || (jogador == 1 && pc == 0) || (jogador == 2 && pc == 1))
            {
                return Resultado.Ganhar;
            }
            else
            {
                return Resultado.Perder;
            }


            return Resultado.Empatar;
        }


        private int JogadaPC()
        {
            int mili = DateTime.Now.Millisecond;


            if (mili < 333)
            {
                return 0;
            }
            else if (mili >= 333 && mili < 667)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
