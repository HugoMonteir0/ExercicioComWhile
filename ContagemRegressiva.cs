using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioComWhile
{
    internal class ContagemRegressiva
    {
        public static void Main(string[] args)
        {
            int contagem = 10;
            while (contagem == 1)
            {
                Console.WriteLine(contagem);
                contagem--;
            }
        }
    }
}
