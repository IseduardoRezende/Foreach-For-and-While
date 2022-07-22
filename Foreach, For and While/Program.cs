using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach__For_and_While
{
    class Program
    {
        static void Main(string[] args)
        {
            //FOREACH 

            string[] nome = { "Eduardo R\n", "Lívia S\n", "Raquel V\n", "Rodrigo R\n", "Larissa V\n", "Gabriel D\n", "Arthur R\n", "Laura V\n", "Silvia\n", "Claudio V\n" };
            foreach (string nomes in nome)
            {
                Console.WriteLine("Sejam bemv vindosª: " + nomes);
            }
            Console.ReadLine();

            // WHILE

            int car = 0;
            while (car < 200)
            {
                Console.WriteLine("Velocidade :" + car + "KM");
                car++;
            }
            
            Console.WriteLine("Você ultrapassou o limite de velocidade ! ");
            Console.ReadLine();

            // WHILE

            int relogio = 7;
            while (relogio >= 7 && relogio <= 17)
            {
                Console.WriteLine("Horário: " + relogio + " --- Mercado está aberto. ");
                relogio++;
            }
            
            Console.WriteLine("O mercado está fechado ! Horario de funcionamento das 7hrs às 17hrs. ");
            Console.ReadLine();

            // FOREACH 

            Console.WriteLine("Bem vindo a Pizza Hit\n");

            string[] sabor = { "Mussarela", "Queijo", "4 Queijos", "Portuguesa", "Chocolate", "Morango", "Prestígio", "Brocolis", "Escarola", "Angu" };
            foreach (string sabores in sabor)
            {
                Console.WriteLine("Sabor: " + sabores + "| Boa apetite.");
            }
            
            Console.ReadLine();

            // FOR
            
            for (int contador = 1000; contador > 0; contador--)
            {
                Console.WriteLine("Conatagem regressiva: " + contador + "seg");
            }
            
            Console.WriteLine("Você chegou ao Espaço !\n U arrived in Space ! ");
            Console.ReadLine();
            
            // ADD

            Console.WriteLine("If you love C# type 1 and if not, type 2.");
            int choice;
            choice = int.Parse(Console.ReadLine());
            if (1 == 1)
            {
                Console.WriteLine("I love too. S2");
            }
            else if (2 == 2)
            {
                Console.WriteLine("Howww ?? :(" );
            }
            else
            {
                Console.WriteLine("What's wrong with u ? ");
            }

            Console.WriteLine("Obrigado, Thanks !");

            Console.ReadLine();
        }
    }
}
