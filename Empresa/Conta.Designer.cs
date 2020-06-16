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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDadosCadastro = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEditarSenha = new System.Windows.Forms.Button();
            this.btnSalvarSenha = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.panel_senha = new System.Windows.Forms.Panel();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tbDadosCadastro.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 71);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Minha Conta";
            // 
            // tbDadosCadastro
            // 
            this.tbDadosCadastro.Controls.Add(this.tabPage1);
            this.tbDadosCadastro.Controls.Add(this.tabPage2);
            this.tbDadosCadastro.Location = new System.Drawing.Point(88, 78);
            this.tbDadosCadastro.Name = "tbDadosCadastro";
            this.tbDadosCadastro.SelectedIndex = 0;
            this.tbDadosCadastro.Size = new System.Drawing.Size(729, 497);
            this.tbDadosCadastro.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEditarDados);
            this.tabPage1.Controls.Add(this.btnSalvarDados);
            this.tabPage1.Controls.Add(this.panel_usuario);
            this.tabPage1.Controls.Add(this.txtUsuario);
            this.tabPage1.Controls.Add(this.panel_uf);
            this.tabPage1.Controls.Add(this.txtUF);
            this.tabPage1.Controls.Add(this.panel_cidade);
            this.tabPage1.Controls.Add(this.panel_number);
            this.tabPage1.Controls.Add(this.txtCidade);
            this.tabPage1.Controls.Add(this.panel_telefone);
            this.tabPage1.Controls.Add(this.txtNumero);
            this.tabPage1.Controls.Add(this.txtTelefone);
            this.tabPage1.Controls.Add(this.panel_bairro);
            this.tabPage1.Controls.Add(this.panel_endereco);
            this.tabPage1.Controls.Add(this.txtBairro);
            this.tabPage1.Controls.Add(this.panel_nome);
            this.tabPage1.Controls.Add(this.txtEndereco);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(721, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados cadastrais";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.btnEditarDados.Location = new System.Drawing.Point(447, 154);
            this.btnEditarDados.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarDados.Name = "btnEditarDados";
            this.btnEditarDados.Size = new System.Drawing.Size(256, 57);
            this.btnEditarDados.TabIndex = 53;
            this.btnEditarDados.Text = "Editar";
            this.btnEditarDados.UseVisualStyleBackColor = false;
            // 
            // btnSalvarDados
            // 
            this.btnSalvarDados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvarDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvarDados.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvarDados.FlatAppearance.BorderSize = 0;
            this.btnSalvarDados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvarDados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSalvarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarDados.Location = new System.Drawing.Point(447, 248);
            this.btnSalvarDados.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarDados.Name = "btnSalvarDados";
            this.btnSalvarDados.Size = new System.Drawing.Size(256, 57);
            this.btnSalvarDados.TabIndex = 52;
            this.btnSalvarDados.Text = "Salvar";
            this.btnSalvarDados.UseVisualStyleBackColor = false;
            this.btnSalvarDados.Click += new System.EventHandler(this.btnSalvarDados_Click);
            // 
            // panel_usuario
            // 
            this.panel_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_usuario.BackColor = System.Drawing.Color.Silver;
            this.panel_usuario.Location = new System.Drawing.Point(3, 455);
            this.panel_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.panel_usuario.Name = "panel_usuario";
            this.panel_usuario.Size = new System.Drawing.Size(399, 4);
            this.panel_usuario.TabIndex = 51;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.BackColor = System.Drawing.Color.GhostWhite;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Silver;
            this.txtUsuario.Location = new System.Drawing.Point(3, 420);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(400, 39);
            this.txtUsuario.TabIndex = 50;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // panel_uf
            // 
            this.panel_uf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_uf.BackColor = System.Drawing.Color.Silver;
            this.panel_uf.Location = new System.Drawing.Point(5, 344);
            this.panel_uf.Margin = new System.Windows.Forms.Padding(4);
            this.panel_uf.Name = "panel_uf";
            this.panel_uf.Size = new System.Drawing.Size(399, 4);
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
            this.txtUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUF.ForeColor = System.Drawing.Color.Silver;
            this.txtUF.Location = new System.Drawing.Point(5, 309);
            this.txtUF.Margin = new System.Windows.Forms.Padding(4);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(400, 39);
            this.txtUF.TabIndex = 48;
            this.txtUF.Text = "UF";
            this.txtUF.Enter += new System.EventHandler(this.txtUF_Enter);
            this.txtUF.Leave += new System.EventHandler(this.txtUF_Leave);
            // 
            // panel_cidade
            // 
            this.panel_cidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_cidade.BackColor = System.Drawing.Color.Silver;
            this.panel_cidade.Location = new System.Drawing.Point(4, 283);
            this.panel_cidade.Margin = new System.Windows.Forms.Padding(4);
            this.panel_cidade.Name = "panel_cidade";
            this.panel_cidade.Size = new System.Drawing.Size(399, 4);
            this.panel_cidade.TabIndex = 47;
            // 
            // panel_number
            // 
            this.panel_number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_number.BackColor = System.Drawing.Color.Silver;
            this.panel_number.Location = new System.Drawing.Point(5, 224);
            this.panel_number.Margin = new System.Windows.Forms.Padding(4);
            this.panel_number.Name = "panel_number";
            this.panel_number.Size = new System.Drawing.Size(399, 4);
            this.panel_number.TabIndex = 45;
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCidade.BackColor = System.Drawing.Color.GhostWhite;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.ForeColor = System.Drawing.Color.Silver;
            this.txtCidade.Location = new System.Drawing.Point(4, 249);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(400, 39);
            this.txtCidade.TabIndex = 46;
            this.txtCidade.Text = "Cidade";
            this.txtCidade.Enter += new System.EventHandler(this.txtCidade_Enter);
            this.txtCidade.Leave += new System.EventHandler(this.txtCidade_Leave);
            // 
            // panel_telefone
            // 
            this.panel_telefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_telefone.BackColor = System.Drawing.Color.Silver;
            this.panel_telefone.Location = new System.Drawing.Point(3, 399);
            this.panel_telefone.Margin = new System.Windows.Forms.Padding(4);
            this.panel_telefone.Name = "panel_telefone";
            this.panel_telefone.Size = new System.Drawing.Size(399, 4);
            this.panel_telefone.TabIndex = 43;
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumero.BackColor = System.Drawing.Color.GhostWhite;
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.Color.Silver;
            this.txtNumero.Location = new System.Drawing.Point(5, 190);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(400, 39);
            this.txtNumero.TabIndex = 44;
            this.txtNumero.Text = "Nº";
            this.txtNumero.Enter += new System.EventHandler(this.txtNumero_Enter);
            this.txtNumero.Leave += new System.EventHandler(this.txtNumero_Leave);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefone.BackColor = System.Drawing.Color.GhostWhite;
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.Color.Silver;
            this.txtTelefone.HideSelection = false;
            this.txtTelefone.Location = new System.Drawing.Point(3, 365);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.MaxLength = 11;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(400, 39);
            this.txtTelefone.TabIndex = 42;
            this.txtTelefone.Text = "Telefone";
            this.txtTelefone.Enter += new System.EventHandler(this.txtTelefone_Enter);
            this.txtTelefone.Leave += new System.EventHandler(this.txtTelefone_Leave);
            // 
            // panel_bairro
            // 
            this.panel_bairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_bairro.BackColor = System.Drawing.Color.Silver;
            this.panel_bairro.Location = new System.Drawing.Point(6, 166);
            this.panel_bairro.Margin = new System.Windows.Forms.Padding(4);
            this.panel_bairro.Name = "panel_bairro";
            this.panel_bairro.Size = new System.Drawing.Size(399, 4);
            this.panel_bairro.TabIndex = 41;
            // 
            // panel_endereco
            // 
            this.panel_endereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_endereco.BackColor = System.Drawing.Color.Silver;
            this.panel_endereco.Location = new System.Drawing.Point(7, 107);
            this.panel_endereco.Margin = new System.Windows.Forms.Padding(4);
            this.panel_endereco.Name = "panel_endereco";
            this.panel_endereco.Size = new System.Drawing.Size(399, 4);
            this.panel_endereco.TabIndex = 39;
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBairro.BackColor = System.Drawing.Color.GhostWhite;
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.ForeColor = System.Drawing.Color.Silver;
            this.txtBairro.Location = new System.Drawing.Point(6, 132);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(400, 39);
            this.txtBairro.TabIndex = 40;
            this.txtBairro.Text = "Bairro";
            this.txtBairro.Enter += new System.EventHandler(this.txtBairro_Enter);
            this.txtBairro.Leave += new System.EventHandler(this.txtBairro_Leave);
            // 
            // panel_nome
            // 
            this.panel_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_nome.BackColor = System.Drawing.Color.Silver;
            this.panel_nome.Location = new System.Drawing.Point(7, 47);
            this.panel_nome.Margin = new System.Windows.Forms.Padding(4);
            this.panel_nome.Name = "panel_nome";
            this.panel_nome.Size = new System.Drawing.Size(399, 4);
            this.panel_nome.TabIndex = 37;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEndereco.BackColor = System.Drawing.Color.GhostWhite;
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.Color.Silver;
            this.txtEndereco.Location = new System.Drawing.Point(7, 73);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(400, 39);
            this.txtEndereco.TabIndex = 38;
            this.txtEndereco.Text = "Endereço";
            this.txtEndereco.Enter += new System.EventHandler(this.txtEndereco_Enter);
            this.txtEndereco.Leave += new System.EventHandler(this.txtEndereco_Leave);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.BackColor = System.Drawing.Color.GhostWhite;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Silver;
            this.txtNome.Location = new System.Drawing.Point(7, 13);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(400, 39);
            this.txtNome.TabIndex = 36;
            this.txtNome.Text = "Nome da Empresa";
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEditarSenha);
            this.tabPage2.Controls.Add(this.btnSalvarSenha);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.txtConfSenha);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.txtNovaSenha);
            this.tabPage2.Controls.Add(this.panel_senha);
            this.tabPage2.Controls.Add(this.txtSenhaAtual);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(721, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alterar senha";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.btnEditarSenha.Location = new System.Drawing.Point(159, 232);
            this.btnEditarSenha.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarSenha.Name = "btnEditarSenha";
            this.btnEditarSenha.Size = new System.Drawing.Size(400, 57);
            this.btnEditarSenha.TabIndex = 55;
            this.btnEditarSenha.Text = "Editar";
            this.btnEditarSenha.UseVisualStyleBackColor = false;
            // 
            // btnSalvarSenha
            // 
            this.btnSalvarSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvarSenha.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvarSenha.FlatAppearance.BorderSize = 0;
            this.btnSalvarSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvarSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSalvarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarSenha.Location = new System.Drawing.Point(158, 297);
            this.btnSalvarSenha.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarSenha.Name = "btnSalvarSenha";
            this.btnSalvarSenha.Size = new System.Drawing.Size(400, 57);
            this.btnSalvarSenha.TabIndex = 54;
            this.btnSalvarSenha.Text = "Salvar";
            this.btnSalvarSenha.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(159, 219);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(399, 4);
            this.panel3.TabIndex = 28;
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfSenha.BackColor = System.Drawing.Color.GhostWhite;
            this.txtConfSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfSenha.ForeColor = System.Drawing.Color.Silver;
            this.txtConfSenha.Location = new System.Drawing.Point(159, 185);
            this.txtConfSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.PasswordChar = '*';
            this.txtConfSenha.Size = new System.Drawing.Size(400, 39);
            this.txtConfSenha.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(160, 167);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 4);
            this.panel2.TabIndex = 26;
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNovaSenha.BackColor = System.Drawing.Color.GhostWhite;
            this.txtNovaSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSenha.ForeColor = System.Drawing.Color.Silver;
            this.txtNovaSenha.Location = new System.Drawing.Point(160, 133);
            this.txtNovaSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '*';
            this.txtNovaSenha.Size = new System.Drawing.Size(400, 39);
            this.txtNovaSenha.TabIndex = 25;
            // 
            // panel_senha
            // 
            this.panel_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_senha.BackColor = System.Drawing.Color.Silver;
            this.panel_senha.Location = new System.Drawing.Point(159, 114);
            this.panel_senha.Margin = new System.Windows.Forms.Padding(4);
            this.panel_senha.Name = "panel_senha";
            this.panel_senha.Size = new System.Drawing.Size(399, 4);
            this.panel_senha.TabIndex = 24;
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenhaAtual.BackColor = System.Drawing.Color.GhostWhite;
            this.txtSenhaAtual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaAtual.ForeColor = System.Drawing.Color.Silver;
            this.txtSenhaAtual.Location = new System.Drawing.Point(159, 80);
            this.txtSenhaAtual.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.PasswordChar = '*';
            this.txtSenhaAtual.Size = new System.Drawing.Size(400, 39);
            this.txtSenhaAtual.TabIndex = 23;
            // 
            // Conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 681);
            this.Controls.Add(this.tbDadosCadastro);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Conta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta";
            this.Load += new System.EventHandler(this.Conta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbDadosCadastro.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbDadosCadastro;
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel_usuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnEditarDados;
        private System.Windows.Forms.Button btnSalvarDados;
        private System.Windows.Forms.Panel panel_senha;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.Button btnEditarSenha;
        private System.Windows.Forms.Button btnSalvarSenha;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNovaSenha;
    }
}