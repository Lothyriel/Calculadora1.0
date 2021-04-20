using System;

namespace Calculadora
{
    class Calculadora
    {
        private string[] operacoes = new string[100];
        int p = 0;

        public void operacao(double num1, double num2,string opcao)
        {

            double resultado = 0;
            string sinal = "";

            switch (opcao)
            {
                case "1": resultado = num1 + num2; sinal = "+"; break;
                case "2": resultado = num1 - num2; sinal = "-"; break;
                case "3": resultado = num1 / num2; sinal = "/"; break;
                case "4": resultado = num1 * num2; sinal = "*"; break;
            }
            Console.WriteLine("Resultado: " + resultado);
            this.operacoes[p] = num1.ToString() + sinal + num2.ToString() + " = " + resultado.ToString();
            p++;
        }
        public void mostrarAnteriores()
        {
            if (operacoes[0] == null)
            {
                mostrarVermelho("Nenhuma operação realizada");
            }
            else
            {
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
    }
}
