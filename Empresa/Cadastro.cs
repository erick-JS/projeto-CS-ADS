using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;
using System.Windows.Forms;


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
            if (txtUF.Text == "UF")
            {
                txtUF.Text = "";
            }
            panel_uf.BackColor = Color.Black;
        }

        private void Uf_Leave(object sender, EventArgs e)
        {
            if (txtUF.Text == "")
            {
                txtUF.Text = "UF";
            }
            panel_uf.BackColor = Color.Silver;
            txtUF.Text = txtUF.Text.ToUpper();
        }

        private void Cidade_Enter(object sender, EventArgs e)
        {
            if (txtCidade.Text == "Cidade")
            {
                txtCidade.Text = "";
            }
            panel_cidade.BackColor = Color.Black;
        }

        private void Cidade_Leave(object sender, EventArgs e)
        {
            if (txtCidade.Text == "")
            {
                txtCidade.Text = "Cidade";
            }
            panel_cidade.BackColor = Color.Silver;
        }

        private void number_Enter(object sender, EventArgs e)
        {
            if (txtNumero.Text == "Nº")
            {
                txtNumero.Text = "";
            }
            panel_number.BackColor = Color.Black;
        }

        private void number_Leave(object sender, EventArgs e)
        {
            if (txtNumero.Text == "")
            {
                txtNumero.Text = "Nº";
            }
            panel_number.BackColor = Color.Silver;
        }

        private void Telefone_Enter(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "Telefone")
            {
                txtTelefone.Text = "";
            }
            panel_telefone.BackColor = Color.Black;
        }

        private void Telefone_Leave(object sender, EventArgs e)
        {
            if (txtTelefone.Text.Length >= 10)
            {
                if (txtTelefone.Text.Substring(0, 1) != "(")
                {
                    String content = txtTelefone.Text;
                    txtTelefone.Text = "(" + content.Substring(0, 2) + ") " + content.Substring(2, 5) + "-" + content.Substring(7);
                }
            }
            else
            {
                MessageBox.Show("Esta faltando o número no telefone");
                txtTelefone.Focus();
            }
            /*if (txtTelefone.Text == "")
            {
                txtTelefone.Text = "Telefone";
            }
            else
            {
                if(txtTelefone.Text.Length >= 10)
                {
                    if (txtTelefone.Text.Substring(0,1) != "(")
                    {
                        String content = txtTelefone.Text;
                        txtTelefone.Text = "(" + content.Substring(0, 2) + ") " + content.Substring(2, 6) + "-" + content.Substring(6);
                    }
                }
                else
                {
                    MessageBox.Show("Esta faltando numero no telefone");
                }
            }*/
            panel_telefone.BackColor = Color.Silver;
        }

        private void ComfirmSenha_Enter(object sender, EventArgs e)
        {
            if (txtComfirmSenha.Text == "Confirmar Senha")
            {
                txtComfirmSenha.Text = "";
                txtComfirmSenha.PasswordChar = '*';
            }
            panel_comfirmsenha.BackColor = Color.Black;
        }

        private void ComfirmSenha_Leave(object sender, EventArgs e)
        {
            if (txtComfirmSenha.Text == "")
            {
                txtComfirmSenha.Text = "Confirmar Senha";
                txtComfirmSenha.PasswordChar = vazio;
            }
            panel_comfirmsenha.BackColor = Color.Silver;
            if (txtComfirmSenha.Text != txtSenha.Text)
            {
                errorProvider1.SetError(txtComfirmSenha, "As senhas nao estão iguais");
            }
            else
            {
                errorProvider1.SetError(txtComfirmSenha, "");
            }
        }

        private void Senha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
                txtSenha.PasswordChar = '*';
            }
            panel_senha.BackColor = Color.Black;
        }

        private void Senha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Senha";
                txtSenha.PasswordChar = vazio;
            }
            panel_senha.BackColor = Color.Silver;
        }

        private void Usuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
            }
            panel_usuario.BackColor = Color.Black;
        }

        private void Usuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
            }
            panel_usuario.BackColor = Color.Silver;
        }

        private void Bairro_Enter(object sender, EventArgs e)
        {
            if (txtBairro.Text == "Bairro")
            {
                txtBairro.Text = "";
            }
            panel_bairro.BackColor = Color.Black;
        }

        private void Bairro_Leave(object sender, EventArgs e)
        {
            if (txtBairro.Text == "")
            {
                txtBairro.Text = "Bairro";
            }
            panel_bairro.BackColor = Color.Silver;
        }

        private void Endereco_Enter(object sender, EventArgs e)
        {
            if (txtEndereco.Text == "Endereço")
            {
                txtEndereco.Text = "";
            }
            panel_endereco.BackColor = Color.Black;
        }

        private void Endereco_Leave(object sender, EventArgs e)
        {
            if(txtEndereco.Text == "")
            {
                txtEndereco.Text = "Endereço";
            }
            panel_endereco.BackColor = Color.Silver;
        }

        private void Nome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "Nome da Empresa")
            {
                txtNome.Text = "";
            }
            panel_nome.BackColor = Color.Black;
        }

        private void Nome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "Nome da Empresa";
            }
            panel_nome.BackColor = Color.Silver;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cout = 0;
            if (txtSenha.Text != txtComfirmSenha.Text)
            {
                errorProvider1.SetError(txtComfirmSenha, "As senhas nao estão iguais");
            }
            else
            {
                errorProvider1.SetError(txtComfirmSenha, "");
                cout++;
            }
            if (txtNome.Text == "Nome da Empresa")
            {
                errorProvider1.SetError(txtNome, "Obrigatorio");
            }
            else
            {
                errorProvider1.SetError(txtNome, "");
                cout++;
            }
            if (txtEndereco.Text == "Endereço")
            {
                errorProvider1.SetError(txtEndereco, "Obrigatorio");
            }
            else
            {
                errorProvider1.SetError(txtEndereco, "");
                cout++;
            }
            if (txtBairro.Text == "Bairro")
            {
                errorProvider1.SetError(txtBairro, "Obrigatorio");
            }
            else
            {
                errorProvider1.SetError(txtBairro, "");
                cout++;
            }
            if (txtUsuario.Text == "Usuario")
            {
                errorProvider1.SetError(txtUsuario, "Obrigatorio");
            }
            else
            {
                errorProvider1.SetError(txtUsuario, "");
                cout++;
            }
            if (txtTelefone.Text == "Telefone")
            {
                errorProvider1.SetError(txtTelefone, "Obrigatorio");
            }
            else
            {
                errorProvider1.SetError(txtTelefone, "");
                cout++;
            }
            if (txtNumero.Text == "Nº")
            {
                errorProvider1.SetError(txtNumero, "Obrigatorio");
            }
            else
            {
                errorProvider1.SetError(txtNumero, "");
                cout++;
            }
            if (txtCidade.Text == "Cidade")
            {
                errorProvider1.SetError(txtCidade, "Obrigatorio");
            }
            else
            {
                errorProvider1.SetError(txtCidade, "");
                cout++;
            }
            if (txtUF.Text == "UF")
            {
                errorProvider1.SetError(txtUF, "Obrigatorio");
            }
            else
            {
                errorProvider1.SetError(txtUF, "");
                cout++;
            }
            if (cout == 9)
            {
                string dinheiroo, debitoo, creditoo;
                if (chkDinheiro.Checked)
                {
                    dinheiroo = "sim";
                }
                else
                {
                    dinheiroo = "nao";
                }
                if (chkDebito.Checked)
                {
                    debitoo = "sim";
                }
                else
                {
                    debitoo = "nao";
                }
                if (chkCredito.Checked)
                {
                    creditoo = "sim";
                }
                else
                {
                    creditoo = "nao";
                }
                try
                {
                    var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://adsangelinabancodedados.uc.r.appspot.com/empresas/");
                    httpWebRequest.ContentType = "application/json";
                    httpWebRequest.Method = "POST";
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                    using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    {
                        string json = new JavaScriptSerializer().Serialize(new
                        {
                            usuario = txtUsuario.Text,
                            senha = txtSenha.Text,
                            nome = txtNome.Text,
                            numero = txtNumero.Text,
                            endereco = txtEndereco.Text,
                            bairro = txtBairro.Text,
                            telefone = txtTelefone.Text,
                            cidade = txtCidade.Text,
                            uf = txtUF.Text,
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
                catch
                {
                    MessageBox.Show("Erro ao cadastrar");
                }

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
