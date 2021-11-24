using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //insere o valor e o tipo de desconto
            float valor = 0f, resultado = 0f; ;
            Console.WriteLine("Insira o valor");
            valor = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o tipo de desconto: A,B,C ou 0, caso não houver");
            string desconto = Console.ReadLine();
            resultado = ValorFinal(valor, desconto);

            //caso o desconto seja inválido, pede outra entrada
            while (resultado == -1)
            {
                Console.WriteLine("Desconto inválido, insira outro ou 0 caso não exista nenhum");
                desconto = Console.ReadLine();
                resultado = ValorFinal(valor, desconto);
            }

            //caso o desconto seja válido, apresenta o valor final
            if (resultado != -1)
            {
                Console.WriteLine("O valor final é: " + resultado);
            }
            Console.ReadLine();
        }

        static float ValorFinal (float preco, string desconto)
        {
            float valorFinal = 0f;
            switch(desconto)
            {
                case "a"|| "A"
                    valorFinal = preco - (preco * 0.1f);
                    return valorFinal;

                case "b"||"B"
                    valorFinal = preco - (preco * 0.2f);
                    return valorFinal;

                case "c"||"C"
                    valorFinal = preco - (preco * 0.3f);
                    return valorFinal;

                case "0"
                    return preco;

                default:
                    return (-1);
            }
        }
    }
}
