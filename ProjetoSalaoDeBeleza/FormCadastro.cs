using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSalaoDeBeleza
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        public void limpaCampos()
        {
            txtNome.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtNomePerfil.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtConfirmaSenha.Text = string.Empty;

            mstTelefone.Text = string.Empty;

            cboEstado.SelectedIndex = -1;

            chkCredito.Checked = false;
            chkDebito.Checked = false;
        }

        /*public Boolean validar()
        {
        }*/

        public void mudaUsuario()
        {
            limpaCampos();

            if (rdbCliente.Checked)
            {
                gpxFormUsuario.Text = "Cliente";
                lblPagamento.Visible = false;
                chkCredito.Visible = false;
                chkDebito.Visible = false;
            }
            else
            {
                gpxFormUsuario.Text = "Salão de beleza";
                lblPagamento.Visible = true;
                chkCredito.Visible = true;
                chkDebito.Visible = true;
            }
        }

        private void FormCadCliente_Load(object sender, EventArgs e)
        {
            rdbCliente.Checked = true;
            lblPagamento.Visible = false;
            chkCredito.Visible = false;
            chkDebito.Visible = false;
        }

        private void rdbCliente_Click(object sender, EventArgs e)
        {
            mudaUsuario();
        }

        private void rdbSalaoBeleza_Click(object sender, EventArgs e)
        {
            mudaUsuario();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
