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
                // diretorio de som em casa **************
                SoundPlayer player = new SoundPlayer(@"C:\Users\UltraHP\Documents\voando.wav");
                // diretorio de som no senai **************
                //SoundPlayer player = new SoundPlayer(@"C:\Users\Aluno\Documents\voando.wav");
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
                SoundPlayer player = new SoundPlayer(@"C:\Users\UltraHP\Documents\Nadar.wav");
                //SoundPlayer player = new SoundPlayer(@"C:\Users\Aluno\Documents\nadar.wav");
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
                SoundPlayer player = new SoundPlayer(@"C:\Users\UltraHP\Documents\Pular.wav");
                //SoundPlayer player = new SoundPlayer(@"C:\Users\Aluno\Documents\voando.wav");
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
                SoundPlayer player = new SoundPlayer(@"C:\Users\UltraHP\Documents\Correr.wav");
                //SoundPlayer player = new SoundPlayer(@"C:\Users\Aluno\Documents\correr.wav");
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
            if (p.QtdePontos > 10)
            {
                //SoundPlayer player = new SoundPlayer(@"C:\Users\Aluno\Documents\virare.wav");
                //SoundPlayer player = new SoundPlayer();
                //player.SoundLocation = "C:\\Users\\Aluno\\Documents\\voando.wav";
                //player.SoundLocation = @"C:\Users\Aluno\Documents\voando.wav";
                //player.Play();
                //player.PlayLooping();
                return $"{p.Nome} Virou esquerda";
            }
            else
            {
                return $"{p.Nome} não Virou esquerda";
            }
             
        }
        public string VirarDireita(Personagem p)
        {
            if (p.QtdePontos > 10)
            {
                //SoundPlayer player = new SoundPlayer(@"C:\Users\Aluno\Documents\virard.wav");
                //SoundPlayer player = new SoundPlayer();
                //player.SoundLocation = "C:\\Users\\Aluno\\Documents\\voando.wav";
                //player.SoundLocation = @"C:\Users\Aluno\Documents\voando.wav";
                //player.Play();
                //player.PlayLooping();
                return $"{p.Nome} Virou direita";
            }
            else
            {
                return $"{p.Nome} não Virou direita";
            }
        }
        public string Parar(Personagem p)
        {
            if (p.QtdePontos > 10)
            {
                SoundPlayer player = new SoundPlayer(@"C:\Users\UltraHP\Documents\Freada.wav");
                //SoundPlayer player = new SoundPlayer(@"C:\Users\Aluno\Documents\parar.wav");
                //SoundPlayer player = new SoundPlayer();
                //player.SoundLocation = "C:\\Users\\Aluno\\Documents\\voando.wav";
                //player.SoundLocation = @"C:\Users\Aluno\Documents\voando.wav";
                //player.Play();
                player.PlayLooping();
                return $"{p.Nome} Parou";
            }
            else
            {
                return $"{p.Nome} não Parou";
            }
        }
        public string Andar(Personagem p)
        {
            if (p.QtdePontos > 10)
            {
                SoundPlayer player = new SoundPlayer(@"C:\Users\UltraHP\Documents\Andar.wav");
                //SoundPlayer player = new SoundPlayer(@"C:\Users\Aluno\Documents\voando.wav");
                //SoundPlayer player = new SoundPlayer();
                //player.SoundLocation = "C:\\Users\\Aluno\\Documents\\voando.wav";
                //player.SoundLocation = @"C:\Users\Aluno\Documents\voando.wav";
                //player.Play();
                player.PlayLooping();
                return $"{p.Nome} Andou";
            }
            else
            {
                return $"{p.Nome} não Andou";
            }
        }
        public string Voltar(Personagem p)
        {
            if (p.QtdePontos > 10)
            {
               // SoundPlayer player = new SoundPlayer(@"C:\Users\Aluno\Documents\voltar.wav");
                //SoundPlayer player = new SoundPlayer();
                //player.SoundLocation = "C:\\Users\\Aluno\\Documents\\voando.wav";
                //player.SoundLocation = @"C:\Users\Aluno\Documents\voando.wav";
                //player.Play();
               // player.PlayLooping();
                return $"{p.Nome} Voltou";
            }
            else
            {
                return $"{p.Nome} não Voltou";
            }
        }
    }
}
