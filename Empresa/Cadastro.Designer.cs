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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_nome = new System.Windows.Forms.Panel();
            this.Nome = new System.Windows.Forms.TextBox();
            this.panel_endereco = new System.Windows.Forms.Panel();
            this.Endereco = new System.Windows.Forms.TextBox();
            this.panel_bairro = new System.Windows.Forms.Panel();
            this.Bairro = new System.Windows.Forms.TextBox();
            this.panel_cidade = new System.Windows.Forms.Panel();
            this.panel_number = new System.Windows.Forms.Panel();
            this.Cidade = new System.Windows.Forms.TextBox();
            this.panel_telefone = new System.Windows.Forms.Panel();
            this.number = new System.Windows.Forms.TextBox();
            this.Telefone = new System.Windows.Forms.TextBox();
            this.panel_senha = new System.Windows.Forms.Panel();
            this.Senha = new System.Windows.Forms.TextBox();
            this.panel_usuario = new System.Windows.Forms.Panel();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.panel_comfirmsenha = new System.Windows.Forms.Panel();
            this.ComfirmSenha = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dinheiro = new System.Windows.Forms.CheckBox();
            this.Credito = new System.Windows.Forms.CheckBox();
            this.Debito = new System.Windows.Forms.CheckBox();
            this.panel_uf = new System.Windows.Forms.Panel();
            this.Uf = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button3 = new System.Windows.Forms.Button();
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 38);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // button1
            // 
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
            // 
            // panel_nome
            // 
            this.panel_nome.BackColor = System.Drawing.Color.Silver;
            this.panel_nome.Location = new System.Drawing.Point(52, 117);
            this.panel_nome.Name = "panel_nome";
            this.panel_nome.Size = new System.Drawing.Size(299, 3);
            this.panel_nome.TabIndex = 8;
            // 
            // Nome
            // 
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
            // 
            // panel_endereco
            // 
            this.panel_endereco.BackColor = System.Drawing.Color.Silver;
            this.panel_endereco.Location = new System.Drawing.Point(52, 166);
            this.panel_endereco.Name = "panel_endereco";
            this.panel_endereco.Size = new System.Drawing.Size(299, 3);
            this.panel_endereco.TabIndex = 10;
            // 
            // Endereco
            // 
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
            // 
            // panel_bairro
            // 
            this.panel_bairro.BackColor = System.Drawing.Color.Silver;
            this.panel_bairro.Location = new System.Drawing.Point(51, 214);
            this.panel_bairro.Name = "panel_bairro";
            this.panel_bairro.Size = new System.Drawing.Size(299, 3);
            this.panel_bairro.TabIndex = 12;
            // 
            // Bairro
            // 
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
            // 
            // panel_cidade
            // 
            this.panel_cidade.BackColor = System.Drawing.Color.Silver;
            this.panel_cidade.Location = new System.Drawing.Point(438, 214);
            this.panel_cidade.Name = "panel_cidade";
            this.panel_cidade.Size = new System.Drawing.Size(299, 3);
            this.panel_cidade.TabIndex = 18;
            // 
            // panel_number
            // 
            this.panel_number.BackColor = System.Drawing.Color.Silver;
            this.panel_number.Location = new System.Drawing.Point(439, 166);
            this.panel_number.Name = "panel_number";
            this.panel_number.Size = new System.Drawing.Size(299, 3);
            this.panel_number.TabIndex = 16;
            // 
            // Cidade
            // 
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
            // 
            // panel_telefone
            // 
            this.panel_telefone.BackColor = System.Drawing.Color.Silver;
            this.panel_telefone.Location = new System.Drawing.Point(439, 117);
            this.panel_telefone.Name = "panel_telefone";
            this.panel_telefone.Size = new System.Drawing.Size(299, 3);
            this.panel_telefone.TabIndex = 14;
            // 
            // number
            // 
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
            // 
            // panel_senha
            // 
            this.panel_senha.BackColor = System.Drawing.Color.Silver;
            this.panel_senha.Location = new System.Drawing.Point(52, 314);
            this.panel_senha.Name = "panel_senha";
            this.panel_senha.Size = new System.Drawing.Size(299, 3);
            this.panel_senha.TabIndex = 22;
            // 
            // Senha
            // 
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
            // 
            // panel_usuario
            // 
            this.panel_usuario.BackColor = System.Drawing.Color.Silver;
            this.panel_usuario.Location = new System.Drawing.Point(50, 263);
            this.panel_usuario.Name = "panel_usuario";
            this.panel_usuario.Size = new System.Drawing.Size(299, 3);
            this.panel_usuario.TabIndex = 20;
            // 
            // Usuario
            // 
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
            // 
            // panel_comfirmsenha
            // 
            this.panel_comfirmsenha.BackColor = System.Drawing.Color.Silver;
            this.panel_comfirmsenha.Location = new System.Drawing.Point(51, 365);
            this.panel_comfirmsenha.Name = "panel_comfirmsenha";
            this.panel_comfirmsenha.Size = new System.Drawing.Size(299, 3);
            this.panel_comfirmsenha.TabIndex = 24;
            // 
            // ComfirmSenha
            // 
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
            // 
            // panel_uf
            // 
            this.panel_uf.BackColor = System.Drawing.Color.Silver;
            this.panel_uf.Location = new System.Drawing.Point(439, 263);
            this.panel_uf.Name = "panel_uf";
            this.panel_uf.Size = new System.Drawing.Size(299, 3);
            this.panel_uf.TabIndex = 27;
            // 
            // Uf
            // 
            this.Uf.AutoCompleteCustomSource.AddRange(new string[] {
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
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(744, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 38);
            this.button3.TabIndex = 1;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_uf);
            this.Controls.Add(this.Uf);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel_comfirmsenha);
            this.Controls.Add(this.ComfirmSenha);
            this.Controls.Add(this.panel_senha);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.panel_usuario);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.panel_cidade);
            this.Controls.Add(this.panel_number);
            this.Controls.Add(this.Cidade);
            this.Controls.Add(this.panel_telefone);
            this.Controls.Add(this.number);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.panel_bairro);
            this.Controls.Add(this.panel_endereco);
            this.Controls.Add(this.Bairro);
            this.Controls.Add(this.panel_nome);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel_nome;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Panel panel_endereco;
        private System.Windows.Forms.TextBox Endereco;
        private System.Windows.Forms.Panel panel_bairro;
        private System.Windows.Forms.TextBox Bairro;
        private System.Windows.Forms.Panel panel_cidade;
        private System.Windows.Forms.Panel panel_number;
        private System.Windows.Forms.TextBox Cidade;
        private System.Windows.Forms.Panel panel_telefone;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox Telefone;
        private System.Windows.Forms.Panel panel_senha;
        private System.Windows.Forms.TextBox Senha;
        private System.Windows.Forms.Panel panel_usuario;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.Panel panel_comfirmsenha;
        private System.Windows.Forms.TextBox ComfirmSenha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel_uf;
        private System.Windows.Forms.TextBox Uf;
        private System.Windows.Forms.CheckBox Dinheiro;
        private System.Windows.Forms.CheckBox Credito;
        private System.Windows.Forms.CheckBox Debito;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
    }
}