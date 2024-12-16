using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioComWhile
{
    internal class Tabuada
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = Convert.ToInt16(Console.ReadLine());
            int i = 1; // Inicia o contador
            while (i <= 10) // Condição para continuar o loop
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
                i++; // Incrementa o contador
                
               
                
            }

           
        }
    }
}
