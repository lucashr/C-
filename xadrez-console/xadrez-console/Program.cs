using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(1252);
            //Console.WriteLine((char)169);
            //Console.WriteLine((char)170);

            for (int i = 1; i < 256; i++)
            {
                Console.WriteLine("_|_");
            }
            //try
            //{
            //    //Tabuleiro tab = new Tabuleiro(8, 8);
            //    PartidaDeXadrez partida = new PartidaDeXadrez();


            //    Tela.imprimirTabuleiro(partida.tab);


            //}
            //catch (TabuleiroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            Console.ReadLine();
        }
    }
}
