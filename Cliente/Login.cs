using Cliente;
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
    public partial class Login : Form
    {
        char vazio;
        public Login()
        {
            InitializeComponent();
        }

        private void User_Enter(object sender, EventArgs e)
        {
            if (User.Text == "Usuario")
            {
                User.Text = "";
                User.ForeColor = Color.Gray;
            }
            panel_user.BackColor = Color.Black;
        }

        private void Passwd_Enter(object sender, EventArgs e)
        {
            if (Passwd.Text == "Senha")
            {
                Passwd.Text = "";
                Passwd.ForeColor = Color.Gray;
                Passwd.PasswordChar = '*';
            }
            panel_passwd.BackColor = Color.Black;
        }

        private void User_Leave(object sender, EventArgs e)
        {
            if (User.Text == "")
            {
                User.Text = "Usuario";
                User.ForeColor = Color.Silver;
            }
            panel_user.BackColor = Color.Silver;
        }

        private void Passwd_Leave(object sender, EventArgs e)
        {
            if (Passwd.Text == "")
            {
                Passwd.Text = "Senha";
                Passwd.ForeColor = Color.Silver;
                Passwd.PasswordChar = vazio;
            }
            panel_passwd.BackColor = Color.Silver;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Home newForm2 = new Home();
            newForm2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Cadastro newForm2 = new Cadastro();
            newForm2.ShowDialog();
        }
    }
}
