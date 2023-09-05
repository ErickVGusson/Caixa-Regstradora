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
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("//   $$$$$$\\ $$\\           $$\\                                                $$\\                 $$$$$$\\                             $$$$$\\                   \r\n//  $$  __$$\\\\__|          $$ |                                               $$ |               $$  __$$\\                            \\__$$ |                  \r\n//  $$ /  \\__$$\\ $$$$$$$\\$$$$$$\\   $$$$$$\\ $$$$$$\\$$$$\\  $$$$$$\\         $$$$$$$ |$$$$$$\\        $$ /  \\__|$$$$$$\\ $$\\   $$\\             $$ |$$$$$$\\  $$$$$$\\  \r\n//  \\$$$$$$\\ $$ $$  _____\\_$$  _| $$  __$$\\$$  _$$  _$$\\ \\____$$\\       $$  __$$ $$  __$$\\       \\$$$$$$\\ $$  __$$\\$$ |  $$ |            $$ |\\____$$\\$$  __$$\\ \r\n//   \\____$$\\$$ \\$$$$$$\\   $$ |   $$$$$$$$ $$ / $$ / $$ |$$$$$$$ |      $$ /  $$ $$ /  $$ |       \\____$$\\$$$$$$$$ $$ |  $$ |      $$\\   $$ |$$$$$$$ $$ /  $$ |\r\n//  $$\\   $$ $$ |\\____$$\\  $$ |$$\\$$   ____$$ | $$ | $$ $$  __$$ |      $$ |  $$ $$ |  $$ |      $$\\   $$ $$   ____$$ |  $$ |      $$ |  $$ $$  __$$ $$ |  $$ |\r\n//  \\$$$$$$  $$ $$$$$$$  | \\$$$$  \\$$$$$$$\\$$ | $$ | $$ \\$$$$$$$ |      \\$$$$$$$ \\$$$$$$  |      \\$$$$$$  \\$$$$$$$\\\\$$$$$$  |      \\$$$$$$  \\$$$$$$$ \\$$$$$$  |\r\n//   \\______/\\__\\_______/   \\____/ \\_______\\__| \\__| \\__|\\_______|       \\_______|\\______/        \\______/ \\_______|\\______/        \\______/ \\_______|\\______/ \n\n\n\n\n\n\n");
            string loop;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Deseja iniciar o sistema [S/N]: ");
            loop = Console.ReadLine();

            string produtoNome1 = "", produtoNome2 = "", produtoNome3 = "";
            float valor1 = 0, valor2 = 0, valor3 = 0;
            int quantidade1 = 0, quantidade2 = 0, quantidade3 = 0;


            while (loop.ToUpper() == "S")
            {


                int menu;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nBoas vindas seu João, qual função desejas realizar hoje: ");
                Console.WriteLine("1 - Cadastrar um produto");
                Console.WriteLine("2 - Vender um produto");
                Console.WriteLine("3 - Relatório de vendas de um produto");
                Console.WriteLine("4 - Áreas de teste do sistema");
                Console.Write("Digite o número: ");

                Console.ForegroundColor = ConsoleColor.Red;
                menu = int.Parse(Console.ReadLine());

                Console.Clear();

                if (menu == 1)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n ____  ____  ____  ____  ____  ____  ____  ____ \r\n||c ||||a ||||d ||||a ||||s ||||t ||||r ||||o ||\r\n||__||||__||||__||||__||||__||||__||||__||||__||\r\n|/__\\||/__\\||/__\\||/__\\||/__\\||/__\\||/__\\||/__\\|");
                    Console.ResetColor();


                    Console.Write("\nInira o nome do 1º produto: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    produtoNome1 = Console.ReadLine();
                    Console.ResetColor();

                    Console.Write("Inira o valor do " + produtoNome1 + ": R$");
                    Console.ForegroundColor = ConsoleColor.Green;
                    valor1 = float.Parse(Console.ReadLine());
                    Console.ResetColor();

                    Console.Write("Inira a quantidade do " + produtoNome1 + ": ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    quantidade1 = int.Parse(Console.ReadLine());
                    Console.ResetColor();

                    Console.Write("\nInira o nome do 2º produto: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    produtoNome2 = Console.ReadLine();
                    Console.ResetColor();

                    Console.Write("Inira o valor do " + produtoNome2 + ": R$");
                    Console.ForegroundColor = ConsoleColor.Green;
                    valor2 = float.Parse(Console.ReadLine());
                    Console.ResetColor();

                    Console.Write("Inira a quantidade do " + produtoNome2 + ": ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    quantidade2 = int.Parse(Console.ReadLine());
                    Console.ResetColor();

                    Console.Write("\nInira o nome do 3º produto: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    produtoNome3 = Console.ReadLine();
                    Console.ResetColor();

                    Console.Write("Inira o valor do " + produtoNome3 + ": R$");
                    Console.ForegroundColor = ConsoleColor.Green;
                    valor3 = float.Parse(Console.ReadLine());
                    Console.ResetColor();

                    Console.Write("Inira a quantidade do " + produtoNome3 + ": ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    quantidade3 = int.Parse(Console.ReadLine());
                    Console.ResetColor();

                }

                else if (menu == 2)
                {

                    Console.WriteLine("Vendas");

                }

                else if (menu == 3)
                {

                    Console.WriteLine("\n// Relatório");

                    Console.WriteLine("Bem vindo ao relatorio!!");
                    Console.WriteLine("\nProdoto 1: " + produtoNome1 + " - Estoque: " + quantidade1 + " - Valor: " + valor1);
                    Console.WriteLine("\nProdoto 2: " + produtoNome2 + " - Estoque: " + quantidade2 + " - Valor: " + valor2);
                    Console.WriteLine("\nProdoto 3: " + produtoNome3 + " - Estoque: " + quantidade3 + " - Valor: " + valor3);

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
                loop = Console.ReadLine();

            }


            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\n\n\nAperte qualquer tecla para finalizar o programa...");
            Console.ReadKey();
        }
    }
}
