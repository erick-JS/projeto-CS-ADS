using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
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
            string u = User.Text;
            string p = Passwd.Text;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://adsangelinabancodedados.uc.r.appspot.com/empresa/login/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    usuario = u,
                    senha = p,
                });
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var stream = httpResponse.GetResponseStream();
            var sr = new StreamReader(stream);
            var content = sr.ReadToEnd();
            dynamic m = JsonConvert.DeserializeObject(content);
            try
            {
                string sta = m.status;
                if (sta == "sim")
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
                    string querry = "INSERT INTO login VALUES (0,'"+u+"','"+p+"')";
                    SQLiteCommand como = new SQLiteCommand(querry, liga);
                    como.ExecuteNonQuery();
                    como.Dispose();
                    liga.Dispose();
                    
                    Hide();
                    Home newForm2 = new Home();
                    newForm2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Senha ou usuario incorreto");
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

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
