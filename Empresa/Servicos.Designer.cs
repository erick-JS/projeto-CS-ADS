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
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.mstTempoEstimado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.servicospanel.Location = new System.Drawing.Point(359, 37);
            this.servicospanel.Name = "servicospanel";
            this.servicospanel.Size = new System.Drawing.Size(317, 237);
            this.servicospanel.TabIndex = 15;
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Servicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Servicos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
    }
}