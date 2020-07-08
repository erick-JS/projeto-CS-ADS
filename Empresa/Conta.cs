using Newtonsoft.Json;
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

namespace Empresa
{
    public partial class Conta : Form
    {
        string segundao = " ", tercao = " ", quartao = " ", quintao = " ", sextao = " ", sabadoo = " ", domingoo = " ", feriadoo = " ";
        string a = " ", b = " ", c = " ", d = " ", re = " ", f = " ", g = " ", h = " ";
        String nome = "Fulano";
        String endereco = "Rua X";
        String bairro = "Vila Progresso";
        String numero = "234";
        String cidade = "Sorocaba";
        String uf = "SP";
        String telefone = "(11) 99999-9999";
        String usuario = "fulano123";

        public Conta()
        {
            InitializeComponent();

            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source = dados.db; Version=3;";
            ligacao.Open();
            string query = "SELECT * FROM login";
            SQLiteCommand data = new SQLiteCommand(query, ligacao);
            SQLiteDataReader rdr = data.ExecuteReader();

            while (rdr.Read())
            {
                nome = rdr.GetString(3);
                endereco = rdr.GetString(5);
                bairro = rdr.GetString(6);
                numero = rdr.GetString(4);
                cidade = rdr.GetString(8);
                uf = rdr.GetString(9);
                telefone = rdr.GetString(7);
                usuario = rdr.GetString(1);
            }
        }

        char vazio;

        //Método para alterar a aparência de cada textbox
        private void alterarAparencia(Panel panel, TextBox txt, string old_placeholder, string new_placeholder, Color cor)
        {
            if (txt.Text == old_placeholder)
            {
                txt.Text = new_placeholder;
            }

            panel.BackColor = cor;
        }

