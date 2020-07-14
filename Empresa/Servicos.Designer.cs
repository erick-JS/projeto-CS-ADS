namespace Empresa
{
    partial class Servicos
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
            this.pnlServico = new System.Windows.Forms.Panel();
            this.pnlPreco = new System.Windows.Forms.Panel();
            this.pnlTempo = new System.Windows.Forms.Panel();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.mstTempoEstimado = new System.Windows.Forms.MaskedTextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.servicospanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.descricao = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.nomedoservico = new System.Windows.Forms.TextBox();
            this.tempodoservico = new System.Windows.Forms.TextBox();
            this.precodoservico = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvarDados = new System.Windows.Forms.Button();
            this.btnEditarDAdos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.descricao.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 81);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serviços";
            // 
            // pnlServico
            // 
            this.pnlServico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlServico.BackColor = System.Drawing.Color.Silver;
            this.pnlServico.Location = new System.Drawing.Point(26, 69);
            this.pnlServico.Name = "pnlServico";
            this.pnlServico.Size = new System.Drawing.Size(299, 3);
            this.pnlServico.TabIndex = 10;
            // 
            // pnlPreco
            // 
            this.pnlPreco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPreco.BackColor = System.Drawing.Color.Silver;
            this.pnlPreco.Location = new System.Drawing.Point(26, 130);
            this.pnlPreco.Name = "pnlPreco";
            this.pnlPreco.Size = new System.Drawing.Size(299, 3);
            this.pnlPreco.TabIndex = 12;
            // 
            // pnlTempo
            // 
            this.pnlTempo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTempo.BackColor = System.Drawing.Color.Silver;
            this.pnlTempo.Location = new System.Drawing.Point(26, 199);
            this.pnlTempo.Name = "pnlTempo";
            this.pnlTempo.Size = new System.Drawing.Size(299, 3);
            this.pnlTempo.TabIndex = 14;
            // 
            // txtServico
            // 
            this.txtServico.BackColor = System.Drawing.SystemColors.Control;
            this.txtServico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServico.ForeColor = System.Drawing.Color.Silver;
            this.txtServico.Location = new System.Drawing.Point(26, 37);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(300, 30);
            this.txtServico.TabIndex = 0;
            this.txtServico.Text = "Serviço";
            this.txtServico.Enter += new System.EventHandler(this.txtServico_Enter);
            this.txtServico.Leave += new System.EventHandler(this.txtServico_Leave);
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.SystemColors.Control;
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.ForeColor = System.Drawing.Color.Silver;
            this.txtPreco.Location = new System.Drawing.Point(26, 94);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(300, 30);
            this.txtPreco.TabIndex = 1;
            this.txtPreco.Text = "Preço";
            this.txtPreco.Enter += new System.EventHandler(this.txtPreco_Enter);
            this.txtPreco.Leave += new System.EventHandler(this.txtPreco_Leave);
            // 
            // mstTempoEstimado
            // 
            this.mstTempoEstimado.BackColor = System.Drawing.SystemColors.Control;
            this.mstTempoEstimado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mstTempoEstimado.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstTempoEstimado.ForeColor = System.Drawing.Color.Silver;
            this.mstTempoEstimado.Location = new System.Drawing.Point(26, 164);
            this.mstTempoEstimado.Margin = new System.Windows.Forms.Padding(2);
            this.mstTempoEstimado.Name = "mstTempoEstimado";
            this.mstTempoEstimado.Size = new System.Drawing.Size(300, 30);
            this.mstTempoEstimado.TabIndex = 2;
            this.mstTempoEstimado.Text = "Tempo estimado";
            this.mstTempoEstimado.ValidatingType = typeof(System.DateTime);
            this.mstTempoEstimado.Enter += new System.EventHandler(this.mstTempoEstimado_Enter);
            this.mstTempoEstimado.Leave += new System.EventHandler(this.mstTempoEstimado_Leave);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Location = new System.Drawing.Point(97, 228);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(127, 46);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Adicionar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.descricao);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.servicospanel);
            this.panel3.Controls.Add(this.btnConfirmar);
            this.panel3.Controls.Add(this.pnlServico);
            this.panel3.Controls.Add(this.pnlPreco);
            this.panel3.Controls.Add(this.pnlTempo);
            this.panel3.Controls.Add(this.txtServico);
            this.panel3.Controls.Add(this.mstTempoEstimado);
            this.panel3.Controls.Add(this.txtPreco);
            this.panel3.Location = new System.Drawing.Point(0, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(688, 379);
            this.panel3.TabIndex = 22;
            // 
            // servicospanel
            // 
            this.servicospanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.servicospanel.AutoScroll = true;
            this.servicospanel.BackColor = System.Drawing.Color.Gainsboro;
            this.servicospanel.Location = new System.Drawing.Point(359, 37);
            this.servicospanel.Name = "servicospanel";
            this.servicospanel.Size = new System.Drawing.Size(317, 237);
            this.servicospanel.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(470, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Serviços";
            // 
            // descricao
            // 
            this.descricao.BackColor = System.Drawing.Color.Gainsboro;
            this.descricao.Controls.Add(this.btnEditarDAdos);
            this.descricao.Controls.Add(this.btnSalvarDados);
            this.descricao.Controls.Add(this.label5);
            this.descricao.Controls.Add(this.label4);
            this.descricao.Controls.Add(this.label3);
            this.descricao.Controls.Add(this.delete);
            this.descricao.Controls.Add(this.precodoservico);
            this.descricao.Controls.Add(this.tempodoservico);
            this.descricao.Controls.Add(this.nomedoservico);
            this.descricao.Controls.Add(this.button1);
            this.descricao.Location = new System.Drawing.Point(9, 10);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(667, 334);
            this.descricao.TabIndex = 17;
            this.descricao.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(571, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nomedoservico
            // 
            this.nomedoservico.Enabled = false;
            this.nomedoservico.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomedoservico.Location = new System.Drawing.Point(3, 27);
            this.nomedoservico.Name = "nomedoservico";
            this.nomedoservico.Size = new System.Drawing.Size(251, 38);
            this.nomedoservico.TabIndex = 1;
            // 
            // tempodoservico
            // 
            this.tempodoservico.Enabled = false;
            this.tempodoservico.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempodoservico.Location = new System.Drawing.Point(3, 149);
            this.tempodoservico.Name = "tempodoservico";
            this.tempodoservico.Size = new System.Drawing.Size(251, 38);
            this.tempodoservico.TabIndex = 2;
            // 
            // precodoservico
            // 
            this.precodoservico.Enabled = false;
            this.precodoservico.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precodoservico.Location = new System.Drawing.Point(3, 87);
            this.precodoservico.Name = "precodoservico";
            this.precodoservico.Size = new System.Drawing.Size(251, 38);
            this.precodoservico.TabIndex = 3;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.DarkRed;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(0, 278);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(254, 34);
            this.delete.TabIndex = 4;
            this.delete.Text = "Deletar";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tempo";
            // 
            // btnSalvarDados
            // 
            this.btnSalvarDados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvarDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSalvarDados.Enabled = false;
            this.btnSalvarDados.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvarDados.FlatAppearance.BorderSize = 0;
            this.btnSalvarDados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvarDados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSalvarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarDados.Location = new System.Drawing.Point(3, 238);
            this.btnSalvarDados.Name = "btnSalvarDados";
            this.btnSalvarDados.Size = new System.Drawing.Size(251, 34);
            this.btnSalvarDados.TabIndex = 11;
            this.btnSalvarDados.Text = "Salvar";
            this.btnSalvarDados.UseVisualStyleBackColor = false;
            this.btnSalvarDados.Click += new System.EventHandler(this.btnSalvarDados_Click);
            // 
            // btnEditarDAdos
            // 
            this.btnEditarDAdos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditarDAdos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnEditarDAdos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarDAdos.FlatAppearance.BorderSize = 0;
            this.btnEditarDAdos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditarDAdos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnEditarDAdos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarDAdos.Location = new System.Drawing.Point(3, 198);
            this.btnEditarDAdos.Name = "btnEditarDAdos";
            this.btnEditarDAdos.Size = new System.Drawing.Size(251, 34);
            this.btnEditarDAdos.TabIndex = 12;
            this.btnEditarDAdos.Text = "Editar";
            this.btnEditarDAdos.UseVisualStyleBackColor = false;
            this.btnEditarDAdos.Click += new System.EventHandler(this.btnEditarDAdos_Click);
            // 
            // Servicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(688, 475);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Servicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Servicos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.descricao.ResumeLayout(false);
            this.descricao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlServico;
        private System.Windows.Forms.Panel pnlPreco;
        private System.Windows.Forms.Panel pnlTempo;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.MaskedTextBox mstTempoEstimado;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel servicospanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel descricao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox precodoservico;
        private System.Windows.Forms.TextBox tempodoservico;
        private System.Windows.Forms.TextBox nomedoservico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button btnSalvarDados;
        private System.Windows.Forms.Button btnEditarDAdos;
    }
}