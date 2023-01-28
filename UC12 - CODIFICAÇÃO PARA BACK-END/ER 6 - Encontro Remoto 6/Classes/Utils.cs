using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ER_6___Encontro_Remoto_6.Classes
{
    public static class Utils
    {
        public static void ParadaConsole(string texto)
        {
            Console.WriteLine(texto);
            Console.ReadLine();
        }

        public static void Loading(string texto, int tempo, int qntPontos, ConsoleColor corFundo = ConsoleColor.Black, ConsoleColor corFonte = ConsoleColor.White)
        {
            Console.BackgroundColor = corFundo;
            Console.ForegroundColor = corFonte;
            Console.Write(texto);


            for (int i = 1; i <= qntPontos; i++)
            {
                Console.Write($".");
                Thread.Sleep(tempo);
            }

            Console.ResetColor();
            Console.WriteLine("");
        }
    }
}