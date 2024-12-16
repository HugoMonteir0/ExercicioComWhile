using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioComWhile
{
    internal class BuscaDeNumero
    {
        public static void Main()
        {
            int numeroSecreto = 42; // Número secreto definido
            int tentativa;

            Console.WriteLine("Tente adivinhar o número secreto!");
            do
            {
                Console.Write("Digite seu palpite: ");
                tentativa = int.Parse(Console.ReadLine());
            } while (tentativa != numeroSecreto);

            Console.WriteLine("Parabéns! Você acertou o número secreto. O númnero secreto é: " + numeroSecreto);
        }

    }
}
