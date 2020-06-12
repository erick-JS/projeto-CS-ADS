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
using System.Runtime.InteropServices;


namespace Empresa
{
    public partial class Cadastro : Form
    {
        char vazio;
        public Cadastro()
        {
            InitializeComponent();
        }

        private void abrirLogin()
        {
            this.Hide();
            Login formLogin = new Login();
            formLogin.ShowDialog();
        }

        //Método para alterar a aparência de cada textbox
        private void alterarAparencia(Panel panel, TextBox txt, string old_placeholder, string new_placeholder, Color cor)
        {
            if (txt.Text == old_placeholder)
            {
                txt.Text = new_placeholder;
            }

            panel.BackColor = cor;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Os dados do usuário não serão cadastrados. Deseja realmente sair?",
                "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if(msg == DialogResult.Yes)
            {
                abrirLogin();
            }
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
            alterarAparencia(panel_cidade, txtCidade, "Cidade", "", Color.Black);
        }

        private void Cidade_Leave(object sender, EventArgs e)
        {
            alterarAparencia(panel_cidade, txtCidade, "", "Cidade", Color.Silver);
        }

        private void number_Enter(object sender, EventArgs e)
        {
            alterarAparencia(panel_number, txtNumero, "Nº", "", Color.Black);
        }

        private void number_Leave(object sender, EventArgs e)
        {
            alterarAparencia(panel_number, txtNumero, "", "Nº", Color.Silver);
        }

        private void Telefone_Enter(object sender, EventArgs e)
        {
            alterarAparencia(panel_telefone, txtTelefone, "Telefone", "", Color.Black);
            /*if (txtTelefone.Text == "Telefone")
            {
                txtTelefone.Text = "";
            }
            panel_telefone.BackColor = Color.Black;*/
        }

