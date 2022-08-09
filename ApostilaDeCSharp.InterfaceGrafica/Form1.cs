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
            Personagem p1 = new Personagem();
            p1.Nome = txtNome.Text;
            p1.QtdePontos = int.Parse(txtPontos.Text);

            Movimentacao m1 = new Movimentacao();
            MessageBox.Show (m1.Nadar(p1));
        }
    }
}
