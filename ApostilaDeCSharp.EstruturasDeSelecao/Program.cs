using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostilaDeCSharp.EstruturasDeSelecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if - estrutura de seleção simples
            double x = 43.5;
            if (x >= 43.1)
            {
                Console.WriteLine("Madaloriano");
            }

            // if else - estrutura de seleção composta
            var idade = 17;
            if (idade >= 43.1)
            {
                Console.WriteLine("Madaloriano");
            }
            else
            {
                Console.WriteLine("Grande Jovem Jovem");
            }

            // if else if - estrutura de sel~ção composta encadeada
            if (idade >= 43.1)
            {
                Console.WriteLine("Madaloriano");
            } else if (idade >= 18 && idade <= 43.1)
            {
                Console.WriteLine("Grande Jovem Jovem");
            }
            else
            {
                Console.WriteLine("Menino(a)");
            }


            // switch - estrutura de seleção multipla
            var dia = 7;
            switch (dia)
            {
                case 2: Console.WriteLine("segunda");break;
                case 3: Console.WriteLine("terça");break;
                case 4: Console.WriteLine("quarta"); break;
                case 5: Console.WriteLine("quinta"); break;
                case 6: Console.WriteLine("sexta"); break;
                default: Console.WriteLine("Fim de semana chegou...");break;

            }

            // Operador ternário
            string mensagem;
            var salario = 51000.20;
            mensagem = salario >= 50000.36 ? "Tá rico em?" : "Tá complicado";
            Console.WriteLine(mensagem);

            // exercicio

            var a = 8.0;
            var b = 2.0;
            double c = a % b;
            double r = a / b;
            string resp = "Numero Inteiro";
            if (c != 0)
            {
                resp = "Numero fracionario";
            }
            Console.WriteLine($"{resp} c = {c} - r = {r}");

            if (r.GetType() == typeof(double))
                Console.WriteLine(" *** Numero Fracionario ***");


            Console.ReadKey();
        }
    }
}
