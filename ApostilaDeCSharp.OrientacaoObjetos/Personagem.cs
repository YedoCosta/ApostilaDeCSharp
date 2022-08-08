using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostilaDeCSharp.OrientacaoObjetos
{
    public class Personagem
    {
        // Estou criando propriedade
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QtdeVidas { get; set; }
        public int QtdePontos    { get; set; }

        public string Voare()
        {
            if (QtdePontos > 10)
            {
                return $"{Nome} voou voare";
            }
            else
            {
                return $"{Nome} não voou voare";
            }
        }
    }
}
