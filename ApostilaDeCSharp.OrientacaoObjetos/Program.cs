using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostilaDeCSharp.OrientacaoObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personagem p = new Personagem();
            p.Nome = "Aloy";
            p.QtdePontos = 10;
            p.QtdeVidas = 7;
            Console.WriteLine(p.Voare());

            Movimentacao m = new Movimentacao();
            Console.WriteLine(m.Voar(p));
            Console.ReadKey();
        }
    }
}
