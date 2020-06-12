using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;

namespace Empresa
{
    public partial class Cadastro : Form
    {
        char vazio;
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Login newForm2 = new Login();
            newForm2.ShowDialog();
        }

        private void Uf_Enter(object sender, EventArgs e)
        {
            if (Uf.Text == "UF")
            {
                Uf.Text = "";
            }
            panel_uf.BackColor = Color.Black;
        }

        private void Uf_Leave(object sender, EventArgs e)
        {
            if (Uf.Text == "")
            {
                Uf.Text = "UF";
            }
            panel_uf.BackColor = Color.Silver;
            Uf.Text = Uf.Text.ToUpper();
        }

        private void Cidade_Enter(object sender, EventArgs e)
        {
            if (Cidade.Text == "Cidade")
            {
                Cidade.Text = "";
            }
            panel_cidade.BackColor = Color.Black;
        }

        private void Cidade_Leave(object sender, EventArgs e)
        {
            if (Cidade.Text == "")
            {
                Cidade.Text = "Cidade";
            }
            panel_cidade.BackColor = Color.Silver;
        }

        private void number_Enter(object sender, EventArgs e)
        {
            if (number.Text == "Nº")
            {
                number.Text = "";
            }
            panel_number.BackColor = Color.Black;
        }

        private void number_Leave(object sender, EventArgs e)
        {
            if (number.Text == "")
            {
                number.Text = "Nº";
            }
            panel_number.BackColor = Color.Silver;
        }

        private void Telefone_Enter(object sender, EventArgs e)
        {
            if (Telefone.Text == "Telefone")
            {
                Telefone.Text = "";
            }
            panel_telefone.BackColor = Color.Black;
        }

        private void Telefone_Leave(object sender, EventArgs e)
        {
            if (Telefone.Text == "")
            {
                Telefone.Text = "Telefone";
            }
            else
            {
                if(Telefone.Text.Length >= 10)
                {
                    if (Telefone.Text.Substring(0,1) != "(")
                    {
                        String content = Telefone.Text;
                        Telefone.Text = "(" + content.Substring(0, 2) + ") " + content.Substring(2, 6) + "-" + content.Substring(6);
                    }
                }
                else
                {
                    MessageBox.Show("Esta faltando numero no telefone");
                }
            }
            panel_telefone.BackColor = Color.Silver;
        }

        private void ComfirmSenha_Enter(object sender, EventArgs e)
        {
            if (ComfirmSenha.Text == "Confirmar Senha")
            {
                ComfirmSenha.Text = "";
                ComfirmSenha.PasswordChar = '*';
            }
            panel_comfirmsenha.BackColor = Color.Black;
        }

        private void ComfirmSenha_Leave(object sender, EventArgs e)
        {
            if (ComfirmSenha.Text == "")
            {
                ComfirmSenha.Text = "Confirmar Senha";
                ComfirmSenha.PasswordChar = vazio;
            }
            panel_comfirmsenha.BackColor = Color.Silver;
            if (ComfirmSenha.Text != Senha.Text)
            {
                errorProvider1.SetError(ComfirmSenha, "As senhas nao estão iguais");
            }
            else
            {
                errorProvider1.SetError(ComfirmSenha, "");
            }
        }

        private void Senha_Enter(object sender, EventArgs e)
        {
            if (Senha.Text == "Senha")
            {
                Senha.Text = "";
                Senha.PasswordChar = '*';
            }
            panel_senha.BackColor = Color.Black;
        }

        private void Senha_Leave(object sender, EventArgs e)
        {
            if (Senha.Text == "")
            {
                Senha.Text = "Senha";
                Senha.PasswordChar = vazio;
            }
            panel_senha.BackColor = Color.Silver;
        }

        private void Usuario_Enter(object sender, EventArgs e)
        {
            if (Usuario.Text == "Usuario")
            {
                Usuario.Text = "";
            }
            panel_usuario.BackColor = Color.Black;
        }

        private void Usuario_Leave(object sender, EventArgs e)
        {
            if (Usuario.Text == "")
            {
                Usuario.Text = "Usuario";
            }
            panel_usuario.BackColor = Color.Silver;
        }

        private void Bairro_Enter(object sender, EventArgs e)
        {
            if (Bairro.Text == "Bairro")
            {
                Bairro.Text = "";
            }
            panel_bairro.BackColor = Color.Black;
        }

