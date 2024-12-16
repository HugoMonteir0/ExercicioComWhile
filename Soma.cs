using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioComWhile
{
    internal class Soma
    {
        public static void Main(string[] args)
        {

            int numero = -1; // Inicializamos com um valor diferente de 0 para entrar no loop
            int soma = 0;

            Console.WriteLine("Digite números inteiros (0 para sair):");

            while (numero != 0) // O loop continua enquanto o número for diferente de 0
            {
                Console.Write("Digite um número: ");
                numero = Convert.ToInt16(Console.ReadLine());
                soma += numero; // Soma o número digitado
            }

            Console.WriteLine($"A soma dos números digitados é: {soma}");
        }
    }

}
    
