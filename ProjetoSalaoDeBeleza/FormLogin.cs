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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public void placeholder(TextBox obj, string mensagem)
        {
            obj.Text = mensagem;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblCadastro_Click(object sender, EventArgs e)
        {
            
        }
    }
}
