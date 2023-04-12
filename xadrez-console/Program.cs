using xadrez;
using tabuleiro;
using xadrez_console;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida =  new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    try
                    {

                        Console.Clear();
                        Tela.imprimirPartida(partida);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);
                
                        partida.realizajogada(origem, destino);
                    }catch(TabuleiroException te)
                    {
                        Console.WriteLine(te.Message);
                        Console.ReadLine();
                    }
                }
                
                Tela.imprimirTabuleiro(partida.tab);
            }catch (TabuleiroException te) {
                Console.WriteLine(te.Message);
            }                   

            Console.ReadLine();
        }
    }
}