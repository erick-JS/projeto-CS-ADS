﻿using System;
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
    public partial class Conta : Form
    {
        public Conta()
        {
            InitializeComponent();
        }

        char vazio;

        String nome = "Fulano";
        String endereco = "Rua X";
        String bairro = "Vila Progresso";
        String numero = "234";
        String cidade = "Sorocaba";
        String uf = "SP";
        String telefone = "(11) 99999-9999";
        String usuario = "fulano123";

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
                    MessageBox.Show("Dados validados com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnEditarSenha.Enabled = true;
                    btnSalvarSenha.Enabled = false;

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