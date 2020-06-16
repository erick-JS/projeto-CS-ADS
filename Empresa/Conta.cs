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
    public partial class Conta : Form
    {
        public Conta()
        {
            InitializeComponent();
        }

        String nome = "Fulano";
        String endereco = "Rua X";
        String bairro = "Vila Progresso";
        String numero = "234";
        String cidade = "Sorocaba";
        String uf = "SP";
        String telefone = "(11) 99999-9999";
        String usuario = "fulano123";

        //Método para alterar a aparência de cada textbox
        private void alterarAparencia(Panel panel, TextBox txt, string old_placeholder, string new_placeholder, Color cor)
        {
            if (txt.Text == old_placeholder)
            {
                txt.Text = new_placeholder;
            }

            panel.BackColor = cor;
        }

        private void btnSalvarDados_Click(object sender, EventArgs e)
        {

        }

        private void Conta_Load(object sender, EventArgs e)
        {
            txtNome.Text = nome;
            txtEndereco.Text = endereco;
            txtBairro.Text = bairro;
            txtNumero.Text = numero;
            txtCidade.Text = cidade;
            txtUF.Text = uf;
            txtTelefone.Text = telefone;
            txtUsuario.Text = usuario;
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            alterarAparencia(panel_nome, txtNome, "", "Nome", Color.Silver);
            //panel_nome.BackColor = Color.Silver;
        }

        private void txtEndereco_Enter(object sender, EventArgs e)
        {
            panel_endereco.BackColor = Color.Black;
        }

        private void txtEndereco_Leave(object sender, EventArgs e)
        {
            panel_endereco.BackColor = Color.Silver;
        }

        private void txtBairro_Enter(object sender, EventArgs e)
        {
            panel_bairro.BackColor = Color.Black;
        }

        private void txtBairro_Leave(object sender, EventArgs e)
        {
            panel_bairro.BackColor = Color.Silver;
        }

        private void txtNumero_Enter(object sender, EventArgs e)
        {
            panel_number.BackColor = Color.Black;
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            panel_number.BackColor = Color.Silver;
        }

        private void txtCidade_Enter(object sender, EventArgs e)
        {
            panel_cidade.BackColor = Color.Black;
        }

        private void txtCidade_Leave(object sender, EventArgs e)
        {
            panel_cidade.BackColor = Color.Silver;
        }

        private void txtUF_Enter(object sender, EventArgs e)
        {
            panel_uf.BackColor = Color.Black;
        }

        private void txtUF_Leave(object sender, EventArgs e)
        {
            panel_uf.BackColor = Color.Silver;
        }

        private void txtTelefone_Enter(object sender, EventArgs e)
        {
            panel_telefone.BackColor = Color.Black;
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            panel_telefone.BackColor = Color.Silver;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            panel_usuario.BackColor = Color.Black;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            panel_usuario.BackColor = Color.Silver;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
           //alterarAparencia(txtNome, "Nome");
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //alterarAparencia(txtNome, "");
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            alterarAparencia(panel_nome, txtNome, "Nome", "", Color.Black);
        }
    }
}
