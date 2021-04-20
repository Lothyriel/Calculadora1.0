using System;

namespace Calculadora
{
    class Calculadora
    {
        private string[] operacoes = new string[100];

        public Calculadora()
        {
            int p = 0;
            while (true)
            {
                mostrarMenu();

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
                    mostrarAnteriores(); continue;
                }

                Console.Write("Digite o primeiro número: ");

                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");

                double num2 = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;
                string sinal = "";

                switch (opcao)
                {
                    case "1": resultado = num1 + num2; sinal = "+"; break;
                    case "2": resultado = num1 - num2; sinal = "-"; break;
                    case "3": resultado = num1 / num2; sinal = "/"; break;
                    case "4": resultado = num1 * num2; sinal = "*"; break;
                }
                this.operacoes[p] = num1.ToString() + sinal + num2.ToString() + " = " + resultado.ToString();
                p++;
                Console.WriteLine("Resultado: " + resultado);
            }
        }
        public void mostrarAnteriores()
        {
            if (operacoes[0] == null)
            {
                mostrarVermelho("Nenhuma operação realizada");
            }
            else
            {
                Console.WriteLine("Operações:");
                for (int i = 0; i < operacoes.Length; i++)
                {
                    if (operacoes[i] != null)
                    {
                        Console.WriteLine(operacoes[i]);
                    }
                }
            }
        }
        private void mostrarVermelho(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("\n" + mensagem + "\n");
            Console.ResetColor();
        }
        private void mostrarMenu()
        {
            Console.WriteLine("\nCalculadora 3.0");
            Console.WriteLine("Digite 1 para somar");
            Console.WriteLine("Digite 2 para subtrair");
            Console.WriteLine("Digite 3 para dividir");
            Console.WriteLine("Digite 4 para multiplicar");
            Console.WriteLine("Digite 5 para Mostrar operações anteriores");
            Console.WriteLine("Digite S para sair");
        }
    }
}
