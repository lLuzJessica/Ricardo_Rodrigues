using System;
using System.IO;

namespace CalculoDeFibonacci
{
    class CalculoFibonnacci
    {
        /* // Descrição
         *  Calculo de Fibbonaci C# Console
         *  Versão: 1.00.00
         *  Autor: Ricardo Tarozo
         * // Comentários
         *  Propoe a entrada de um numero informado pelo usuário
         *  Recebe esse numero que é a quantidade da sequencia a ser gerada
         *  Calcula esse numero e exibe na tela
         */
         

        static void Main()
        {
            Double dblPosicoesDaSequancia = 0;
            Console.WriteLine("Informe a quantidade de sequencias a serem calculadas :");
            dblPosicoesDaSequancia = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nNumero informardo...:" + Convert.ToString(dblPosicoesDaSequancia));
            Console.WriteLine("\n---------------------------------------------------------------");
            Console.WriteLine("\nResultados");
            Console.WriteLine("\n---------------------------------------------------------------");
            for (Double i = 0; i < dblPosicoesDaSequancia; i++)
            // Exibe a sequencia calculada por Triangulação
            {
                Console.WriteLine(FrameWorkLib.Fibonacci(i));
            }
            Console.WriteLine("\nQualquer Tecla para finalizar...");
            Console.ReadLine();
        }
    }
}