        private void Bairro_Leave(object sender, EventArgs e)
        {
            if (Bairro.Text == "")
            {
                Bairro.Text = "Bairro";
            }
            panel_bairro.BackColor = Color.Silver;
        }

        private void Endereco_Enter(object sender, EventArgs e)
        {
            if (Endereco.Text == "Endereço")
            {
                Endereco.Text = "";
            }
            panel_endereco.BackColor = Color.Black;
        }

        private void Endereco_Leave(object sender, EventArgs e)
        {
            if(Endereco.Text == "")
            {
                Endereco.Text = "Endereço";
            }
            panel_endereco.BackColor = Color.Silver;
        }

        private void Nome_Enter(object sender, EventArgs e)
        {
            if (Nome.Text == "Nome da Empresa")
            {
                Nome.Text = "";
            }
            panel_nome.BackColor = Color.Black;
        }

        private void Nome_Leave(object sender, EventArgs e)
        {
            if (Nome.Text == "")
            {
                Nome.Text = "Nome da Empresa";
            }
            panel_nome.BackColor = Color.Silver;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cout = 0;
            if (Senha.Text != ComfirmSenha.Text)
            {
                errorProvider1.SetError(ComfirmSenha, "As senhas nao estão iguais");
            }
            else
            {
                errorProvider1.SetError(ComfirmSenha, "");
                cout++;
            }
            if (Nome.Text == "Nome da Empresa")
            {
                errorProvider1.SetError(Nome, "Obrigatorio");
            }
            else
            {
                errorProvider1.SetError(Nome, "");
                cout++;
            }
            if (Endereco.Text == "Endereço")
            {
                errorProvider1.SetError(Endereco, "Obrigatorio");
            }
            else
            {
                errorProvider1.SetError(Endereco, "");
                cout++;
            }
            if (Bairro.Text == "Bairro")
            {
                errorProvider1.SetError(Bairro, "Obrigatorio");
            }
            else
            {
                errorProvider1.SetError(Bairro, "");
                cout++;
            }
            if (Usuario.Text == "Usuario")
            {
                errorProvider1.SetError(Usuario, "Obrigatorio");
            }
            else
            {
                errorProvider1.SetError(Usuario, "");
                cout++;
            }
            if (Telefone.Text == "Telefone")
            {
                errorProvider1.SetError(Telefone, "Obrigatorio");
            }
            else
            {
                errorProvider1.SetError(Telefone, "");
                cout++;
            }
            if (number.Text == "Nº")
            {
                errorProvider1.SetError(number, "Obrigatorio");
            }
            else
            {
                errorProvider1.SetError(number, "");
                cout++;
            }
            if (Cidade.Text == "Cidade")
            {
                errorProvider1.SetError(Cidade, "Obrigatorio");
            }
            else
            {
                errorProvider1.SetError(Cidade, "");
                cout++;
            }
            if (Uf.Text == "UF")
            {
                errorProvider1.SetError(Uf, "Obrigatorio");
            }
            else
            {
                errorProvider1.SetError(Uf, "");
                cout++;
            }
            if (cout == 9)
            {
                string dinheiroo, debitoo, creditoo;
                if (Dinheiro.Checked)
                {
                    dinheiroo = "sim";
                }
                else
                {
                    dinheiroo = "nao";
                }
                if (Debito.Checked)
                {
                    debitoo = "sim";
                }
                else
                {
                    debitoo = "nao";
                }
                if (Credito.Checked)
                {
                    creditoo = "sim";
                }
                else
                {
                    creditoo = "nao";
                }
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://adsangelinabancodedados.uc.r.appspot.com/empresas/");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(new
                    {
                        usuario = Usuario.Text,
	                    senha = Senha.Text,
	                    nome = Nome.Text,
	                    numero = number.Text,
                        endereco = Endereco.Text,
	                    bairro = Bairro.Text,
                        telefone = Telefone.Text,
	                    cidade = Cidade.Text,
	                    uf = Uf.Text,
                        dinheiro = dinheiroo,
                        debito = debitoo,
                        credito = creditoo
                    });
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                Hide();
                Login newForm2 = new Login();
                newForm2.ShowDialog();

            }
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }
    }
}
