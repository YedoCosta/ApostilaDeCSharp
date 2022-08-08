using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostilaDeCSharp.ParadigmaEstruturado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Sequêncial - topDown
             * 
             * Passo 1
             * Passo 2
             * Passo 3
             * Passo 4
             * 
            */
            string repetir;
            do
            {
                //Passo 1  Entrada de Dados

                Console.WriteLine("Qual o aluno?");
                string nome = Console.ReadLine();

                //Passo 2 - processamento

                string resposta;
                if (nome.Equals("Regys"))
                {
                    resposta = "\nNosso representante";

                    //============================ 

                    int[] nota = null;

                    nota = new int[4];

                    nota[0] = 9;
                    nota[1] = 21;
                    nota[2] = 7;
                    nota[3] = 15;

                    int soma = (nota[0] + nota[1] + nota[2] + nota[3]);

                    Console.WriteLine($"\n{soma}");
                    Console.ReadKey();

                    //==========================

                    double somat = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine(nota[i]);
                        somat = somat + nota[i];
                    }
                    double media = somat / nota.Length;
                    Console.WriteLine($"Soma: {somat}");
                    Console.WriteLine($"média: {media}");

                    //==========================

                }
                else
                {
                    resposta = "\nChame o representante";
                }

                // Passo 3 - Saida

                Console.WriteLine(resposta);

                // Passo 4 = Montar uma iteração
  
                string repetir1;
                do
                {
                    Console.WriteLine("\nDigite *** Y ou N ");
                    repetir1 = Console.ReadLine().ToUpper();
                    repetir = repetir1;

                } while (!repetir1.Equals("Y") && !repetir1.Equals("N"));
    
            } while (!repetir.Equals("Y"));

            Console.ReadKey();
        }
    }
}
