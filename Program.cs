using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0800_classificação_etária
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Identificar categoria do jogador:\n\nInfantil    até 13 anos;\nJuvenil     até 17 anos;\nSênior acima de 17 anos.");

            Console.WriteLine();

            Console.Write("Informe a idade do jogador: ");
            int i = int.Parse(Console.ReadLine());

            if (i <=13)
            {

                Console.WriteLine("Categoria: Infantil (até 13 anos)");

            }
            else if  (i > 13 && i <= 17)
            {
                
                Console.WriteLine("Categoria: Juvenil (até 17 anos)");

            }
            else
            {
                Console.WriteLine("Categoria: Sênior (acima de 17 anos)");
            }

            Console.ReadLine(); 
        }
    }
}
