using ApostilaDeCSharp.OrientacaoObjetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApostilaDeCSharp.InterfaceGrafica
{
    public partial class lblTotalPontos : Form
    {
        public lblTotalPontos()
        {
            InitializeComponent();
        }

        private void btnVoar_Click(object sender, EventArgs e)
        {
            Personagem p = new Personagem();
            p.Nome = txtNome.Text;
            p.QtdePontos = int.Parse(txtPontos.Text);

            Movimentacao m = new Movimentacao();
            MessageBox.Show (m.Voar(p));
        }

        private void btnNadar_Click(object sender, EventArgs e)
        {
            Personagem p = new Personagem();
            p.Nome = txtNome.Text;
            p.QtdePontos = int.Parse(txtPontos.Text);

            Movimentacao m = new Movimentacao();
            MessageBox.Show(m.Nadar(p));
        }

        private void btnAndar_Click(object sender, EventArgs e)
        {
            Personagem p = new Personagem();
            p.Nome = txtNome.Text;
            p.QtdePontos = int.Parse(txtPontos.Text);

            Movimentacao m = new Movimentacao();
            MessageBox.Show(m.Andar(p));
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            Personagem p = new Personagem();
            p.Nome = txtNome.Text;
            p.QtdePontos = int.Parse(txtPontos.Text);

            Movimentacao m = new Movimentacao();
            MessageBox.Show(m.Parar(p));
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Personagem p = new Personagem();
            p.Nome = txtNome.Text;
            p.QtdePontos = int.Parse(txtPontos.Text);

            Movimentacao m = new Movimentacao();
            MessageBox.Show(m.Voltar(p));
        }

        private void btnPular_Click(object sender, EventArgs e)
        {
            Personagem p = new Personagem();
            p.Nome = txtNome.Text;
            p.QtdePontos = int.Parse(txtPontos.Text);

            Movimentacao m = new Movimentacao();
            MessageBox.Show(m.Pular(p));
        }

        private void btnCorrer_Click(object sender, EventArgs e)
        {
            Personagem p = new Personagem();
            p.Nome = txtNome.Text;
            p.QtdePontos = int.Parse(txtPontos.Text);

            Movimentacao m = new Movimentacao();
            MessageBox.Show(m.Correr(p));
        }

        private void btnVirarDireita_Click(object sender, EventArgs e)
        {
            Personagem p = new Personagem();
            p.Nome = txtNome.Text;
            p.QtdePontos = int.Parse(txtPontos.Text);

            Movimentacao m = new Movimentacao();
            MessageBox.Show(m.VirarDireita(p));
        }

        private void btnVirarEsquerda_Click(object sender, EventArgs e)
        {
            Personagem p = new Personagem();
            p.Nome = txtNome.Text;
            p.QtdePontos = int.Parse(txtPontos.Text);

            Movimentacao m = new Movimentacao();
            MessageBox.Show(m.VirarEsquerda(p));
        }
    }
}
