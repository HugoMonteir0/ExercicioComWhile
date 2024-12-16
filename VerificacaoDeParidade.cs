using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioComWhile
{
    internal class VerificacaoDeParidade
    {
        public static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um número:");

            // Loop enquanto o número for ímpar
            while ((numero = Convert.ToInt16(Console.ReadLine())) % 2 != 0)
            {
                Console.WriteLine("Número ímpar. Digite novamente:");
            }

            Console.WriteLine("Número par digitado com sucesso! Fim do programa.");
        }
    }
}