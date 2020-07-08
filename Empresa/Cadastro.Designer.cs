namespace Empresa
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel_nome = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panel_endereco = new System.Windows.Forms.Panel();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.panel_bairro = new System.Windows.Forms.Panel();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.panel_cidade = new System.Windows.Forms.Panel();
            this.panel_number = new System.Windows.Forms.Panel();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.panel_telefone = new System.Windows.Forms.Panel();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.panel_senha = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.panel_usuario = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panel_comfirmsenha = new System.Windows.Forms.Panel();
            this.txtComfirmSenha = new System.Windows.Forms.TextBox();
            this.gpxFormaPagamento = new System.Windows.Forms.GroupBox();
            this.chkDinheiro = new System.Windows.Forms.CheckBox();
            this.chkCredito = new System.Windows.Forms.CheckBox();
            this.chkDebito = new System.Windows.Forms.CheckBox();
            this.panel_uf = new System.Windows.Forms.Panel();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.gpxFormaPagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 38);
            this.panel2.TabIndex = 13;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackgroundImage = global::Empresa.Properties.Resources.icons8_fechar_janela_32;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(753, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 37);
            this.button3.TabIndex = 15;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackgroundImage = global::Empresa.Properties.Resources.icons8_minimizar_janela_32;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(647, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 37);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackgroundImage = global::Empresa.Properties.Resources.icons8_maximize_button_32;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(700, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 37);
            this.button4.TabIndex = 14;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(612, 433);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(127, 46);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(51, 433);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 46);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel_nome
            // 
            this.panel_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_nome.BackColor = System.Drawing.Color.Silver;
            this.panel_nome.Location = new System.Drawing.Point(52, 136);
            this.panel_nome.Name = "panel_nome";
            this.panel_nome.Size = new System.Drawing.Size(687, 3);
            this.panel_nome.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.BackColor = System.Drawing.Color.GhostWhite;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Silver;
            this.txtNome.Location = new System.Drawing.Point(52, 109);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(687, 31);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "Nome da Empresa";
            this.txtNome.Enter += new System.EventHandler(this.Nome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.Nome_Leave);
            // 
            // panel_endereco
            // 
            this.panel_endereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_endereco.BackColor = System.Drawing.Color.Silver;
            this.panel_endereco.Location = new System.Drawing.Point(52, 185);
            this.panel_endereco.Name = "panel_endereco";
            this.panel_endereco.Size = new System.Drawing.Size(450, 3);
            this.panel_endereco.TabIndex = 10;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEndereco.BackColor = System.Drawing.Color.GhostWhite;
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.Color.Silver;
            this.txtEndereco.Location = new System.Drawing.Point(52, 158);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(450, 31);
            this.txtEndereco.TabIndex = 1;
            this.txtEndereco.Text = "Endereço";
            this.txtEndereco.Enter += new System.EventHandler(this.Endereco_Enter);
            this.txtEndereco.Leave += new System.EventHandler(this.Endereco_Leave);
            // 
            // panel_bairro
            // 
            this.panel_bairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_bairro.BackColor = System.Drawing.Color.Silver;
            this.panel_bairro.Location = new System.Drawing.Point(508, 185);
            this.panel_bairro.Name = "panel_bairro";
            this.panel_bairro.Size = new System.Drawing.Size(232, 3);
            this.panel_bairro.TabIndex = 12;
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBairro.BackColor = System.Drawing.Color.GhostWhite;
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.ForeColor = System.Drawing.Color.Silver;
            this.txtBairro.Location = new System.Drawing.Point(508, 158);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(232, 31);
            this.txtBairro.TabIndex = 2;
            this.txtBairro.Text = "Bairro";
            this.txtBairro.Enter += new System.EventHandler(this.Bairro_Enter);
            this.txtBairro.Leave += new System.EventHandler(this.Bairro_Leave);
            // 
            // panel_cidade
            // 
            this.panel_cidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_cidade.BackColor = System.Drawing.Color.Silver;
            this.panel_cidade.Location = new System.Drawing.Point(52, 235);
            this.panel_cidade.Name = "panel_cidade";
            this.panel_cidade.Size = new System.Drawing.Size(380, 3);
            this.panel_cidade.TabIndex = 18;
            // 
            // panel_number
            // 
            this.panel_number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_number.BackColor = System.Drawing.Color.Silver;
            this.panel_number.Location = new System.Drawing.Point(438, 235);
            this.panel_number.Name = "panel_number";
            this.panel_number.Size = new System.Drawing.Size(152, 3);
            this.panel_number.TabIndex = 16;
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCidade.BackColor = System.Drawing.Color.GhostWhite;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.ForeColor = System.Drawing.Color.Silver;
            this.txtCidade.Location = new System.Drawing.Point(52, 207);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(380, 31);
            this.txtCidade.TabIndex = 3;
            this.txtCidade.Text = "Cidade";
            this.txtCidade.Enter += new System.EventHandler(this.Cidade_Enter);
            this.txtCidade.Leave += new System.EventHandler(this.Cidade_Leave);
            // 
            // panel_telefone
            // 
            this.panel_telefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_telefone.BackColor = System.Drawing.Color.Silver;
            this.panel_telefone.Location = new System.Drawing.Point(51, 282);
            this.panel_telefone.Name = "panel_telefone";
            this.panel_telefone.Size = new System.Drawing.Size(308, 3);
            this.panel_telefone.TabIndex = 14;
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumero.BackColor = System.Drawing.Color.GhostWhite;
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.Color.Silver;
            this.txtNumero.Location = new System.Drawing.Point(438, 207);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(153, 31);
            this.txtNumero.TabIndex = 4;
            this.txtNumero.Text = "Nº";
            this.txtNumero.Enter += new System.EventHandler(this.number_Enter);
            this.txtNumero.Leave += new System.EventHandler(this.number_Leave);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefone.BackColor = System.Drawing.Color.GhostWhite;
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.Color.Silver;
            this.txtTelefone.HideSelection = false;
            this.txtTelefone.Location = new System.Drawing.Point(51, 254);
            this.txtTelefone.MaxLength = 11;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(308, 31);
            this.txtTelefone.TabIndex = 6;
            this.txtTelefone.Text = "Telefone";
            this.txtTelefone.Enter += new System.EventHandler(this.Telefone_Enter);
            this.txtTelefone.Leave += new System.EventHandler(this.Telefone_Leave);
            // 
            // panel_senha
            // 
            this.panel_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_senha.BackColor = System.Drawing.Color.Silver;
            this.panel_senha.Location = new System.Drawing.Point(52, 332);
            this.panel_senha.Name = "panel_senha";
            this.panel_senha.Size = new System.Drawing.Size(299, 3);
            this.panel_senha.TabIndex = 22;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.BackColor = System.Drawing.Color.GhostWhite;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.Silver;
            this.txtSenha.Location = new System.Drawing.Point(52, 305);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(300, 31);
            this.txtSenha.TabIndex = 8;
            this.txtSenha.Text = "Senha";
            this.txtSenha.Enter += new System.EventHandler(this.Senha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.Senha_Leave);
            // 
            // panel_usuario
            // 
            this.panel_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_usuario.BackColor = System.Drawing.Color.Silver;
            this.panel_usuario.Location = new System.Drawing.Point(365, 282);
            this.panel_usuario.Name = "panel_usuario";
            this.panel_usuario.Size = new System.Drawing.Size(374, 3);
            this.panel_usuario.TabIndex = 20;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.BackColor = System.Drawing.Color.GhostWhite;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Silver;
            this.txtUsuario.Location = new System.Drawing.Point(365, 254);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(374, 31);
            this.txtUsuario.TabIndex = 7;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.Usuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.Usuario_Leave);
            // 
            // panel_comfirmsenha
            // 
            this.panel_comfirmsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_comfirmsenha.BackColor = System.Drawing.Color.Silver;
            this.panel_comfirmsenha.Location = new System.Drawing.Point(358, 333);
            this.panel_comfirmsenha.Name = "panel_comfirmsenha";
            this.panel_comfirmsenha.Size = new System.Drawing.Size(380, 3);
            this.panel_comfirmsenha.TabIndex = 24;
            // 
            // txtComfirmSenha
            // 
            this.txtComfirmSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComfirmSenha.BackColor = System.Drawing.Color.GhostWhite;
            this.txtComfirmSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComfirmSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComfirmSenha.ForeColor = System.Drawing.Color.Silver;
            this.txtComfirmSenha.Location = new System.Drawing.Point(358, 306);
            this.txtComfirmSenha.Name = "txtComfirmSenha";
            this.txtComfirmSenha.Size = new System.Drawing.Size(381, 31);
            this.txtComfirmSenha.TabIndex = 9;
            this.txtComfirmSenha.Text = "Confirmar Senha";
            this.txtComfirmSenha.Enter += new System.EventHandler(this.ComfirmSenha_Enter);
            this.txtComfirmSenha.Leave += new System.EventHandler(this.ComfirmSenha_Leave);
            // 
            // gpxFormaPagamento
            // 
            this.gpxFormaPagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpxFormaPagamento.Controls.Add(this.chkDinheiro);
            this.gpxFormaPagamento.Controls.Add(this.chkCredito);
            this.gpxFormaPagamento.Controls.Add(this.chkDebito);
            this.gpxFormaPagamento.Location = new System.Drawing.Point(51, 344);
            this.gpxFormaPagamento.Name = "gpxFormaPagamento";
            this.gpxFormaPagamento.Size = new System.Drawing.Size(299, 82);
            this.gpxFormaPagamento.TabIndex = 10;
            this.gpxFormaPagamento.TabStop = false;
            this.gpxFormaPagamento.Text = "Aceita";
            // 
            // chkDinheiro
            // 
            this.chkDinheiro.AutoSize = true;
            this.chkDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDinheiro.Location = new System.Drawing.Point(193, 33);
            this.chkDinheiro.Name = "chkDinheiro";
            this.chkDinheiro.Size = new System.Drawing.Size(100, 28);
            this.chkDinheiro.TabIndex = 2;
            this.chkDinheiro.Text = "Dinheiro";
            this.chkDinheiro.UseVisualStyleBackColor = true;
            // 
            // chkCredito
            // 
            this.chkCredito.AutoSize = true;
            this.chkCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCredito.Location = new System.Drawing.Point(98, 33);
            this.chkCredito.Name = "chkCredito";
            this.chkCredito.Size = new System.Drawing.Size(89, 28);
            this.chkCredito.TabIndex = 1;
            this.chkCredito.Text = "Credito";
            this.chkCredito.UseVisualStyleBackColor = true;
            // 
            // chkDebito
            // 
            this.chkDebito.AutoSize = true;
            this.chkDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDebito.Location = new System.Drawing.Point(9, 33);
            this.chkDebito.Name = "chkDebito";
            this.chkDebito.Size = new System.Drawing.Size(83, 28);
            this.chkDebito.TabIndex = 0;
            this.chkDebito.Text = "Debito";
            this.chkDebito.UseVisualStyleBackColor = true;
            // 
            // panel_uf
            // 
            this.panel_uf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_uf.BackColor = System.Drawing.Color.Silver;
            this.panel_uf.Location = new System.Drawing.Point(596, 235);
            this.panel_uf.Name = "panel_uf";
            this.panel_uf.Size = new System.Drawing.Size(143, 3);
            this.panel_uf.TabIndex = 27;
            // 
            // txtUF
            // 
            this.txtUF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUF.AutoCompleteCustomSource.AddRange(new string[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO",
            "DF"});
            this.txtUF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUF.BackColor = System.Drawing.Color.GhostWhite;
            this.txtUF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUF.ForeColor = System.Drawing.Color.Silver;
            this.txtUF.Location = new System.Drawing.Point(596, 206);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(144, 31);
            this.txtUF.TabIndex = 5;
            this.txtUF.Text = "UF";
            this.txtUF.Enter += new System.EventHandler(this.Uf_Enter);
            this.txtUF.Leave += new System.EventHandler(this.Uf_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 10);
            this.panel1.TabIndex = 28;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_uf);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.gpxFormaPagamento);
            this.Controls.Add(this.panel_comfirmsenha);
            this.Controls.Add(this.txtComfirmSenha);
            this.Controls.Add(this.panel_senha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.panel_usuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.panel_cidade);
            this.Controls.Add(this.panel_number);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.panel_telefone);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.panel_bairro);
            this.Controls.Add(this.panel_endereco);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.panel_nome);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Cadastro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.gpxFormaPagamento.ResumeLayout(false);
            this.gpxFormaPagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel_nome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel panel_endereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Panel panel_bairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Panel panel_cidade;
        private System.Windows.Forms.Panel panel_number;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Panel panel_telefone;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Panel panel_senha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Panel panel_usuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel panel_comfirmsenha;
        private System.Windows.Forms.TextBox txtComfirmSenha;
        private System.Windows.Forms.GroupBox gpxFormaPagamento;
        private System.Windows.Forms.Panel panel_uf;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.CheckBox chkDinheiro;
        private System.Windows.Forms.CheckBox chkCredito;
        private System.Windows.Forms.CheckBox chkDebito;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
    }
}