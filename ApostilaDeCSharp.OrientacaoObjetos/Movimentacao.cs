using System;
using System.Collections.Generic;
using System.IO;
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
                //SoundPlayer player = new SoundPlayer(@"C:\Users\Aluno\Documents\VS Comunity\ApostilaDeCSharp\voando.wav");
                // diretorio de som no senai **************
                //SoundPlayer player = new SoundPlayer(@"C:\Users\Aluno\Documents\voando.wav");
                // Neste caso para mandar os arquivos para o cliente - 2 cliques em Propeties e Resouces
                // colar os arquvos no diretorio
                SoundPlayer player = new SoundPlayer(Properties.Resources.voando);
                //player.SoundLocation = "C:\\Users\\Aluno\\Documents\\voando.wav";
                //player.SoundLocation = @"C:\Users\Aluno\Documents\voando.wav";
                //player.Play();
                player.PlayLooping();
                return $"{p.Nome} voou {DateTime.Now.ToString("F")}";
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
                //SoundPlayer player = new SoundPlayer(@"C:\Users\Aluno\Documents\VS Comunity\ApostilaDeCSharp\Nadar.wav");
                SoundPlayer player = new SoundPlayer(Properties.Resources.Nadar);
                player.PlayLooping();
                //==========================
                //== Ler e gravar um texto .txt
                //== https://docs.microsoft.com/pt-br/troubleshoot/developer/visualstudio/csharp/language-compilers/read-write-text-file
                //========================= 
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("C:\\Users\\UltraHP\\Documents\\Test.txt");
                //Write a line of text
                sw.WriteLine("Hello World!!");
                //Write a second line of text
                sw.WriteLine("From the StreamWriter class");
                sw.WriteLine($"{p.Nome} Nadou {DateTime.Now.ToString("F")}");
                //Close the file
                sw.Close();
                //==========================
                return $"{p.Nome} Nadou {DateTime.Now.ToString("F")}";
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
                //SoundPlayer player = new SoundPlayer(@"C:\Users\Aluno\Documents\VS Comunity\ApostilaDeCSharp\Pular.wav");
                SoundPlayer player = new SoundPlayer(Properties.Resources.Pular);
                player.PlayLooping();
                return $"{p.Nome} Pulou {DateTime.Now.ToString("F")}";
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
                //SoundPlayer player = new SoundPlayer(@"C:\Users\Aluno\Documents\VS Comunity\ApostilaDeCSharp\Correr.wav");
                SoundPlayer player = new SoundPlayer(Properties.Resources.Correr);
                player.PlayLooping();
                return $"{p.Nome} Correu {DateTime.Now.ToString("F")}";
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
                //player.PlayLooping();

                string Date = DateTime.Now.ToString("F");
                return $"{Date} Virou esquerda";
                //return $"{p.Nome} Virou esquerda";
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
                //SoundPlayer player = new SoundPlayer(@"C:\Users\Aluno\Documents\VS Comunity\ApostilaDeCSharp\Freada.wav");
                SoundPlayer player = new SoundPlayer(Properties.Resources.Freada);
                player.PlayLooping();
                return $"{p.Nome} Parou {DateTime.Now.ToString("F")}";
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
                //SoundPlayer player = new SoundPlayer(@"C:\Users\Aluno\Documents\VS Comunity\ApostilaDeCSharp\Andar.wav");
                SoundPlayer player = new SoundPlayer(Properties.Resources.Andar);
                player.PlayLooping();
                return $"{p.Nome} Andou {DateTime.Now.ToString("F")}";
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
               // player.PlayLooping();
                return $"{p.Nome} Voltou {DateTime.Now.ToString("F")}";
            }
            else
            {
                return $"{p.Nome} não Voltou";
            }
        }
    }
}