        private void Telefone_Leave(object sender, EventArgs e)
        {
            alterarAparencia(panel_number, txtTelefone, "", "Telefone", Color.Silver);
            if (txtTelefone.Text.Length >= 10)
            {
                if (txtTelefone.Text.Substring(0, 1) != "(")
                {
                    String content = txtTelefone.Text;
                    txtTelefone.Text = "(" + content.Substring(0, 2) + ") " + content.Substring(2, 6) + "-" + content.Substring(6);
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
            }
            panel_telefone.BackColor = Color.Silver;*/
        }

        private void ComfirmSenha_Enter(object sender, EventArgs e)
        {
            alterarAparencia(panel_comfirmsenha, txtConfirmSenha, "Confirmar Senha", "", Color.Black);
            txtConfirmSenha.PasswordChar = '*';
        }

        private void ComfirmSenha_Leave(object sender, EventArgs e)
        {
            alterarAparencia(panel_comfirmsenha, txtConfirmSenha, "", "Confirmar Senha", Color.Silver);
            
            if(txtConfirmSenha.Text == "Confirmar Senha")
            {
                txtConfirmSenha.PasswordChar = vazio;
            }

            /*if (txtComfirmSenha.Text == "")
            {
                txtComfirmSenha.Text = "Confirmar Senha";
                txtComfirmSenha.PasswordChar = vazio;
            }
            panel_comfirmsenha.BackColor = Color.Silver;*/
            if (txtConfirmSenha.Text != txtSenha.Text)
            {
                erroP.SetError(txtConfirmSenha, "As senhas nao estão iguais");
            }
            else
            {
                erroP.SetError(txtConfirmSenha, "");
            }
        }

        private void Senha_Enter(object sender, EventArgs e)
        {
            alterarAparencia(panel_senha, txtSenha, "Senha", "", Color.Black);
            txtSenha.PasswordChar = '*';
        }

        private void Senha_Leave(object sender, EventArgs e)
        {
            alterarAparencia(panel_senha, txtSenha, "", "Senha", Color.Silver);
            if (txtSenha.Text == "Senha")
            {
                txtSenha.PasswordChar = vazio;
            }
        }

        private void Usuario_Enter(object sender, EventArgs e)
        {
            alterarAparencia(panel_usuario, txtUsuario, "Usuário", "", Color.Black);
        }

        private void Usuario_Leave(object sender, EventArgs e)
        {
            alterarAparencia(panel_usuario, txtUsuario, "", "Usuário", Color.Silver);
        }

        private void Bairro_Enter(object sender, EventArgs e)
        {
            alterarAparencia(panel_bairro, txtBairro, "Bairro", "", Color.Black);
        }

        private void Bairro_Leave(object sender, EventArgs e)
        {
            alterarAparencia(panel_bairro, txtBairro, "", "Bairro", Color.Silver);
        }

        private void Endereco_Enter(object sender, EventArgs e)
        {
            alterarAparencia(panel_endereco, txtEndereco, "Endereço", "", Color.Black);
        }

        private void Endereco_Leave(object sender, EventArgs e)
        {
            alterarAparencia(panel_endereco, txtEndereco, "", "Endereço", Color.Silver);
        }

        private void Nome_Enter(object sender, EventArgs e)
        {
<<<<<<< HEAD
            alterarAparencia(panel_nome, txtNome, "Nome", "", Color.Black);
=======
            if (Nome.Text == "Nome da Empresa")
            {
                Nome.Text = "";
            }
            panel_nome.BackColor = Color.Black;
>>>>>>> 83d6ebc29bd46b46f094f39f911168cdee21d2f7
        }

        private void Nome_Leave(object sender, EventArgs e)
        {
<<<<<<< HEAD
            alterarAparencia(panel_nome, txtNome, "", "Nome", Color.Silver);
=======
            if (Nome.Text == "")
            {
                Nome.Text = "Nome da Empresa";
            }
            panel_nome.BackColor = Color.Silver;
>>>>>>> 83d6ebc29bd46b46f094f39f911168cdee21d2f7
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int cont_valido = 0, i = 0;

            TextBox[] array = new TextBox[] { txtNome, txtEndereco, txtBairro, txtCidade, 
            txtNumero, txtUF, txtUsuario, txtTelefone };

            string[] placeholder = { "Nome", "Endereço", "Bairro", "Cidade", "Nº", "UF", "Usuário", "Telefone" };

            while(i < array.Length)
            {
                if(array[i].Text == placeholder[i])
                {
                    erroP.SetError(array[i], "Obrigatório");
                }
                else
                {
                    erroP.SetError(array[i], "");
                    cont_valido++;
                }                
                i++;
            }

            if (txtSenha.Text != txtConfirmSenha.Text)
            {
                erroP.SetError(txtConfirmSenha, "As senhas nao estão iguais");
            }
            else
            {
                erroP.SetError(txtConfirmSenha, "");
                cont_valido++;
            }
<<<<<<< HEAD

            if(chkCredito.Checked == false && chkDebito.Checked == false &&
                chkDinheiro.Checked == false)
=======
            if (Nome.Text == "Nome da Empresa")
>>>>>>> 83d6ebc29bd46b46f094f39f911168cdee21d2f7
            {
                erroP.SetError(gpxFormaPagamento, "Selecione ao menos uma forma de pagamento");
            }
            else
            {
                erroP.SetError(gpxFormaPagamento, "");
            }
            /*if (txtNome.Text == "Nome")
            {
                erroP.SetError(txtNome, "Obrigatorio");
            }
            else
            {
                erroP.SetError(txtNome, "");
                cout++;
            }
            if (txtEndereco.Text == "Endereço")
            {
                erroP.SetError(txtEndereco, "Obrigatorio");
            }
            else
            {
                erroP.SetError(txtEndereco, "");
                cout++;
            }
            if (txtBairro.Text == "Bairro")
            {
                erroP.SetError(txtBairro, "Obrigatorio");
            }
            else
            {
                erroP.SetError(txtBairro, "");
                cout++;
            }
            if (txtUsuario.Text == "Usuário")
            {
                erroP.SetError(txtUsuario, "Obrigatorio");
            }
            else
            {
                erroP.SetError(txtUsuario, "");
                cout++;
            }
            if (txtTelefone.Text == "Telefone")
            {
                erroP.SetError(txtTelefone, "Obrigatorio");
            }
            else
            {
                erroP.SetError(txtTelefone, "");
                cout++;
            }
            if (txtNumero.Text == "Nº")
            {
                erroP.SetError(txtNumero, "Obrigatorio");
            }
            else
            {
                erroP.SetError(txtNumero, "");
                cout++;
            }
            if (txtCidade.Text == "Cidade")
            {
                erroP.SetError(txtCidade, "Obrigatorio");
            }
            else
            {
                erroP.SetError(txtCidade, "");
                cout++;
            }
            if (txtUF.Text == "UF")
            {
                erroP.SetError(txtUF, "Obrigatorio");
            }
            else
            {
                erroP.SetError(txtUF, "");
                cout++;
            }*/
            if (cont_valido == 9)
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
<<<<<<< HEAD
                        usuario = txtUsuario.Text,
	                    senha = txtSenha.Text,
	                    nome = txtNome.Text,
	                    numero = txtNumero.Text,
                        endereco = txtEndereco.Text,
	                    bairro = txtBairro.Text,
                        telefone = txtTelefone.Text,
	                    cidade = txtCidade.Text,
	                    uf = txtUF.Text
=======
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
>>>>>>> 83d6ebc29bd46b46f094f39f911168cdee21d2f7
                    });
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                Hide();
                Login formLogin = new Login();
                formLogin.ShowDialog();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            base.OnClosing(e);
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)8)
            {
                e.Handled = false;
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
