namespace Empresa
{
    partial class Caixa
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblReceitaHoje = new System.Windows.Forms.Label();
            this.lblReceitaSemanal = new System.Windows.Forms.Label();
            this.lblReceitaMensal = new System.Windows.Forms.Label();
            this.lblReceitaAnual = new System.Windows.Forms.Label();
            this.chGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cboDados = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chGrafico)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1165, 71);
            this.panel1.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(105, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caixa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblReceitaHoje);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 263);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receita de hoje";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblReceitaSemanal);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(300, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 263);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receita semanal";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblReceitaMensal);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(589, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 263);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Receita mensal";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblReceitaAnual);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(878, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 263);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Receita anual";
            // 
            // lblReceitaHoje
            // 
            this.lblReceitaHoje.AutoSize = true;
            this.lblReceitaHoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceitaHoje.ForeColor = System.Drawing.Color.DarkRed;
            this.lblReceitaHoje.Location = new System.Drawing.Point(21, 109);
            this.lblReceitaHoje.Name = "lblReceitaHoje";
            this.lblReceitaHoje.Size = new System.Drawing.Size(225, 44);
            this.lblReceitaHoje.TabIndex = 0;
            this.lblReceitaHoje.Text = "R$ 1000,00";
            this.lblReceitaHoje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReceitaSemanal
            // 
            this.lblReceitaSemanal.AutoSize = true;
            this.lblReceitaSemanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceitaSemanal.ForeColor = System.Drawing.Color.DarkRed;
            this.lblReceitaSemanal.Location = new System.Drawing.Point(29, 109);
            this.lblReceitaSemanal.Name = "lblReceitaSemanal";
            this.lblReceitaSemanal.Size = new System.Drawing.Size(225, 44);
            this.lblReceitaSemanal.TabIndex = 1;
            this.lblReceitaSemanal.Text = "R$ 6000,00";
            this.lblReceitaSemanal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReceitaMensal
            // 
            this.lblReceitaMensal.AutoSize = true;
            this.lblReceitaMensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceitaMensal.ForeColor = System.Drawing.Color.DarkRed;
            this.lblReceitaMensal.Location = new System.Drawing.Point(29, 109);
            this.lblReceitaMensal.Name = "lblReceitaMensal";
            this.lblReceitaMensal.Size = new System.Drawing.Size(225, 44);
            this.lblReceitaMensal.TabIndex = 1;
            this.lblReceitaMensal.Text = "R$ 8000,00";
            this.lblReceitaMensal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReceitaAnual
            // 
            this.lblReceitaAnual.AutoSize = true;
            this.lblReceitaAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceitaAnual.ForeColor = System.Drawing.Color.DarkRed;
            this.lblReceitaAnual.Location = new System.Drawing.Point(16, 109);
            this.lblReceitaAnual.Name = "lblReceitaAnual";
            this.lblReceitaAnual.Size = new System.Drawing.Size(259, 44);
            this.lblReceitaAnual.TabIndex = 1;
            this.lblReceitaAnual.Text = "R$ 40.000,00";
            this.lblReceitaAnual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chGrafico
            // 
            chartArea1.Name = "ChartArea1";
            this.chGrafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chGrafico.Legends.Add(legend1);
            this.chGrafico.Location = new System.Drawing.Point(11, 430);
            this.chGrafico.Name = "chGrafico";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chGrafico.Series.Add(series1);
            this.chGrafico.Size = new System.Drawing.Size(1142, 258);
            this.chGrafico.TabIndex = 7;
            this.chGrafico.Text = "chart1";
            // 
            // cboDados
            // 
            this.cboDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDados.FormattingEnabled = true;
            this.cboDados.Items.AddRange(new object[] {
            "Semana",
            "Mês",
            "Ano"});
            this.cboDados.Location = new System.Drawing.Point(16, 14);
            this.cboDados.Name = "cboDados";
            this.cboDados.Size = new System.Drawing.Size(254, 33);
            this.cboDados.TabIndex = 9;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Location = new System.Drawing.Point(293, 14);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(144, 33);
            this.btnFiltrar.TabIndex = 10;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFiltrar);
            this.panel2.Controls.Add(this.cboDados);
            this.panel2.Location = new System.Drawing.Point(284, 373);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(447, 66);
            this.panel2.TabIndex = 11;
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 689);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chGrafico);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chGrafico)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblReceitaHoje;
        private System.Windows.Forms.Label lblReceitaSemanal;
        private System.Windows.Forms.Label lblReceitaMensal;
        private System.Windows.Forms.Label lblReceitaAnual;
        private System.Windows.Forms.DataVisualization.Charting.Chart chGrafico;
        private System.Windows.Forms.ComboBox cboDados;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Panel panel2;
    }
}