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
using System.Data.SQLite;

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
                    InitializeComponent();
                    SQLiteConnection.CreateFile(@"dados.db");
                    SQLiteConnection ligacao = new SQLiteConnection();
                    ligacao.ConnectionString = @"Data source = dados.db; Version=3;";
                    ligacao.Open();
                    string query = "CREATE TABLE login (id int primary key, usuario varchar(50), senha varchar(50))";
                    SQLiteCommand comando = new SQLiteCommand(query, ligacao);
                    comando.ExecuteNonQuery();

                    SQLiteConnection liga = new SQLiteConnection();
                    liga.ConnectionString = @"Data source = dados.db; Version=3;";
                    liga.Open();
                    string querry = "INSERT INTO login VALUES (0,'"+user+"','"+pass+"')";
                    SQLiteCommand como = new SQLiteCommand(querry, liga);
                    como.ExecuteNonQuery();
                    como.Dispose();
                    liga.Dispose();
                    
                    Hide();
                    Home newForm2 = new Home();
                    newForm2.ShowDialog();
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
        int x, y;
        Point Point = new Point();
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point = Control.MousePosition;
                Point.X -= x;
                Point.Y -= y;
                this.Location = Point;
                Application.DoEvents();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Maximized;
                panel3.Size = new Size(404, 325);
            }
            else
            {
                WindowState = FormWindowState.Normal;
                panel3.Size = new Size(404, 425);
            }
            
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }
    }
}
