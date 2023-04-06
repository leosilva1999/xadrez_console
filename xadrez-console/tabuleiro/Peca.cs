
using tabuleiro;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; set; }
        public  Tabuleiro Tab { get; set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            QteMovimentos = 0;
        }

        public abstract bool[,] movimentosPossiveis();
        

        public void incrementarQteMovimentos()
        {
            QteMovimentos++;
        }

        public abstract bool[,] movimentoPossiveis();
    }
}
