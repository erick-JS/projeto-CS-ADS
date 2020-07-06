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

namespace Cliente
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
            if (txtUf.Text == "UF")
            {
                txtUf.Text = "";
            }
            panel_uf.BackColor = Color.Black;
        }

        private void Uf_Leave(object sender, EventArgs e)
        {
            if (txtUf.Text == "")
            {
                txtUf.Text = "UF";
            }
            panel_uf.BackColor = Color.Silver;
            txtUf.Text = txtUf.Text.ToUpper();
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
            panel_telefone.BackColor = Color.Silver;
        }

        private void ComfirmSenha_Enter(object sender, EventArgs e)
        {
            if (txtConfirmSenha.Text == "Confirmar Senha")
            {
                txtConfirmSenha.Text = "";
                txtConfirmSenha.PasswordChar = '*';
            }
            panel_comfirmsenha.BackColor = Color.Black;
        }

        private void ComfirmSenha_Leave(object sender, EventArgs e)
        {
            if (txtConfirmSenha.Text == "")
            {
                txtConfirmSenha.Text = "Confirmar Senha";
                txtConfirmSenha.PasswordChar = vazio;
            }
            panel_comfirmsenha.BackColor = Color.Silver;
            if (txtConfirmSenha.Text != txtSenha.Text)
            {
                errorProvider1.SetError(txtConfirmSenha, "As senhas nao estão iguais");
            }
            else
            {
                errorProvider1.SetError(txtConfirmSenha, "");
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
            if (txtNome.Text == "Nome")
            {
                txtNome.Text = "";
            }
            panel_nome.BackColor = Color.Black;
        }

        private void Nome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "Nome";
            }
            panel_nome.BackColor = Color.Silver;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cout = 0;
            if (txtSenha.Text != txtConfirmSenha.Text)
            {
                errorProvider1.SetError(txtConfirmSenha,"As senhas nao estão iguais");
            }
            else
            {
                errorProvider1.SetError(txtConfirmSenha,"");
                cout++;
            }
            if (txtNome.Text == "Nome")
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
            if (txtUf.Text == "UF")
            {
                errorProvider1.SetError(txtUf, "Obrigatorio");
            }
            else
            {
                errorProvider1.SetError(txtUf, "");
                cout++;
            }

            if (cout == 9)
            {
                try
                {
                    var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://adsangelinabancodedados.uc.r.appspot.com/clientes/");
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
                            uf = txtUf.Text,
                        });
                        streamWriter.Write(json);
                        streamWriter.Flush();
                        streamWriter.Close();

                        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                        Hide();
                        Login newForm2 = new Login();
                        newForm2.ShowDialog();
                    }
                }
                catch
                {
                    MessageBox.Show("Usuario ja existe");
                }
            }
        }

    }
}

