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
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://adsangelinabancodedados.uc.r.appspot.com/empresa/"+ User.Text +"/");
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
                if (User.Text == user && Passwd.Text == pass)
                {
                    MessageBox.Show("logado");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("erro ao logar tente de novo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Cadastro newForm2 = new Cadastro();
            newForm2.ShowDialog();
        }
    }
}
