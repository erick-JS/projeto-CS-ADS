using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

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
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Gray;
            }
            panel_user.BackColor = Color.Black;
        }

        private void Passwd_Enter(object sender, EventArgs e)
        {
            if (txtPasswordd.Text == "Senha")
            {
                txtPasswordd.Text = "";
                txtPasswordd.ForeColor = Color.Gray;
                txtPasswordd.PasswordChar = '*';
            }
            panel_passwd.BackColor = Color.Black;
        }

        private void User_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.Silver;
            }
            panel_user.BackColor = Color.Silver;
        }

        private void Passwd_Leave(object sender, EventArgs e)
        {
            if (txtPasswordd.Text == "")
            {
                txtPasswordd.Text = "Senha";
                txtPasswordd.ForeColor = Color.Silver;
                txtPasswordd.PasswordChar = vazio;
            }
            panel_passwd.BackColor = Color.Silver;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://adsangelinabancodedados.uc.r.appspot.com/empresa/"+ txtUser.Text +"/");
            httpWebRequest.Accept = "application/json";
            httpWebRequest.Method = "GET";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var stream = httpResponse.GetResponseStream();
            var sr = new StreamReader(stream);
            var content = sr.ReadToEnd();
            dynamic m = JsonConvert.DeserializeObject(content);
            try
            {
                string nome = m.nome, endereco = m.endereco, bairro = m.bairro, telefone = m.telefone, numero = m.numero, cidade = m.cidade, uf = m.uf;
                string user = m.usuario;
                string pass = m.senha;
                if (txtUser.Text == user && txtPasswordd.Text == pass)
                {
                    MessageBox.Show("logado");

                }
            }
            catch (Exception)
            {
                MessageBox.Show("erro ao logar tente de novo");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Hide();
            Cadastro formCadastro = new Cadastro();
            formCadastro.ShowDialog();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
