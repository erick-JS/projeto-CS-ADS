using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa
{
    public partial class Servicos : Form
    {
        public Servicos()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void Servicos_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void txtServico_Enter(object sender, EventArgs e)
        {
            if (txtServico.Text == "Serviço")
            {
                txtServico.Text = "";
            }
            pnlServico.BackColor = Color.Black;
        }

        private void txtServico_Leave(object sender, EventArgs e)
        {
            if (txtServico.Text == "")
            {
                txtServico.Text = "Serviço";
            }
            pnlServico.BackColor = Color.Silver;
        }

        private void txtPreco_Enter(object sender, EventArgs e)
        {
            if (txtPreco.Text == "Preço")
            {
                txtPreco.Text = "";
            }
            pnlPreco.BackColor = Color.Black;
        }

        private void txtPreco_Leave(object sender, EventArgs e)
        {
            if (txtPreco.Text == "")
            {
                txtPreco.Text = "Preço";
            }
            pnlPreco.BackColor = Color.Silver;
        }

        private void mstTempoEstimado_Enter(object sender, EventArgs e)
        {
            if (mstTempoEstimado.Text == "Tempo estimado")
            {
                mstTempoEstimado.Text = "";
            }
            pnlTempo.BackColor = Color.Black;
        }

        private void mstTempoEstimado_Leave(object sender, EventArgs e)
        {
            if (mstTempoEstimado.Text == "")
            {
                mstTempoEstimado.Text = "Tempo estimado";
            }
            pnlTempo.BackColor = Color.Silver;
        }
    }
}
