using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace ApostilaDeCSharp.OrientacaoObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* https://www.youtube.com/watch?v=TU2Q-iijsVc */
            // Programação em N camadas

            Personagem p = new Personagem();
            p.Nome = "Aloy";
            p.QtdePontos = 11;
            p.QtdeVidas = 7;

            Movimentacao m = new Movimentacao();
            //Console.WriteLine(m.Voar(p));,
            //Console.WriteLine(m.Nadar(p));
            Console.WriteLine(m.Andar(p));

            /*
            Personagem p1 = new Personagem();
            p1.Nome = "Yedo";
            p1.QtdePontos = 1;
            p1.QtdeVidas = 7;
            Console.WriteLine(p1.Voare());

            Movimentacao m = new Movimentacao();
            Console.WriteLine(m.Voar(p1));
         
            Movimentacao m1 = new Movimentacao();
            Console.WriteLine(m1.Voar(p1));
            */


            Console.ReadKey();
         

        }
    }
}
