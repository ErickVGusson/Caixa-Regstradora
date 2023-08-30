using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa_Registradora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string loop;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Deseja iniciar o sistema [S/N]: ");
            loop = Console.ReadLine();

            while (loop.ToUpper() == "S") 
            {

                Console.Clear();

                int menu;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Boa vindas seu João, qual função desejas realizar hoje: ");
                Console.WriteLine("1 - Cadastrar um produto");
                Console.WriteLine("2 - Vender um produto");
                Console.WriteLine("3 - Relatório de vendas de um produto");
                Console.WriteLine("4 - Áreas de teste do sistema");
                Console.Write("Digite o número: ");

                menu = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;

                if (menu == 1)
                {

                    string produtoNome, tipo;
                    float produtoPreco;

                    Console.Clear();

                    Console.WriteLine("Bem vindo ao cadastro");

                    Console.Write("Inira o tipo do produto (Bebida ou Comida) : ");
                    tipo = Console.ReadLine();

                    Console.Write("Inira o nome do produto: ");
                    produtoNome = Console.ReadLine();

                    Console.Write("Inira o valor do produto: ");
                    produtoPreco = float.Parse(Console.ReadLine());

                }

                else if (menu == 2)
                {

                    Console.WriteLine("Vendas");

                }

                else if (menu == 3)
                {

                    Console.WriteLine("Relatório");

                }

                else if (menu == 4)
                {

                    Console.Write("Digite uma frase: ");
                    string frase = Console.ReadLine();

                    Console.WriteLine(frase.ToUpper());
                    Console.WriteLine(frase.ToLower());

                }

                else
                {

                    Console.WriteLine("Favor, inserir um valor válido!");

                }

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("\n\nDeseja continuar no sistema [S/N]: ");
                loop =  Console.ReadLine();

            }


            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\n\n\nAperte qualquer tecla para finalizar o programa...");
            Console.ReadKey();
        }
    }
}
