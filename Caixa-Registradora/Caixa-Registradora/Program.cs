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

            string produtoNome1 = "Teste 1", produtoNome2 = "Teste 2", produtoNome3 = "Teste 3";
            float valor1 = 10, valor2 = 100, valor3 = 1000;
            int quantidade1 = 1000, quantidade2 = 1000, quantidade3 = 1000;


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
                Console.ResetColor();

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

                    Console.Write("Inira o valor do " + produtoNome1 + ": R$ ");
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

                    Console.Write("Inira o valor do " + produtoNome2 + ": R$ ");
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

                    Console.Write("Inira o valor do " + produtoNome3 + ": R$ ");
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

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n ____  ____  ____  ____  ____  ____ \r\n||V ||||e ||||n ||||d ||||a ||||s ||\r\n||__||||__||||__||||__||||__||||__||\r\n|/__\\||/__\\||/__\\||/__\\||/__\\||/__\\|\n\n");
                    Console.ResetColor();

                    int menu_vendas;
                    int vendida;
                    float vendaDinheiro, dinheiroEntregue, troco;

                    Console.WriteLine("1 - " + produtoNome1);
                    Console.WriteLine("2 - " + produtoNome2);
                    Console.WriteLine("3 - " + produtoNome3);
                    Console.Write("\nDigite o número do produto para venda: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    menu_vendas = int.Parse(Console.ReadLine());
                    Console.ResetColor();

                    if (menu_vendas == 1)
                    {

                        Console.WriteLine("\nProduto: " + produtoNome1);
                        Console.WriteLine("Valor: R$ " + valor1);
                        Console.WriteLine("Estoque: " + quantidade1);

                        Console.Write("Quantidade vendidida: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        vendida = int.Parse(Console.ReadLine());
                        Console.ResetColor();

                        Console.Write("Dinheiro: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        dinheiroEntregue = float.Parse(Console.ReadLine());
                        Console.ResetColor();

                        vendaDinheiro = vendida * valor1;
                        troco = dinheiroEntregue - vendaDinheiro;

                        if (vendida > quantidade1 || dinheiroEntregue < vendaDinheiro)
                        {

                            Console.WriteLine("Ta vendendo mais do que tem ou dinheiro insuficiente");

                        }
                        else
                        {

                            Console.WriteLine("Foram vendidos " + vendida + " " + produtoNome1 + " Totalizando: " + vendaDinheiro + " Com um troco de: " + troco);
                            quantidade1 -= vendida;

                        }

                    }

                    else if (menu_vendas == 2)
                    {

                        Console.WriteLine("\nProduto: " + produtoNome2);
                        Console.WriteLine("Valor: R$ " + valor2);
                        Console.WriteLine("Estoque: " + quantidade2);

                        Console.Write("Quantidade vendidida: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        vendida = int.Parse(Console.ReadLine());
                        Console.ResetColor();

                        Console.Write("Dinheiro: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        dinheiroEntregue = float.Parse(Console.ReadLine());
                        Console.ResetColor();

                        vendaDinheiro = vendida * valor2;
                        troco = dinheiroEntregue - vendaDinheiro;

                        if (vendida > quantidade2 || dinheiroEntregue < vendaDinheiro)
                        {

                            Console.WriteLine("Ta vendendo mais do que tem ou dinheiro insuficiente");

                        }
                        else
                        {

                            Console.WriteLine("Foram vendidos " + vendida + " " + produtoNome2 + " Totalizando: " + vendaDinheiro + " Com um troco de: " + troco);
                            quantidade2 -= vendida;

                        }

                    }

                    else if (menu_vendas == 3)
                    {

                        Console.WriteLine("\nProduto: " + produtoNome3);
                        Console.WriteLine("Valor: R$ " + valor3);
                        Console.WriteLine("Estoque: " + quantidade3);

                        Console.Write("Quantidade vendidida: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        vendida = int.Parse(Console.ReadLine());
                        Console.ResetColor();

                        Console.Write("Dinheiro: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        dinheiroEntregue = float.Parse(Console.ReadLine());
                        Console.ResetColor();

                        vendaDinheiro = vendida * valor3;
                        troco = dinheiroEntregue - vendaDinheiro;

                        if (vendida > quantidade3 || dinheiroEntregue < vendaDinheiro)
                        {

                            Console.WriteLine("Ta vendendo mais do que tem ou dinheiro insuficiente");

                        }
                        else
                        {

                            Console.WriteLine("Foram vendidos " + vendida + " " + produtoNome3 + " Totalizando: " + vendaDinheiro + " Com um troco de: " + troco);
                            quantidade3 -= vendida;

                        }

                    }

                    else
                    {

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Produto indisponível");
                        Console.ResetColor();

                    }

                }

                else if (menu == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n ____  ____  ____  ____  ____  ____  ____  ____  ____ \r\n||R ||||e ||||l ||||a ||||t ||||ó ||||r ||||i ||||o ||\r\n||__||||__||||__||||__||||__||||__||||__||||__||||__||\r\n|/__\\||/__\\||/__\\||/__\\||/__\\||/__\\||/__\\||/__\\||/__\\|\n\n");
                    Console.ResetColor();

                    Console.WriteLine("Bem vindo ao relatorio!!");
                    Console.WriteLine("\n- Prodoto 1: " + produtoNome1 + "\n- Estoque: " + quantidade1 + "\n- Valor: " + valor1);
                    Console.WriteLine("\n- Prodoto 2: " + produtoNome2 + "\n- Estoque: " + quantidade2 + "\n- Valor: " + valor2);
                    Console.WriteLine("\n- Prodoto 3: " + produtoNome3 + "\n- Estoque: " + quantidade3 + "\n- Valor: " + valor3);

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
                Console.Clear();

            }


            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\n\n\nAperte qualquer tecla para finalizar o programa...");
            Console.ReadKey();
        }
    }
}
