using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioComWhile
{
    internal class Contagem
    {
        public static void Main(string[] args)
        {
            int contadora = 1;
            while (contadora  <= 10)
            {
                Console.WriteLine(contadora);
                contadora++;
            }
            
        }
    }
}
