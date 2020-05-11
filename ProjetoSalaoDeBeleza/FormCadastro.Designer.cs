namespace ProjetoSalaoDeBeleza
{
    partial class FormCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mstTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomePerfil = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gpxFormUsuario = new System.Windows.Forms.GroupBox();
            this.chkDebito = new System.Windows.Forms.CheckBox();
            this.chkCredito = new System.Windows.Forms.CheckBox();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.gpxTipoUsuario = new System.Windows.Forms.GroupBox();
            this.rdbSalaoBeleza = new System.Windows.Forms.RadioButton();
            this.rdbCliente = new System.Windows.Forms.RadioButton();
            this.erro = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpxFormUsuario.SuspendLayout();
            this.gpxTipoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Área de cadastro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoSalaoDeBeleza.Properties.Resources.hairdresser;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 352);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(583, 293);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(152, 53);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome*";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(66, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(230, 22);
            this.txtNome.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefone*";
            // 
            // mstTelefone
            // 
            this.mstTelefone.Location = new System.Drawing.Point(375, 23);
            this.mstTelefone.Mask = "(99) 99999-9999";
            this.mstTelefone.Name = "mstTelefone";
            this.mstTelefone.Size = new System.Drawing.Size(195, 22);
            this.mstTelefone.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Endereço*";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(90, 62);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(252, 22);
            this.txtEndereco.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nº*";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(379, 60);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(191, 22);
            this.txtNumero.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Bairro*";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(67, 97);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(186, 22);
            this.txtBairro.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cidade*";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(317, 94);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(127, 22);
            this.txtCidade.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(450, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "UF*";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF ",
            "ES ",
            "GO",
            "MA",
            "MG",
            "MT",
            "MS",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RS",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboEstado.Location = new System.Drawing.Point(482, 92);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(88, 24);
            this.cboEstado.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Nome Perfil*";
            // 
            // txtNomePerfil
            // 
            this.txtNomePerfil.Location = new System.Drawing.Point(99, 133);
            this.txtNomePerfil.Name = "txtNomePerfil";
            this.txtNomePerfil.Size = new System.Drawing.Size(176, 22);
            this.txtNomePerfil.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(281, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Senha*";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(336, 133);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(176, 22);
            this.txtSenha.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "Confirmar Senha*";
            // 
            // gpxFormUsuario
            // 
            this.gpxFormUsuario.Controls.Add(this.chkDebito);
            this.gpxFormUsuario.Controls.Add(this.chkCredito);
            this.gpxFormUsuario.Controls.Add(this.lblPagamento);
            this.gpxFormUsuario.Controls.Add(this.txtConfirmaSenha);
            this.gpxFormUsuario.Controls.Add(this.label12);
            this.gpxFormUsuario.Controls.Add(this.txtSenha);
            this.gpxFormUsuario.Controls.Add(this.label11);
            this.gpxFormUsuario.Controls.Add(this.txtNomePerfil);
            this.gpxFormUsuario.Controls.Add(this.label10);
            this.gpxFormUsuario.Controls.Add(this.cboEstado);
            this.gpxFormUsuario.Controls.Add(this.label9);
            this.gpxFormUsuario.Controls.Add(this.txtCidade);
            this.gpxFormUsuario.Controls.Add(this.label8);
            this.gpxFormUsuario.Controls.Add(this.txtBairro);
            this.gpxFormUsuario.Controls.Add(this.label7);
            this.gpxFormUsuario.Controls.Add(this.txtNumero);
            this.gpxFormUsuario.Controls.Add(this.label6);
            this.gpxFormUsuario.Controls.Add(this.txtEndereco);
            this.gpxFormUsuario.Controls.Add(this.label5);
            this.gpxFormUsuario.Controls.Add(this.mstTelefone);
            this.gpxFormUsuario.Controls.Add(this.label4);
            this.gpxFormUsuario.Controls.Add(this.txtNome);
            this.gpxFormUsuario.Controls.Add(this.label3);
            this.gpxFormUsuario.Location = new System.Drawing.Point(366, 79);
            this.gpxFormUsuario.Name = "gpxFormUsuario";
            this.gpxFormUsuario.Size = new System.Drawing.Size(576, 208);
            this.gpxFormUsuario.TabIndex = 4;
            this.gpxFormUsuario.TabStop = false;
            this.gpxFormUsuario.Text = "Cliente";
            // 
            // chkDebito
            // 
            this.chkDebito.AutoSize = true;
            this.chkDebito.Location = new System.Drawing.Point(484, 168);
            this.chkDebito.Name = "chkDebito";
            this.chkDebito.Size = new System.Drawing.Size(71, 21);
            this.chkDebito.TabIndex = 22;
            this.chkDebito.Text = "Débito";
            this.chkDebito.UseVisualStyleBackColor = true;
            // 
            // chkCredito
            // 
            this.chkCredito.AutoSize = true;
            this.chkCredito.Location = new System.Drawing.Point(403, 167);
            this.chkCredito.Name = "chkCredito";
            this.chkCredito.Size = new System.Drawing.Size(75, 21);
            this.chkCredito.TabIndex = 21;
            this.chkCredito.Text = "Crédito";
            this.chkCredito.UseVisualStyleBackColor = true;
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Location = new System.Drawing.Point(317, 168);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(80, 17);
            this.lblPagamento.TabIndex = 20;
            this.lblPagamento.Text = "Pagamento";
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Location = new System.Drawing.Point(134, 165);
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.PasswordChar = '*';
            this.txtConfirmaSenha.Size = new System.Drawing.Size(176, 22);
            this.txtConfirmaSenha.TabIndex = 19;
            // 
            // gpxTipoUsuario
            // 
            this.gpxTipoUsuario.Controls.Add(this.rdbSalaoBeleza);
            this.gpxTipoUsuario.Controls.Add(this.rdbCliente);
            this.gpxTipoUsuario.Location = new System.Drawing.Point(366, 34);
            this.gpxTipoUsuario.Name = "gpxTipoUsuario";
            this.gpxTipoUsuario.Size = new System.Drawing.Size(576, 45);
            this.gpxTipoUsuario.TabIndex = 6;
            this.gpxTipoUsuario.TabStop = false;
            this.gpxTipoUsuario.Text = "Quem é você?";
            // 
            // rdbSalaoBeleza
            // 
            this.rdbSalaoBeleza.AutoSize = true;
            this.rdbSalaoBeleza.Location = new System.Drawing.Point(99, 18);
            this.rdbSalaoBeleza.Name = "rdbSalaoBeleza";
            this.rdbSalaoBeleza.Size = new System.Drawing.Size(131, 21);
            this.rdbSalaoBeleza.TabIndex = 1;
            this.rdbSalaoBeleza.TabStop = true;
            this.rdbSalaoBeleza.Text = "Salão de beleza";
            this.rdbSalaoBeleza.UseVisualStyleBackColor = true;
            this.rdbSalaoBeleza.Click += new System.EventHandler(this.rdbSalaoBeleza_Click);
            // 
            // rdbCliente
            // 
            this.rdbCliente.AutoSize = true;
            this.rdbCliente.Location = new System.Drawing.Point(6, 18);
            this.rdbCliente.Name = "rdbCliente";
            this.rdbCliente.Size = new System.Drawing.Size(72, 21);
            this.rdbCliente.TabIndex = 0;
            this.rdbCliente.TabStop = true;
            this.rdbCliente.Text = "Cliente";
            this.rdbCliente.UseVisualStyleBackColor = true;
            this.rdbCliente.Click += new System.EventHandler(this.rdbCliente_Click);
            // 
            // erro
            // 
            this.erro.ContainerControl = this;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 348);
            this.Controls.Add(this.gpxTipoUsuario);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gpxFormUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área de cadastro";
            this.Load += new System.EventHandler(this.FormCadCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpxFormUsuario.ResumeLayout(false);
            this.gpxFormUsuario.PerformLayout();
            this.gpxTipoUsuario.ResumeLayout(false);
            this.gpxTipoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mstTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNomePerfil;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gpxFormUsuario;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.GroupBox gpxTipoUsuario;
        private System.Windows.Forms.RadioButton rdbSalaoBeleza;
        private System.Windows.Forms.RadioButton rdbCliente;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.CheckBox chkDebito;
        private System.Windows.Forms.CheckBox chkCredito;
        private System.Windows.Forms.ErrorProvider erro;
    }
}