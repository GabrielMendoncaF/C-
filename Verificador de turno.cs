using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        enum Periodos { Matutino, Vespertino, Noturno, Madrugada }
        static void Main(string[] args)
        {
            //cria o enum periodo e pergunta o horário
            Periodos periodo; 
            Console.WriteLine("Insira um horario, sem os minutos");
            periodo = VerificaPeriodo();
            Console.WriteLine("O periodo da hora solicitada é: " + periodo);
            Console.ReadLine();
        }

        //associa as horas do dia a um periodo e retorna o enum
        static Periodos VerificaPeriodo()
        {
            Periodos periodos = default;
            int a = 0;
            while (a == 0)
            {
                int horario;
                horario = int.Parse(Console.ReadLine());
                if (0 <= horario && horario < 6)
                {
                    periodos = Periodos.Madrugada;
                    a = 1;
                }
                else if (6 <= horario && horario < 12)
                {
                    periodos = Periodos.Matutino;
                    a = 1;
                }
                else if (12 <= horario && horario < 18)
                {
                    periodos = Periodos.Vespertino;
                    a = 1;
                }
                else if (18 <= horario && horario < 24)
                {
                    periodos = Periodos.Noturno;
                    a = 1;
                }
                else
                {
                    Console.WriteLine("ERRO: Insira um horario, entre 0 e 23 sem os minutos");
                    a = 0;
                }
            }
            return periodos;
        }
    }
}
