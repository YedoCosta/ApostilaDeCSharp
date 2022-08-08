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
            p.QtdePontos = 0;
            p.QtdeVidas = 7;
            
            Movimentacao m = new Movimentacao();
            m.Voar(p);
            Console.WriteLine(m.Voar(p));
            Console.ReadKey();
        }
    }
}
