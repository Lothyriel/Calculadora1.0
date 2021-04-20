using System;
namespace Calculadora.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu();
            Calculadora c = new Calculadora();

            while (true)
            {
                m.mostrarMenu();

                string opcao = Console.ReadLine();

                if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "S" && opcao != "s")
                {
                    mostrarVermelho("Opção inválida");
                    continue;
                }

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                if (opcao == "5")
                {
                    if (c == null) { Console.WriteLine("Nenhuma operação realizada!");}
                    else
                    {
                        Console.WriteLine("Operações:");
                        c.mostrarAnteriores();
                    }
                    continue;
                }

                Console.Write("Digite o primeiro número: ");

                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");

                double num2 = Convert.ToDouble(Console.ReadLine());

                c.operacao(num1,num2,opcao);
            }
        }
        private static void mostrarVermelho(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("\n" + mensagem + "\n");
            Console.ResetColor();
        }

    }
}