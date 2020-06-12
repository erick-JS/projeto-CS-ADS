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
<<<<<<< HEAD
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
=======
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
>>>>>>> 83d6ebc29bd46b46f094f39f911168cdee21d2f7
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
            this.txtConfirmSenha = new System.Windows.Forms.TextBox();
            this.gpxFormaPagamento = new System.Windows.Forms.GroupBox();
            this.chkDinheiro = new System.Windows.Forms.CheckBox();
            this.chkCredito = new System.Windows.Forms.CheckBox();
            this.chkDebito = new System.Windows.Forms.CheckBox();
            this.panel_uf = new System.Windows.Forms.Panel();
<<<<<<< HEAD
            this.txtUF = new System.Windows.Forms.TextBox();
            this.erroP = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.gpxFormaPagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroP)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1067, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(436, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(816, 482);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(169, 57);
            this.btnCadastrar.TabIndex = 16;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(69, 482);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(169, 57);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
=======
            this.Uf = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panel2.TabIndex = 1;
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
            this.button3.TabIndex = 4;
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
            this.button5.TabIndex = 3;
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
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(612, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(52, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
>>>>>>> 83d6ebc29bd46b46f094f39f911168cdee21d2f7
            // 
            // panel_nome
            // 
            this.panel_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_nome.BackColor = System.Drawing.Color.Silver;
            this.panel_nome.Location = new System.Drawing.Point(69, 144);
            this.panel_nome.Margin = new System.Windows.Forms.Padding(4);
            this.panel_nome.Name = "panel_nome";
            this.panel_nome.Size = new System.Drawing.Size(399, 4);
            this.panel_nome.TabIndex = 8;
            // 
<<<<<<< HEAD
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Silver;
            this.txtNome.Location = new System.Drawing.Point(69, 110);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(400, 39);
            this.txtNome.TabIndex = 1;
            this.txtNome.Text = "Nome";
            this.txtNome.Enter += new System.EventHandler(this.Nome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.Nome_Leave);
=======
            // Nome
            // 
            this.Nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Nome.BackColor = System.Drawing.Color.GhostWhite;
            this.Nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.Color.Silver;
            this.Nome.Location = new System.Drawing.Point(52, 89);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(300, 31);
            this.Nome.TabIndex = 7;
            this.Nome.Text = "Nome da Empresa";
            this.Nome.Enter += new System.EventHandler(this.Nome_Enter);
            this.Nome.Leave += new System.EventHandler(this.Nome_Leave);
>>>>>>> 83d6ebc29bd46b46f094f39f911168cdee21d2f7
            // 
            // panel_endereco
            // 
            this.panel_endereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_endereco.BackColor = System.Drawing.Color.Silver;
            this.panel_endereco.Location = new System.Drawing.Point(69, 204);
            this.panel_endereco.Margin = new System.Windows.Forms.Padding(4);
            this.panel_endereco.Name = "panel_endereco";
            this.panel_endereco.Size = new System.Drawing.Size(399, 4);
            this.panel_endereco.TabIndex = 10;
            // 
<<<<<<< HEAD
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.White;
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.Color.Silver;
            this.txtEndereco.Location = new System.Drawing.Point(69, 170);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(400, 39);
            this.txtEndereco.TabIndex = 2;
            this.txtEndereco.Text = "Endereço";
            this.txtEndereco.Enter += new System.EventHandler(this.Endereco_Enter);
            this.txtEndereco.Leave += new System.EventHandler(this.Endereco_Leave);
=======
            // Endereco
            // 
            this.Endereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Endereco.BackColor = System.Drawing.Color.GhostWhite;
            this.Endereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Endereco.ForeColor = System.Drawing.Color.Silver;
            this.Endereco.Location = new System.Drawing.Point(52, 138);
            this.Endereco.Name = "Endereco";
            this.Endereco.Size = new System.Drawing.Size(300, 31);
            this.Endereco.TabIndex = 9;
            this.Endereco.Text = "Endereço";
            this.Endereco.Enter += new System.EventHandler(this.Endereco_Enter);
            this.Endereco.Leave += new System.EventHandler(this.Endereco_Leave);
>>>>>>> 83d6ebc29bd46b46f094f39f911168cdee21d2f7
            // 
            // panel_bairro
            // 
            this.panel_bairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_bairro.BackColor = System.Drawing.Color.Silver;
            this.panel_bairro.Location = new System.Drawing.Point(68, 263);
            this.panel_bairro.Margin = new System.Windows.Forms.Padding(4);
            this.panel_bairro.Name = "panel_bairro";
            this.panel_bairro.Size = new System.Drawing.Size(399, 4);
            this.panel_bairro.TabIndex = 12;
            // 
<<<<<<< HEAD
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.White;
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.ForeColor = System.Drawing.Color.Silver;
            this.txtBairro.Location = new System.Drawing.Point(68, 229);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(400, 39);
            this.txtBairro.TabIndex = 3;
            this.txtBairro.Text = "Bairro";
            this.txtBairro.Enter += new System.EventHandler(this.Bairro_Enter);
            this.txtBairro.Leave += new System.EventHandler(this.Bairro_Leave);
=======
            // Bairro
            // 
            this.Bairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Bairro.BackColor = System.Drawing.Color.GhostWhite;
            this.Bairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bairro.ForeColor = System.Drawing.Color.Silver;
            this.Bairro.Location = new System.Drawing.Point(51, 186);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(300, 31);
            this.Bairro.TabIndex = 11;
            this.Bairro.Text = "Bairro";
            this.Bairro.Enter += new System.EventHandler(this.Bairro_Enter);
            this.Bairro.Leave += new System.EventHandler(this.Bairro_Leave);
>>>>>>> 83d6ebc29bd46b46f094f39f911168cdee21d2f7
            // 
            // panel_cidade
            // 
            this.panel_cidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_cidade.BackColor = System.Drawing.Color.Silver;
            this.panel_cidade.Location = new System.Drawing.Point(66, 373);
            this.panel_cidade.Margin = new System.Windows.Forms.Padding(4);
            this.panel_cidade.Name = "panel_cidade";
            this.panel_cidade.Size = new System.Drawing.Size(399, 4);
            this.panel_cidade.TabIndex = 18;
            // 
            // panel_number
            // 
            this.panel_number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_number.BackColor = System.Drawing.Color.Silver;
            this.panel_number.Location = new System.Drawing.Point(67, 314);
            this.panel_number.Margin = new System.Windows.Forms.Padding(4);
            this.panel_number.Name = "panel_number";
            this.panel_number.Size = new System.Drawing.Size(399, 4);
            this.panel_number.TabIndex = 16;
            // 
<<<<<<< HEAD
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.White;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.ForeColor = System.Drawing.Color.Silver;
            this.txtCidade.Location = new System.Drawing.Point(66, 339);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(400, 39);
            this.txtCidade.TabIndex = 5;
            this.txtCidade.Text = "Cidade";
            this.txtCidade.Enter += new System.EventHandler(this.Cidade_Enter);
            this.txtCidade.Leave += new System.EventHandler(this.Cidade_Leave);
=======
            // Cidade
            // 
            this.Cidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cidade.BackColor = System.Drawing.Color.GhostWhite;
            this.Cidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cidade.ForeColor = System.Drawing.Color.Silver;
            this.Cidade.Location = new System.Drawing.Point(438, 186);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(300, 31);
            this.Cidade.TabIndex = 17;
            this.Cidade.Text = "Cidade";
            this.Cidade.Enter += new System.EventHandler(this.Cidade_Enter);
            this.Cidade.Leave += new System.EventHandler(this.Cidade_Leave);
>>>>>>> 83d6ebc29bd46b46f094f39f911168cdee21d2f7
            // 
            // panel_telefone
            // 
            this.panel_telefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_telefone.BackColor = System.Drawing.Color.Silver;
            this.panel_telefone.Location = new System.Drawing.Point(585, 144);
            this.panel_telefone.Margin = new System.Windows.Forms.Padding(4);
            this.panel_telefone.Name = "panel_telefone";
            this.panel_telefone.Size = new System.Drawing.Size(399, 4);
            this.panel_telefone.TabIndex = 14;
            // 
<<<<<<< HEAD
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.Color.Silver;
            this.txtNumero.Location = new System.Drawing.Point(67, 280);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(400, 39);
            this.txtNumero.TabIndex = 4;
            this.txtNumero.Text = "Nº";
            this.txtNumero.Enter += new System.EventHandler(this.number_Enter);
            this.txtNumero.Leave += new System.EventHandler(this.number_Leave);
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.White;
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.Color.Silver;
            this.txtTelefone.HideSelection = false;
            this.txtTelefone.Location = new System.Drawing.Point(585, 105);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.MaxLength = 11;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(400, 39);
            this.txtTelefone.TabIndex = 7;
            this.txtTelefone.Text = "Telefone";
            this.txtTelefone.Enter += new System.EventHandler(this.Telefone_Enter);
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            this.txtTelefone.Leave += new System.EventHandler(this.Telefone_Leave);
=======
            // number
            // 
            this.number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.number.BackColor = System.Drawing.Color.GhostWhite;
            this.number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.ForeColor = System.Drawing.Color.Silver;
            this.number.Location = new System.Drawing.Point(439, 138);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(300, 31);
            this.number.TabIndex = 15;
            this.number.Text = "Nº";
            this.number.Enter += new System.EventHandler(this.number_Enter);
            this.number.Leave += new System.EventHandler(this.number_Leave);
            // 
            // Telefone
            // 
            this.Telefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Telefone.BackColor = System.Drawing.Color.GhostWhite;
            this.Telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.ForeColor = System.Drawing.Color.Silver;
            this.Telefone.HideSelection = false;
            this.Telefone.Location = new System.Drawing.Point(439, 89);
            this.Telefone.MaxLength = 11;
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(300, 31);
            this.Telefone.TabIndex = 13;
            this.Telefone.Text = "Telefone";
            this.Telefone.Enter += new System.EventHandler(this.Telefone_Enter);
            this.Telefone.Leave += new System.EventHandler(this.Telefone_Leave);
>>>>>>> 83d6ebc29bd46b46f094f39f911168cdee21d2f7
            // 
            // panel_senha
            // 
            this.panel_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_senha.BackColor = System.Drawing.Color.Silver;
            this.panel_senha.Location = new System.Drawing.Point(587, 267);
            this.panel_senha.Margin = new System.Windows.Forms.Padding(4);
            this.panel_senha.Name = "panel_senha";
            this.panel_senha.Size = new System.Drawing.Size(399, 4);
            this.panel_senha.TabIndex = 22;
            // 
<<<<<<< HEAD
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.Silver;
            this.txtSenha.Location = new System.Drawing.Point(587, 233);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(400, 39);
            this.txtSenha.TabIndex = 9;
            this.txtSenha.Text = "Senha";
            this.txtSenha.Enter += new System.EventHandler(this.Senha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.Senha_Leave);
=======
            // Senha
            // 
            this.Senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Senha.BackColor = System.Drawing.Color.GhostWhite;
            this.Senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.ForeColor = System.Drawing.Color.Silver;
            this.Senha.Location = new System.Drawing.Point(52, 286);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(300, 31);
            this.Senha.TabIndex = 21;
            this.Senha.Text = "Senha";
            this.Senha.Enter += new System.EventHandler(this.Senha_Enter);
            this.Senha.Leave += new System.EventHandler(this.Senha_Leave);
>>>>>>> 83d6ebc29bd46b46f094f39f911168cdee21d2f7
            // 
            // panel_usuario
            // 
            this.panel_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_usuario.BackColor = System.Drawing.Color.Silver;
            this.panel_usuario.Location = new System.Drawing.Point(585, 205);
            this.panel_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.panel_usuario.Name = "panel_usuario";
            this.panel_usuario.Size = new System.Drawing.Size(399, 4);
            this.panel_usuario.TabIndex = 20;
            // 
<<<<<<< HEAD
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Silver;
            this.txtUsuario.Location = new System.Drawing.Point(585, 170);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(400, 39);
            this.txtUsuario.TabIndex = 8;
            this.txtUsuario.Text = "Usuário";
            this.txtUsuario.Enter += new System.EventHandler(this.Usuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.Usuario_Leave);
=======
            // Usuario
            // 
            this.Usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Usuario.BackColor = System.Drawing.Color.GhostWhite;
            this.Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.ForeColor = System.Drawing.Color.Silver;
            this.Usuario.Location = new System.Drawing.Point(50, 235);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(300, 31);
            this.Usuario.TabIndex = 19;
            this.Usuario.Text = "Usuario";
            this.Usuario.Enter += new System.EventHandler(this.Usuario_Enter);
            this.Usuario.Leave += new System.EventHandler(this.Usuario_Leave);
>>>>>>> 83d6ebc29bd46b46f094f39f911168cdee21d2f7
            // 
            // panel_comfirmsenha
            // 
            this.panel_comfirmsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_comfirmsenha.BackColor = System.Drawing.Color.Silver;
            this.panel_comfirmsenha.Location = new System.Drawing.Point(586, 330);
            this.panel_comfirmsenha.Margin = new System.Windows.Forms.Padding(4);
            this.panel_comfirmsenha.Name = "panel_comfirmsenha";
            this.panel_comfirmsenha.Size = new System.Drawing.Size(399, 4);
            this.panel_comfirmsenha.TabIndex = 24;
            // 
<<<<<<< HEAD
            // txtConfirmSenha
            // 
            this.txtConfirmSenha.BackColor = System.Drawing.Color.White;
            this.txtConfirmSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmSenha.ForeColor = System.Drawing.Color.Silver;
            this.txtConfirmSenha.Location = new System.Drawing.Point(586, 296);
            this.txtConfirmSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmSenha.Name = "txtConfirmSenha";
            this.txtConfirmSenha.Size = new System.Drawing.Size(400, 39);
            this.txtConfirmSenha.TabIndex = 10;
            this.txtConfirmSenha.Text = "Confirmar Senha";
            this.txtConfirmSenha.Enter += new System.EventHandler(this.ComfirmSenha_Enter);
            this.txtConfirmSenha.Leave += new System.EventHandler(this.ComfirmSenha_Leave);
            // 
            // gpxFormaPagamento
            // 
            this.gpxFormaPagamento.Controls.Add(this.chkDinheiro);
            this.gpxFormaPagamento.Controls.Add(this.chkCredito);
            this.gpxFormaPagamento.Controls.Add(this.chkDebito);
            this.gpxFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxFormaPagamento.Location = new System.Drawing.Point(584, 352);
            this.gpxFormaPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.gpxFormaPagamento.Name = "gpxFormaPagamento";
            this.gpxFormaPagamento.Padding = new System.Windows.Forms.Padding(4);
            this.gpxFormaPagamento.Size = new System.Drawing.Size(399, 101);
            this.gpxFormaPagamento.TabIndex = 11;
            this.gpxFormaPagamento.TabStop = false;
            this.gpxFormaPagamento.Text = "Aceita";
            // 
            // chkDinheiro
            // 
            this.chkDinheiro.AutoSize = true;
            this.chkDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDinheiro.Location = new System.Drawing.Point(257, 41);
            this.chkDinheiro.Margin = new System.Windows.Forms.Padding(4);
            this.chkDinheiro.Name = "chkDinheiro";
            this.chkDinheiro.Size = new System.Drawing.Size(126, 33);
            this.chkDinheiro.TabIndex = 14;
            this.chkDinheiro.Text = "Dinheiro";
            this.chkDinheiro.UseVisualStyleBackColor = true;
            // 
            // chkCredito
            // 
            this.chkCredito.AutoSize = true;
            this.chkCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCredito.Location = new System.Drawing.Point(131, 41);
            this.chkCredito.Margin = new System.Windows.Forms.Padding(4);
            this.chkCredito.Name = "chkCredito";
            this.chkCredito.Size = new System.Drawing.Size(114, 33);
            this.chkCredito.TabIndex = 13;
            this.chkCredito.Text = "Crédito";
            this.chkCredito.UseVisualStyleBackColor = true;
            // 
            // chkDebito
            // 
            this.chkDebito.AutoSize = true;
            this.chkDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDebito.Location = new System.Drawing.Point(12, 41);
            this.chkDebito.Margin = new System.Windows.Forms.Padding(4);
            this.chkDebito.Name = "chkDebito";
            this.chkDebito.Size = new System.Drawing.Size(106, 33);
            this.chkDebito.TabIndex = 12;
            this.chkDebito.Text = "Débito";
            this.chkDebito.UseVisualStyleBackColor = true;
=======
            // ComfirmSenha
            // 
            this.ComfirmSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComfirmSenha.BackColor = System.Drawing.Color.GhostWhite;
            this.ComfirmSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ComfirmSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComfirmSenha.ForeColor = System.Drawing.Color.Silver;
            this.ComfirmSenha.Location = new System.Drawing.Point(51, 337);
            this.ComfirmSenha.Name = "ComfirmSenha";
            this.ComfirmSenha.Size = new System.Drawing.Size(300, 31);
            this.ComfirmSenha.TabIndex = 23;
            this.ComfirmSenha.Text = "Confirmar Senha";
            this.ComfirmSenha.Enter += new System.EventHandler(this.ComfirmSenha_Enter);
            this.ComfirmSenha.Leave += new System.EventHandler(this.ComfirmSenha_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.Dinheiro);
            this.groupBox1.Controls.Add(this.Credito);
            this.groupBox1.Controls.Add(this.Debito);
            this.groupBox1.Location = new System.Drawing.Point(438, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 82);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aceita";
            // 
            // Dinheiro
            // 
            this.Dinheiro.AutoSize = true;
            this.Dinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dinheiro.Location = new System.Drawing.Point(193, 33);
            this.Dinheiro.Name = "Dinheiro";
            this.Dinheiro.Size = new System.Drawing.Size(100, 28);
            this.Dinheiro.TabIndex = 2;
            this.Dinheiro.Text = "Dinheiro";
            this.Dinheiro.UseVisualStyleBackColor = true;
            // 
            // Credito
            // 
            this.Credito.AutoSize = true;
            this.Credito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credito.Location = new System.Drawing.Point(98, 33);
            this.Credito.Name = "Credito";
            this.Credito.Size = new System.Drawing.Size(89, 28);
            this.Credito.TabIndex = 1;
            this.Credito.Text = "Credito";
            this.Credito.UseVisualStyleBackColor = true;
            // 
            // Debito
            // 
            this.Debito.AutoSize = true;
            this.Debito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Debito.Location = new System.Drawing.Point(9, 33);
            this.Debito.Name = "Debito";
            this.Debito.Size = new System.Drawing.Size(83, 28);
            this.Debito.TabIndex = 0;
            this.Debito.Text = "Debito";
            this.Debito.UseVisualStyleBackColor = true;
>>>>>>> 83d6ebc29bd46b46f094f39f911168cdee21d2f7
            // 
            // panel_uf
            // 
            this.panel_uf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_uf.BackColor = System.Drawing.Color.Silver;
            this.panel_uf.Location = new System.Drawing.Point(67, 434);
            this.panel_uf.Margin = new System.Windows.Forms.Padding(4);
            this.panel_uf.Name = "panel_uf";
            this.panel_uf.Size = new System.Drawing.Size(399, 4);
            this.panel_uf.TabIndex = 27;
            // 
            // txtUF
            // 
<<<<<<< HEAD
            this.txtUF.AutoCompleteCustomSource.AddRange(new string[] {
=======
            this.Uf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Uf.AutoCompleteCustomSource.AddRange(new string[] {
>>>>>>> 83d6ebc29bd46b46f094f39f911168cdee21d2f7
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
<<<<<<< HEAD
            this.txtUF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUF.BackColor = System.Drawing.Color.White;
            this.txtUF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUF.ForeColor = System.Drawing.Color.Silver;
            this.txtUF.Location = new System.Drawing.Point(67, 399);
            this.txtUF.Margin = new System.Windows.Forms.Padding(4);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(400, 39);
            this.txtUF.TabIndex = 6;
            this.txtUF.Text = "UF";
            this.txtUF.Enter += new System.EventHandler(this.Uf_Enter);
            this.txtUF.Leave += new System.EventHandler(this.Uf_Leave);
            // 
            // erroP
            // 
            this.erroP.BlinkRate = 0;
            this.erroP.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erroP.ContainerControl = this;
=======
            this.Uf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Uf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Uf.BackColor = System.Drawing.Color.GhostWhite;
            this.Uf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Uf.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uf.ForeColor = System.Drawing.Color.Silver;
            this.Uf.Location = new System.Drawing.Point(439, 235);
            this.Uf.Name = "Uf";
            this.Uf.Size = new System.Drawing.Size(300, 31);
            this.Uf.TabIndex = 26;
            this.Uf.Text = "UF";
            this.Uf.Enter += new System.EventHandler(this.Uf_Enter);
            this.Uf.Leave += new System.EventHandler(this.Uf_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
>>>>>>> 83d6ebc29bd46b46f094f39f911168cdee21d2f7
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
=======
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
>>>>>>> 83d6ebc29bd46b46f094f39f911168cdee21d2f7
            this.Controls.Add(this.panel_uf);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.gpxFormaPagamento);
            this.Controls.Add(this.panel_comfirmsenha);
            this.Controls.Add(this.txtConfirmSenha);
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
<<<<<<< HEAD
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Cadastro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpxFormaPagamento.ResumeLayout(false);
            this.gpxFormaPagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroP)).EndInit();
=======
            this.Controls.Add(this.Endereco);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Cadastro";
            this.ShowIcon = false;
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
>>>>>>> 83d6ebc29bd46b46f094f39f911168cdee21d2f7
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
<<<<<<< HEAD

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
=======
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
>>>>>>> 83d6ebc29bd46b46f094f39f911168cdee21d2f7
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
        private System.Windows.Forms.TextBox txtConfirmSenha;
        private System.Windows.Forms.GroupBox gpxFormaPagamento;
        private System.Windows.Forms.Panel panel_uf;
<<<<<<< HEAD
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.CheckBox chkDinheiro;
        private System.Windows.Forms.CheckBox chkCredito;
        private System.Windows.Forms.CheckBox chkDebito;
        private System.Windows.Forms.ErrorProvider erroP;
=======
        private System.Windows.Forms.TextBox Uf;
        private System.Windows.Forms.CheckBox Dinheiro;
        private System.Windows.Forms.CheckBox Credito;
        private System.Windows.Forms.CheckBox Debito;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
>>>>>>> 83d6ebc29bd46b46f094f39f911168cdee21d2f7
    }
}