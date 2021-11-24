using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool continua = true, verificado = true;
            string verificacao;
            string[] produtos = new string[7]
            {
                "Headset",
                "Mouse",
                "Teclado",
                "Monitor",
                "Mesa",
                "Lâmpada",
                "Cadeira" 
            };
            string[] retorno = {"","","","","","","" };

            while (continua == true)
            {
            // acesso a lista de produtos
            Console.WriteLine("\nInsira o índice do produto para verificação");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("o produto de índice " + n + " é: " + produtos[n]);
            Console.WriteLine("Deseja modificar este produto?(S/N)");
            verificacao = Console.ReadLine();
            retorno = Prossegue(verificacao, produtos,n);
            retorno = LeitorDeLista(retorno);
            Console.WriteLine("Deseja realizar outra modificação?(S/N)");
            verificacao = Console.ReadLine();
            verificado = VerificaFim(verificacao);
            
            if(verificado == true)
                {
                    continua = true;
                }
            else 
                {
                    continua = false;
                }
            }
            Console.ReadLine();
        } 
        
        //função que verifica a entrada S (sim) ou N (não)
        static string[] Prossegue(string verificacao, string[] produtos, int n)
        {
            string novoProduto;
            
            while (verificacao != "s" && verificacao != "S" && verificacao != "n" && verificacao != "N")
            {
                Console.WriteLine("Entrada inválida, digite S para modificar o produto ou N para não modificar");
                verificacao = Console.ReadLine();
            }

            if (verificacao == "s" || verificacao == "S")
            {
                Console.WriteLine("Insira o nome do novo produto");
                novoProduto = Console.ReadLine();
                produtos[n] = novoProduto;
                
            }
            else if (verificacao == "n" || verificacao == "N")
            {
                Console.WriteLine("O produto não foi modificado");
            }
            return produtos;
        }

        //função que realiza a leitura do array
        static string[] LeitorDeLista(string[] lista)
        {
            Console.WriteLine("A lista final é: ");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i]);
            }
            return lista;
        }
        
        //função que verifica se outra modificaçao será realizada
        static bool VerificaFim(string verificacao)
        {
            bool verificou = false;
            while (verificacao != "s" && verificacao != "S" && verificacao != "n" && verificacao != "N")
            {
                Console.WriteLine("Entrada inválida, digite S para verificar ou N para não modificar");
                verificacao = Console.ReadLine();
            }
            if (verificacao == "s" || verificacao == "S")
            {
                verificou = true;
            }
            else if (verificacao == "n" || verificacao == "N")
            {
                Console.WriteLine("Verificação encerrada");
                verificou = false;
            }
            return verificou;
        }

    }
}