        private void btnSalvarDados_Click(object sender, EventArgs e)
        {
            int cont_valido = 0, i = 0;

            TextBox[] arrayDados = new TextBox[] { txtNome, txtEndereco, txtBairro, txtCidade,
            txtNumero, txtUF, txtUsuario, txtTelefone };

            string[] placeholder = { "Nome", "Endereço", "Bairro", "Cidade", "Nº", "UF", "Usuário", "Telefone" };

            while (i < arrayDados.Length)
            {
                if (arrayDados[i].Text == placeholder[i])
                {
                    erroDadosCadastrais.SetError(arrayDados[i], "Obrigatório");
                }
                else
                {
                    erroDadosCadastrais.SetError(arrayDados[i], "");
                    cont_valido++;
                }
                i++;
            }

            if(cont_valido == 8)
            {
                MessageBox.Show("Dados validados com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSalvarDados.Enabled = false;
                btnEditarDados.Enabled = true;

                string userv = " ", senhav = " ";

                SQLiteConnection ligacao = new SQLiteConnection();
                ligacao.ConnectionString = @"Data source = dados.db; Version=3;";
                ligacao.Open();
                string query0 = "SELECT * FROM login";
                SQLiteCommand datav = new SQLiteCommand(query0, ligacao);
                SQLiteDataReader rdrv = datav.ExecuteReader();

                while (rdrv.Read())
                {
                    userv = rdrv.GetString(1);
                    senhav = rdrv.GetString(2);
                }
                string quary1 = "UPDATE login SET usuario = '"+ txtUsuario.Text +"', nome ='" + txtNome.Text +"', numero ='" + txtNumero.Text + "', endereco ='" + txtEndereco.Text + "', bairro ='" + txtBairro.Text + "',telefone ='" + txtTelefone.Text + "',cidade ='" + txtCidade.Text + "',uf ='" + txtUF.Text + "'";
                SQLiteCommand up = new SQLiteCommand(quary1, ligacao);
                up.ExecuteNonQuery();
                string query = "SELECT * FROM login";
                SQLiteCommand data = new SQLiteCommand(query, ligacao);
                SQLiteDataReader rdr = data.ExecuteReader();

                string user = " ", senhaa = " ",nomee = " ", enderecoo = " ", bairroo = " ", numeroo = " ", cidadee = " ", uff = " ", telefonee = " ", dinheiroo = " ", creditoo = " ", debitoo = " ";

                while (rdr.Read())
                {
                    user = rdr.GetString(1);
                    senhaa = rdr.GetString(2);
                    nomee = rdr.GetString(3);
                    enderecoo = rdr.GetString(5);
                    bairroo = rdr.GetString(6);
                    numeroo = rdr.GetString(4);
                    cidadee = rdr.GetString(8);
                    uff = rdr.GetString(9);
                    telefonee = rdr.GetString(7);
                    dinheiroo = rdr.GetString(10);
                    creditoo = rdr.GetString(11);
                    debitoo = rdr.GetString(12);
                }
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://adsangelinabancodedados.uc.r.appspot.com/empresaget/");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "PUT";
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(new
                    {
                        usuario = user,
                        senha = senhaa,
                        nome = nomee,
                        numero = numeroo,
                        endereco = enderecoo,
                        bairro = bairroo,
                        telefone = telefonee,
                        cidade = cidadee,
                        uf = uff,
                        dinheiro = dinheiroo,
                        debito = debitoo,
                        credito = creditoo,
                        uv = userv,
                        sv = senhav,
                        hatendimentoi = a,
                        hatendimentof = b,
                        segunda = segundao,
                        quinta = quintao,
                        domingo = domingoo,
                        terca = tercao,
                        sexta = sextao,
                        quarta = quartao,
                        sabado = sabadoo,
                        fsemanaabres = c,
                        fsemanafechas = d,
                        fsemanaabred = re,
                        fsemanafechad = f,
                        feriado = feriadoo,
                        feriadoa = g,
                        feriadof = h
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

                i = 0;

                while (i < arrayDados.Length)
                {
                    arrayDados[i].Enabled = false;
                    i++;
                }
            }
        }

        private void Conta_Load(object sender, EventArgs e)
        {
            txtNome.Text = nome;
            txtEndereco.Text = endereco;
            txtBairro.Text = bairro;
            txtNumero.Text = numero;
            txtCidade.Text = cidade;
            txtUF.Text = uf;
            txtTelefone.Text = telefone;
            txtUsuario.Text = usuario;
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            alterarAparencia(panel_nome, txtNome, "Nome", "", Color.Black);
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            alterarAparencia(panel_nome, txtNome, "", "Nome", Color.Silver);
        }

        private void txtEndereco_Enter(object sender, EventArgs e)
        {
            alterarAparencia(panel_endereco, txtEndereco, "Endereço", "", Color.Black);
        }

        private void txtEndereco_Leave(object sender, EventArgs e)
        {
            alterarAparencia(panel_endereco, txtEndereco, "", "Endereço", Color.Silver);
        }

        private void txtBairro_Enter(object sender, EventArgs e)
        {
            alterarAparencia(panel_bairro, txtBairro, "Bairro", "", Color.Black);
        }

        private void txtBairro_Leave(object sender, EventArgs e)
        {
            alterarAparencia(panel_bairro, txtBairro, "", "Bairro", Color.Silver);
        }

        private void txtNumero_Enter(object sender, EventArgs e)
        {
            alterarAparencia(panel_number, txtNumero, "Nº", "", Color.Black);
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            alterarAparencia(panel_number, txtNumero, "", "Nº", Color.Silver);
        }

        private void txtCidade_Enter(object sender, EventArgs e)
        {
            alterarAparencia(panel_cidade, txtCidade, "Cidade", "", Color.Black);
        }

        private void txtCidade_Leave(object sender, EventArgs e)
        {
            alterarAparencia(panel_cidade, txtCidade, "", "Cidade", Color.Silver); ;
        }

        private void txtUF_Enter(object sender, EventArgs e)
        {
            alterarAparencia(panel_uf, txtUF, "UF", "", Color.Black);
        }

        private void txtUF_Leave(object sender, EventArgs e)
        {
            alterarAparencia(panel_uf, txtUF, "", "UF", Color.Silver);
        }

        private void txtTelefone_Enter(object sender, EventArgs e)
        {
            alterarAparencia(panel_telefone, txtTelefone, "Telefone", "", Color.Black);
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            alterarAparencia(panel_telefone, txtTelefone, "", "Telefone", Color.Silver);

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
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            alterarAparencia(panel_usuario, txtUsuario, "Usuário", "", Color.Black);
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            alterarAparencia(panel_usuario, txtUsuario, "", "Usuário", Color.Silver);
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

        private void txtSenhaAtual_Enter(object sender, EventArgs e)
        {
            alterarAparencia(panel_senhaatual, txtSenhaAtual, "Senha atual", "", Color.Black);
            txtSenhaAtual.PasswordChar = '*';
        }

        private void txtSenhaAtual_Leave(object sender, EventArgs e)
        {
            alterarAparencia(panel_senhaatual, txtSenhaAtual, "", "Senha atual", Color.Silver);

            if (txtSenhaAtual.Text == "Senha atual")
            {
                txtSenhaAtual.PasswordChar = vazio;
            }
        }

        private void txtNovaSenha_Enter(object sender, EventArgs e)
        {
            alterarAparencia(panel_novasenha, txtNovaSenha, "Nova senha", "", Color.Black);
            txtNovaSenha.PasswordChar = '*';
        }

        private void txtNovaSenha_Leave(object sender, EventArgs e)
        {
            alterarAparencia(panel_novasenha, txtNovaSenha, "", "Nova senha", Color.Silver);

            if (txtNovaSenha.Text == "Nova senha")
            {
                txtNovaSenha.PasswordChar = vazio;
            }
        }

        private void txtConfSenha_Enter(object sender, EventArgs e)
        {
            alterarAparencia(panel_confirmsenha, txtConfSenha, "Confirmar senha", "", Color.Black);
            txtConfSenha.PasswordChar = '*';
        }

        private void txtConfSenha_Leave(object sender, EventArgs e)
        {
            alterarAparencia(panel_confirmsenha, txtConfSenha, "", "Confirmar senha", Color.Silver);

            if (txtConfSenha.Text == "Confirmar senha")
            {
                txtConfSenha.PasswordChar = vazio;
            }
        }
        private void btnEditarDados_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtNumero.Enabled = true;
            txtCidade.Enabled = true;
            txtUF.Enabled = true;
            txtTelefone.Enabled= true;
            txtUsuario.Enabled = true;

            btnSalvarDados.Enabled = true;
            btnEditarDados.Enabled = false;
        }

        private void btnEditarSenha_Click(object sender, EventArgs e)
        {
            txtSenhaAtual.Enabled = true;
            txtNovaSenha.Enabled = true;
            txtConfSenha.Enabled = true;

            btnEditarSenha.Enabled = false;
            btnSalvarSenha.Enabled = true;
        }

        private void btnSalvarSenha_Click(object sender, EventArgs e)
        {
            int cont_valido = 0, i = 0;

            TextBox[] arraySenha = new TextBox[] { txtSenhaAtual, txtNovaSenha, txtConfSenha };

            string[] placeholder = { "Senha atual", "Nova senha", "Confirmar senha" };

            while (i < arraySenha.Length)
            {
                if (arraySenha[i].Text == placeholder[i])
                {
                    erroSenha.SetError(arraySenha[i], "Obrigatório");
                }
                else
                {
                    erroSenha.SetError(arraySenha[i], "");
                    cont_valido++;
                }
                i++;
            }

            if(cont_valido == 3)
            {
                if(arraySenha[1].Text == arraySenha[2].Text)
                {
                    btnEditarSenha.Enabled = true;
                    btnSalvarSenha.Enabled = false;

                    string userv = " ", senhav = " ";

                    SQLiteConnection ligacao = new SQLiteConnection();
                    ligacao.ConnectionString = @"Data source = dados.db; Version=3;";
                    ligacao.Open();
                    string query0 = "SELECT * FROM login";
                    SQLiteCommand datav = new SQLiteCommand(query0, ligacao);
                    SQLiteDataReader rdrv = datav.ExecuteReader();
                    while (rdrv.Read())
                    {
                        userv = rdrv.GetString(1);
                        senhav = rdrv.GetString(2);
                    }

                    if (txtSenhaAtual.Text == senhav)
                    {
                        string quary1 = "UPDATE login SET senha ='" + txtConfSenha.Text + "'";
                        SQLiteCommand up = new SQLiteCommand(quary1, ligacao);
                        up.ExecuteNonQuery();
                        string query = "SELECT * FROM login";
                        SQLiteCommand data = new SQLiteCommand(query, ligacao);
                        SQLiteDataReader rdr = data.ExecuteReader();

                        string user = " ", senhaa = " ", nomee = " ", enderecoo = " ", bairroo = " ", numeroo = " ", cidadee = " ", uff = " ", telefonee = " ", dinheiroo = " ", creditoo = " ", debitoo = " ";
                        

                        while (rdr.Read())
                        {
                            user = rdr.GetString(1);
                            senhaa = rdr.GetString(2);
                            nomee = rdr.GetString(3);
                            enderecoo = rdr.GetString(5);
                            bairroo = rdr.GetString(6);
                            numeroo = rdr.GetString(4);
                            cidadee = rdr.GetString(8);
                            uff = rdr.GetString(9);
                            telefonee = rdr.GetString(7);
                            dinheiroo = rdr.GetString(10);
                            creditoo = rdr.GetString(11);
                            debitoo = rdr.GetString(12);
                            a = rdr.GetString(22);
                            b = rdr.GetString(23);
                            segundao = rdr.GetString(15);
                            quintao = rdr.GetString(16);
                            domingoo = rdr.GetString(17);
                            tercao = rdr.GetString(18);
                            sextao = rdr.GetString(10);
                            quartao = rdr.GetString(20);
                            sabadoo = rdr.GetString(21);
                            c = rdr.GetString(24);
                            d = rdr.GetString(25);
                            re = rdr.GetString(23);
                            f = rdr.GetString(24);
                            feriadoo = rdr.GetString(25);
                            g = rdr.GetString(26);
                            h = rdr.GetString(27);
                        }
                        MessageBox.Show("Dados validados com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://adsangelinabancodedados.uc.r.appspot.com/empresaget/");
                        httpWebRequest.ContentType = "application/json";
                        httpWebRequest.Method = "PUT";
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                        {
                            string json = new JavaScriptSerializer().Serialize(new
                            {
                                usuario = user,
                                senha = senhaa,
                                nome = nomee,
                                numero = numeroo,
                                endereco = enderecoo,
                                bairro = bairroo,
                                telefone = telefonee,
                                cidade = cidadee,
                                uf = uff,
                                dinheiro = dinheiroo,
                                debito = debitoo,
                                credito = creditoo,
                                uv = userv,
                                sv = senhav,
                                hatendimentoi = a,
                                hatendimentof = b,
                                segunda = segundao,
                                quinta = quintao,
                                domingo = domingoo,
                                terca = tercao,
                                sexta = sextao,
                                quarta = quartao,
                                sabado = sabadoo,
                                fsemanaabres = c,
                                fsemanafechas = d,
                                fsemanaabred = re,
                                fsemanafechad = f,
                                feriado = feriadoo,
                                feriadoa = g,
                                feriadof = h
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
                    }
                    else
                    {
                        MessageBox.Show("Senha atual esta errada");
                    }

                    i = 0;
                    while (i < arraySenha.Length)
                    {
                        arraySenha[i].Enabled = false;
                        arraySenha[i].Text = "";
                        i++;
                    }
                }
                else
                {
                    erroSenha.SetError(arraySenha[2], "As duas senhas não são iguais!");
                }
            }
        }
    }
}
