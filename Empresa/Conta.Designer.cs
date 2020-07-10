namespace Empresa
{
    partial class Conta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDadosCadastro = new System.Windows.Forms.TabControl();
            this.tabAlteraConta = new System.Windows.Forms.TabPage();
            this.btnEditarDados = new System.Windows.Forms.Button();
            this.btnSalvarDados = new System.Windows.Forms.Button();
            this.panel_usuario = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panel_uf = new System.Windows.Forms.Panel();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.panel_cidade = new System.Windows.Forms.Panel();
            this.panel_number = new System.Windows.Forms.Panel();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.panel_telefone = new System.Windows.Forms.Panel();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.panel_bairro = new System.Windows.Forms.Panel();
            this.panel_endereco = new System.Windows.Forms.Panel();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.panel_nome = new System.Windows.Forms.Panel();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tabAlteraSenha = new System.Windows.Forms.TabPage();
            this.btnEditarSenha = new System.Windows.Forms.Button();
            this.btnSalvarSenha = new System.Windows.Forms.Button();
            this.panel_confirmsenha = new System.Windows.Forms.Panel();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.panel_novasenha = new System.Windows.Forms.Panel();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.panel_senhaatual = new System.Windows.Forms.Panel();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.erroDadosCadastrais = new System.Windows.Forms.ErrorProvider(this.components);
            this.erroSenha = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.tbDadosCadastro.SuspendLayout();
            this.tabAlteraConta.SuspendLayout();
            this.tabAlteraSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroDadosCadastrais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 58);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Minha Conta";
            // 
            // tbDadosCadastro
            // 
            this.tbDadosCadastro.Controls.Add(this.tabAlteraConta);
            this.tbDadosCadastro.Controls.Add(this.tabAlteraSenha);
            this.tbDadosCadastro.Location = new System.Drawing.Point(66, 63);
            this.tbDadosCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.tbDadosCadastro.Name = "tbDadosCadastro";
            this.tbDadosCadastro.SelectedIndex = 0;
            this.tbDadosCadastro.Size = new System.Drawing.Size(547, 404);
            this.tbDadosCadastro.TabIndex = 0;
            // 
            // tabAlteraConta
            // 
            this.tabAlteraConta.Controls.Add(this.btnEditarDados);
            this.tabAlteraConta.Controls.Add(this.btnSalvarDados);
            this.tabAlteraConta.Controls.Add(this.panel_usuario);
            this.tabAlteraConta.Controls.Add(this.txtUsuario);
            this.tabAlteraConta.Controls.Add(this.panel_uf);
            this.tabAlteraConta.Controls.Add(this.txtUF);
            this.tabAlteraConta.Controls.Add(this.panel_cidade);
            this.tabAlteraConta.Controls.Add(this.panel_number);
            this.tabAlteraConta.Controls.Add(this.txtCidade);
            this.tabAlteraConta.Controls.Add(this.panel_telefone);
            this.tabAlteraConta.Controls.Add(this.txtNumero);
            this.tabAlteraConta.Controls.Add(this.txtTelefone);
            this.tabAlteraConta.Controls.Add(this.panel_bairro);
            this.tabAlteraConta.Controls.Add(this.panel_endereco);
            this.tabAlteraConta.Controls.Add(this.txtBairro);
            this.tabAlteraConta.Controls.Add(this.panel_nome);
            this.tabAlteraConta.Controls.Add(this.txtEndereco);
            this.tabAlteraConta.Controls.Add(this.txtNome);
            this.tabAlteraConta.Location = new System.Drawing.Point(4, 22);
            this.tabAlteraConta.Margin = new System.Windows.Forms.Padding(2);
            this.tabAlteraConta.Name = "tabAlteraConta";
            this.tabAlteraConta.Padding = new System.Windows.Forms.Padding(2);
            this.tabAlteraConta.Size = new System.Drawing.Size(539, 378);
            this.tabAlteraConta.TabIndex = 0;
            this.tabAlteraConta.Text = "Dados cadastrais";
            this.tabAlteraConta.UseVisualStyleBackColor = true;
            // 
            // btnEditarDados
            // 
            this.btnEditarDados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditarDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditarDados.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarDados.FlatAppearance.BorderSize = 0;
            this.btnEditarDados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditarDados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnEditarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarDados.Location = new System.Drawing.Point(5, 288);
            this.btnEditarDados.Name = "btnEditarDados";
            this.btnEditarDados.Size = new System.Drawing.Size(192, 46);
            this.btnEditarDados.TabIndex = 9;
            this.btnEditarDados.Text = "Editar";
            this.btnEditarDados.UseVisualStyleBackColor = false;
            this.btnEditarDados.Click += new System.EventHandler(this.btnEditarDados_Click);
            // 
            // btnSalvarDados
            // 
            this.btnSalvarDados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvarDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvarDados.Enabled = false;
            this.btnSalvarDados.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvarDados.FlatAppearance.BorderSize = 0;
            this.btnSalvarDados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvarDados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSalvarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarDados.Location = new System.Drawing.Point(336, 288);
            this.btnSalvarDados.Name = "btnSalvarDados";
            this.btnSalvarDados.Size = new System.Drawing.Size(192, 46);
            this.btnSalvarDados.TabIndex = 10;
            this.btnSalvarDados.Text = "Salvar";
            this.btnSalvarDados.UseVisualStyleBackColor = false;
            this.btnSalvarDados.Click += new System.EventHandler(this.btnSalvarDados_Click);
            // 
            // panel_usuario
            // 
            this.panel_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_usuario.BackColor = System.Drawing.Color.Silver;
            this.panel_usuario.Location = new System.Drawing.Point(4, 223);
            this.panel_usuario.Name = "panel_usuario";
            this.panel_usuario.Size = new System.Drawing.Size(299, 3);
            this.panel_usuario.TabIndex = 51;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.BackColor = System.Drawing.Color.GhostWhite;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Silver;
            this.txtUsuario.Location = new System.Drawing.Point(4, 195);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(300, 31);
            this.txtUsuario.TabIndex = 8;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // panel_uf
            // 
            this.panel_uf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_uf.BackColor = System.Drawing.Color.Silver;
            this.panel_uf.Location = new System.Drawing.Point(117, 182);
            this.panel_uf.Name = "panel_uf";
            this.panel_uf.Size = new System.Drawing.Size(142, 3);
            this.panel_uf.TabIndex = 49;
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
            this.txtUF.Enabled = false;
            this.txtUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUF.ForeColor = System.Drawing.Color.Silver;
            this.txtUF.Location = new System.Drawing.Point(117, 154);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(143, 31);
            this.txtUF.TabIndex = 6;
            this.txtUF.Text = "UF";
            this.txtUF.Enter += new System.EventHandler(this.txtUF_Enter);
            this.txtUF.Leave += new System.EventHandler(this.txtUF_Leave);
            // 
            // panel_cidade
            // 
            this.panel_cidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_cidade.BackColor = System.Drawing.Color.Silver;
            this.panel_cidade.Location = new System.Drawing.Point(266, 135);
            this.panel_cidade.Name = "panel_cidade";
            this.panel_cidade.Size = new System.Drawing.Size(260, 3);
            this.panel_cidade.TabIndex = 47;
            // 
            // panel_number
            // 
            this.panel_number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_number.BackColor = System.Drawing.Color.Silver;
            this.panel_number.Location = new System.Drawing.Point(4, 182);
            this.panel_number.Name = "panel_number";
            this.panel_number.Size = new System.Drawing.Size(107, 3);
            this.panel_number.TabIndex = 45;
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCidade.BackColor = System.Drawing.Color.GhostWhite;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCidade.Enabled = false;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.ForeColor = System.Drawing.Color.Silver;
            this.txtCidade.Location = new System.Drawing.Point(265, 107);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(264, 31);
            this.txtCidade.TabIndex = 4;
            this.txtCidade.Text = "Cidade";
            this.txtCidade.Enter += new System.EventHandler(this.txtCidade_Enter);
            this.txtCidade.Leave += new System.EventHandler(this.txtCidade_Leave);
            // 
            // panel_telefone
            // 
            this.panel_telefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_telefone.BackColor = System.Drawing.Color.Silver;
            this.panel_telefone.Location = new System.Drawing.Point(265, 182);
            this.panel_telefone.Name = "panel_telefone";
            this.panel_telefone.Size = new System.Drawing.Size(263, 3);
            this.panel_telefone.TabIndex = 43;
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumero.BackColor = System.Drawing.Color.GhostWhite;
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.Enabled = false;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.Color.Silver;
            this.txtNumero.Location = new System.Drawing.Point(4, 154);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(108, 31);
            this.txtNumero.TabIndex = 5;
            this.txtNumero.Text = "Nº";
            this.txtNumero.Enter += new System.EventHandler(this.txtNumero_Enter);
            this.txtNumero.Leave += new System.EventHandler(this.txtNumero_Leave);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefone.BackColor = System.Drawing.Color.GhostWhite;
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.Color.Silver;
            this.txtTelefone.HideSelection = false;
            this.txtTelefone.Location = new System.Drawing.Point(265, 154);
            this.txtTelefone.MaxLength = 13;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(264, 31);
            this.txtTelefone.TabIndex = 7;
            this.txtTelefone.Text = "Telefone";
            this.txtTelefone.Enter += new System.EventHandler(this.txtTelefone_Enter);
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            this.txtTelefone.Leave += new System.EventHandler(this.txtTelefone_Leave);
            // 
            // panel_bairro
            // 
            this.panel_bairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_bairro.BackColor = System.Drawing.Color.Silver;
            this.panel_bairro.Location = new System.Drawing.Point(4, 135);
            this.panel_bairro.Name = "panel_bairro";
            this.panel_bairro.Size = new System.Drawing.Size(255, 3);
            this.panel_bairro.TabIndex = 41;
            // 
            // panel_endereco
            // 
            this.panel_endereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_endereco.BackColor = System.Drawing.Color.Silver;
            this.panel_endereco.Location = new System.Drawing.Point(5, 87);
            this.panel_endereco.Name = "panel_endereco";
            this.panel_endereco.Size = new System.Drawing.Size(523, 3);
            this.panel_endereco.TabIndex = 39;
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBairro.BackColor = System.Drawing.Color.GhostWhite;
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBairro.Enabled = false;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.ForeColor = System.Drawing.Color.Silver;
            this.txtBairro.Location = new System.Drawing.Point(4, 107);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(255, 31);
            this.txtBairro.TabIndex = 3;
            this.txtBairro.Text = "Bairro";
            this.txtBairro.Enter += new System.EventHandler(this.txtBairro_Enter);
            this.txtBairro.Leave += new System.EventHandler(this.txtBairro_Leave);
            // 
            // panel_nome
            // 
            this.panel_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_nome.BackColor = System.Drawing.Color.Silver;
            this.panel_nome.Location = new System.Drawing.Point(5, 38);
            this.panel_nome.Name = "panel_nome";
            this.panel_nome.Size = new System.Drawing.Size(522, 3);
            this.panel_nome.TabIndex = 37;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEndereco.BackColor = System.Drawing.Color.GhostWhite;
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.Color.Silver;
            this.txtEndereco.Location = new System.Drawing.Point(5, 59);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(524, 31);
            this.txtEndereco.TabIndex = 2;
            this.txtEndereco.Text = "Endereço";
            this.txtEndereco.Enter += new System.EventHandler(this.txtEndereco_Enter);
            this.txtEndereco.Leave += new System.EventHandler(this.txtEndereco_Leave);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.BackColor = System.Drawing.Color.GhostWhite;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Silver;
            this.txtNome.Location = new System.Drawing.Point(5, 11);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(523, 31);
            this.txtNome.TabIndex = 1;
            this.txtNome.Text = "Nome da Empresa";
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // tabAlteraSenha
            // 
            this.tabAlteraSenha.Controls.Add(this.btnEditarSenha);
            this.tabAlteraSenha.Controls.Add(this.btnSalvarSenha);
            this.tabAlteraSenha.Controls.Add(this.panel_confirmsenha);
            this.tabAlteraSenha.Controls.Add(this.txtConfSenha);
            this.tabAlteraSenha.Controls.Add(this.panel_novasenha);
            this.tabAlteraSenha.Controls.Add(this.txtNovaSenha);
            this.tabAlteraSenha.Controls.Add(this.panel_senhaatual);
            this.tabAlteraSenha.Controls.Add(this.txtSenhaAtual);
            this.tabAlteraSenha.Location = new System.Drawing.Point(4, 22);
            this.tabAlteraSenha.Margin = new System.Windows.Forms.Padding(2);
            this.tabAlteraSenha.Name = "tabAlteraSenha";
            this.tabAlteraSenha.Padding = new System.Windows.Forms.Padding(2);
            this.tabAlteraSenha.Size = new System.Drawing.Size(539, 378);
            this.tabAlteraSenha.TabIndex = 1;
            this.tabAlteraSenha.Text = "Alterar senha";
            this.tabAlteraSenha.UseVisualStyleBackColor = true;
            // 
            // btnEditarSenha
            // 
            this.btnEditarSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditarSenha.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarSenha.FlatAppearance.BorderSize = 0;
            this.btnEditarSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditarSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnEditarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarSenha.Location = new System.Drawing.Point(119, 188);
            this.btnEditarSenha.Name = "btnEditarSenha";
            this.btnEditarSenha.Size = new System.Drawing.Size(300, 46);
            this.btnEditarSenha.TabIndex = 3;
            this.btnEditarSenha.Text = "Editar";
            this.btnEditarSenha.UseVisualStyleBackColor = false;
            this.btnEditarSenha.Click += new System.EventHandler(this.btnEditarSenha_Click);
            // 
            // btnSalvarSenha
            // 
            this.btnSalvarSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvarSenha.Enabled = false;
            this.btnSalvarSenha.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvarSenha.FlatAppearance.BorderSize = 0;
            this.btnSalvarSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvarSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSalvarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarSenha.Location = new System.Drawing.Point(118, 241);
            this.btnSalvarSenha.Name = "btnSalvarSenha";
            this.btnSalvarSenha.Size = new System.Drawing.Size(300, 46);
            this.btnSalvarSenha.TabIndex = 4;
            this.btnSalvarSenha.Text = "Salvar";
            this.btnSalvarSenha.UseVisualStyleBackColor = false;
            this.btnSalvarSenha.Click += new System.EventHandler(this.btnSalvarSenha_Click);
            // 
            // panel_confirmsenha
            // 
            this.panel_confirmsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_confirmsenha.BackColor = System.Drawing.Color.Silver;
            this.panel_confirmsenha.Location = new System.Drawing.Point(119, 178);
            this.panel_confirmsenha.Name = "panel_confirmsenha";
            this.panel_confirmsenha.Size = new System.Drawing.Size(299, 3);
            this.panel_confirmsenha.TabIndex = 28;
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfSenha.BackColor = System.Drawing.Color.GhostWhite;
            this.txtConfSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfSenha.Enabled = false;
            this.txtConfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfSenha.ForeColor = System.Drawing.Color.Silver;
            this.txtConfSenha.Location = new System.Drawing.Point(119, 150);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.Size = new System.Drawing.Size(300, 31);
            this.txtConfSenha.TabIndex = 2;
            this.txtConfSenha.Text = "Confirmar senha";
            this.txtConfSenha.Enter += new System.EventHandler(this.txtConfSenha_Enter);
            this.txtConfSenha.Leave += new System.EventHandler(this.txtConfSenha_Leave);
            // 
            // panel_novasenha
            // 
            this.panel_novasenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_novasenha.BackColor = System.Drawing.Color.Silver;
            this.panel_novasenha.Location = new System.Drawing.Point(120, 136);
            this.panel_novasenha.Name = "panel_novasenha";
            this.panel_novasenha.Size = new System.Drawing.Size(299, 3);
            this.panel_novasenha.TabIndex = 26;
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNovaSenha.BackColor = System.Drawing.Color.GhostWhite;
            this.txtNovaSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNovaSenha.Enabled = false;
            this.txtNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSenha.ForeColor = System.Drawing.Color.Silver;
            this.txtNovaSenha.Location = new System.Drawing.Point(120, 108);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(300, 31);
            this.txtNovaSenha.TabIndex = 1;
            this.txtNovaSenha.Text = "Nova senha";
            this.txtNovaSenha.Enter += new System.EventHandler(this.txtNovaSenha_Enter);
            this.txtNovaSenha.Leave += new System.EventHandler(this.txtNovaSenha_Leave);
            // 
            // panel_senhaatual
            // 
            this.panel_senhaatual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_senhaatual.BackColor = System.Drawing.Color.Silver;
            this.panel_senhaatual.Location = new System.Drawing.Point(119, 93);
            this.panel_senhaatual.Name = "panel_senhaatual";
            this.panel_senhaatual.Size = new System.Drawing.Size(299, 3);
            this.panel_senhaatual.TabIndex = 24;
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenhaAtual.BackColor = System.Drawing.Color.GhostWhite;
            this.txtSenhaAtual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenhaAtual.Enabled = false;
            this.txtSenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaAtual.ForeColor = System.Drawing.Color.Silver;
            this.txtSenhaAtual.Location = new System.Drawing.Point(119, 65);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.Size = new System.Drawing.Size(300, 31);
            this.txtSenhaAtual.TabIndex = 0;
            this.txtSenhaAtual.Text = "Senha atual";
            this.txtSenhaAtual.Enter += new System.EventHandler(this.txtSenhaAtual_Enter);
            this.txtSenhaAtual.Leave += new System.EventHandler(this.txtSenhaAtual_Leave);
            // 
            // erroDadosCadastrais
            // 
            this.erroDadosCadastrais.BlinkRate = 0;
            this.erroDadosCadastrais.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erroDadosCadastrais.ContainerControl = this;
            // 
            // erroSenha
            // 
            this.erroSenha.BlinkRate = 0;
            this.erroSenha.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erroSenha.ContainerControl = this;
            // 
            // Conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 553);
            this.Controls.Add(this.tbDadosCadastro);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Conta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta";
            this.Load += new System.EventHandler(this.Conta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbDadosCadastro.ResumeLayout(false);
            this.tabAlteraConta.ResumeLayout(false);
            this.tabAlteraConta.PerformLayout();
            this.tabAlteraSenha.ResumeLayout(false);
            this.tabAlteraSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroDadosCadastrais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroSenha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbDadosCadastro;
        private System.Windows.Forms.TabPage tabAlteraConta;
        private System.Windows.Forms.Panel panel_uf;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Panel panel_cidade;
        private System.Windows.Forms.Panel panel_number;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Panel panel_telefone;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Panel panel_bairro;
        private System.Windows.Forms.Panel panel_endereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Panel panel_nome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TabPage tabAlteraSenha;
        private System.Windows.Forms.Panel panel_usuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnEditarDados;
        private System.Windows.Forms.Button btnSalvarDados;
        private System.Windows.Forms.Panel panel_senhaatual;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.Button btnEditarSenha;
        private System.Windows.Forms.Button btnSalvarSenha;
        private System.Windows.Forms.Panel panel_confirmsenha;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.Panel panel_novasenha;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.ErrorProvider erroDadosCadastrais;
        private System.Windows.Forms.ErrorProvider erroSenha;
    }
}