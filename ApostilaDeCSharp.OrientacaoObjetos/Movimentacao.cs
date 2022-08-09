using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ApostilaDeCSharp.OrientacaoObjetos
{
    public class Movimentacao
    {
        // Estou criando método Construtor por associação 
        public string Voar(Personagem p)

        {
            if(p.QtdePontos > 10)
            {
                SoundPlayer player = new SoundPlayer(@"C:\Users\Aluno\Documents\voando.wav");
                //SoundPlayer player = new SoundPlayer();
                //player.SoundLocation = "C:\\Users\\Aluno\\Documents\\voando.wav";
                //player.SoundLocation = @"C:\Users\Aluno\Documents\voando.wav";
                //player.Play();
                player.PlayLooping();
                return $"{p.Nome} voou";
            }
            else
            {
                return $"{p.Nome} não voou";
            }
        }

    public string Nadar(Personagem p)
        {
            if (p.QtdePontos > 10)
            {
                SoundPlayer player = new SoundPlayer(@"C:\Users\Aluno\Documents\nadar.wav");
                //SoundPlayer player = new SoundPlayer();
                //player.SoundLocation = "C:\\Users\\Aluno\\Documents\\voando.wav";
                //player.SoundLocation = @"C:\Users\Aluno\Documents\voando.wav";
                //player.Play();
                player.PlayLooping();
                return $"{p.Nome} Nadou";
            }
            else
            {
                return $"{p.Nome} não nadou";
            }

        }
        public string Pular(Personagem p)
        {
            if (p.QtdePontos > 10)
            {
                SoundPlayer player = new SoundPlayer(@"C:\Users\Aluno\Documents\pular.wav");
                //SoundPlayer player = new SoundPlayer();
                //player.SoundLocation = "C:\\Users\\Aluno\\Documents\\voando.wav";
                //player.SoundLocation = @"C:\Users\Aluno\Documents\voando.wav";
                //player.Play();
                player.PlayLooping();
                return $"{p.Nome} Pulou";
            }
            else
            {
                return $"{p.Nome} não Pulou";
            }
        }
        public string Correr(Personagem p)
        {
            if (p.QtdePontos > 10)
            {
                SoundPlayer player = new SoundPlayer(@"C:\Users\Aluno\Documents\correr.wav");
                //SoundPlayer player = new SoundPlayer();
                //player.SoundLocation = "C:\\Users\\Aluno\\Documents\\voando.wav";
                //player.SoundLocation = @"C:\Users\Aluno\Documents\voando.wav";
                //player.Play();
                player.PlayLooping();
                return $"{p.Nome} Correu";
            }
            else
            {
                return $"{p.Nome} não Correu";
            }

        }
        public string VirarEsquerda(Personagem p)
        {
            return $"{p.Nome} Virou a esquerda!";
        }
        public string VirarDireita(Personagem p)
        {
            return $"{p.Nome} Virou a direita!";
        }
        public string Parar(Personagem p)
        {
            return $"{p.Nome} Parou!";
        }
        public string Andar(Personagem p)
        {
            return $"{p.Nome} Andou!";
        }
        public string Voltar(Personagem p)
        {
            return $"{p.Nome} Voltou!";
        }
    }
}
