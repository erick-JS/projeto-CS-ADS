namespace Empresa
{
    partial class Atendimento
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
            this.gpxDiasSemana = new System.Windows.Forms.GroupBox();
            this.chkQuarta = new System.Windows.Forms.CheckBox();
            this.chkTerca = new System.Windows.Forms.CheckBox();
            this.chkSegunda = new System.Windows.Forms.CheckBox();
            this.chkSabado = new System.Windows.Forms.CheckBox();
            this.chkSexta = new System.Windows.Forms.CheckBox();
            this.chkQuinta = new System.Windows.Forms.CheckBox();
            this.chkDomingo = new System.Windows.Forms.CheckBox();
            this.gpxHoraAtendimento = new System.Windows.Forms.GroupBox();
            this.panel_nome = new System.Windows.Forms.Panel();
            this.mktHorarioAbre = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mktHorarioFecha = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gpxFimSemana = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mktFechaSab = new System.Windows.Forms.MaskedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.mktAbreSab = new System.Windows.Forms.MaskedTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.mktFechaDom = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.mktAbreDom = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gpxFeriados = new System.Windows.Forms.GroupBox();
            this.chkFeriado = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mktFechaFeriado = new System.Windows.Forms.MaskedTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.mktAbreFeriado = new System.Windows.Forms.MaskedTextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.gpxFormaPagamento = new System.Windows.Forms.GroupBox();
            this.chkDinheiro = new System.Windows.Forms.CheckBox();
            this.chkCredito = new System.Windows.Forms.CheckBox();
            this.chkDebito = new System.Windows.Forms.CheckBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gpxDiasSemana.SuspendLayout();
            this.gpxHoraAtendimento.SuspendLayout();
            this.gpxFimSemana.SuspendLayout();
            this.gpxFeriados.SuspendLayout();
            this.gpxFormaPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 72);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Atendimento";
            // 
            // gpxDiasSemana
            // 
            this.gpxDiasSemana.Controls.Add(this.chkDomingo);
            this.gpxDiasSemana.Controls.Add(this.chkSabado);
            this.gpxDiasSemana.Controls.Add(this.chkSexta);
            this.gpxDiasSemana.Controls.Add(this.chkQuinta);
            this.gpxDiasSemana.Controls.Add(this.chkQuarta);
            this.gpxDiasSemana.Controls.Add(this.chkTerca);
            this.gpxDiasSemana.Controls.Add(this.chkSegunda);
            this.gpxDiasSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxDiasSemana.Location = new System.Drawing.Point(15, 188);
            this.gpxDiasSemana.Margin = new System.Windows.Forms.Padding(4);
            this.gpxDiasSemana.Name = "gpxDiasSemana";
            this.gpxDiasSemana.Padding = new System.Windows.Forms.Padding(4);
            this.gpxDiasSemana.Size = new System.Drawing.Size(399, 168);
            this.gpxDiasSemana.TabIndex = 3;
            this.gpxDiasSemana.TabStop = false;
            this.gpxDiasSemana.Text = "Dias de atendimento";
            // 
            // chkQuarta
            // 
            this.chkQuarta.AutoSize = true;
            this.chkQuarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkQuarta.Location = new System.Drawing.Point(12, 123);
            this.chkQuarta.Margin = new System.Windows.Forms.Padding(4);
            this.chkQuarta.Name = "chkQuarta";
            this.chkQuarta.Size = new System.Drawing.Size(107, 33);
            this.chkQuarta.TabIndex = 6;
            this.chkQuarta.Text = "Quarta";
            this.chkQuarta.UseVisualStyleBackColor = true;
            // 
            // chkTerca
            // 
            this.chkTerca.AutoSize = true;
            this.chkTerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTerca.Location = new System.Drawing.Point(12, 82);
            this.chkTerca.Margin = new System.Windows.Forms.Padding(4);
            this.chkTerca.Name = "chkTerca";
            this.chkTerca.Size = new System.Drawing.Size(98, 33);
            this.chkTerca.TabIndex = 5;
            this.chkTerca.Text = "Terça";
            this.chkTerca.UseVisualStyleBackColor = true;
            // 
            // chkSegunda
            // 
            this.chkSegunda.AutoSize = true;
            this.chkSegunda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSegunda.Location = new System.Drawing.Point(12, 41);
            this.chkSegunda.Margin = new System.Windows.Forms.Padding(4);
            this.chkSegunda.Name = "chkSegunda";
            this.chkSegunda.Size = new System.Drawing.Size(132, 33);
            this.chkSegunda.TabIndex = 4;
            this.chkSegunda.Text = "Segunda";
            this.chkSegunda.UseVisualStyleBackColor = true;
            // 
            // chkSabado
            // 
            this.chkSabado.AutoSize = true;
            this.chkSabado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSabado.Location = new System.Drawing.Point(152, 123);
            this.chkSabado.Margin = new System.Windows.Forms.Padding(4);
            this.chkSabado.Name = "chkSabado";
            this.chkSabado.Size = new System.Drawing.Size(119, 33);
            this.chkSabado.TabIndex = 9;
            this.chkSabado.Text = "Sábado";
            this.chkSabado.UseVisualStyleBackColor = true;
            // 
            // chkSexta
            // 
            this.chkSexta.AutoSize = true;
            this.chkSexta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSexta.Location = new System.Drawing.Point(152, 82);
            this.chkSexta.Margin = new System.Windows.Forms.Padding(4);
            this.chkSexta.Name = "chkSexta";
            this.chkSexta.Size = new System.Drawing.Size(95, 33);
            this.chkSexta.TabIndex = 8;
            this.chkSexta.Text = "Sexta";
            this.chkSexta.UseVisualStyleBackColor = true;
            // 
            // chkQuinta
            // 
            this.chkQuinta.AutoSize = true;
            this.chkQuinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkQuinta.Location = new System.Drawing.Point(152, 41);
            this.chkQuinta.Margin = new System.Windows.Forms.Padding(4);
            this.chkQuinta.Name = "chkQuinta";
            this.chkQuinta.Size = new System.Drawing.Size(105, 33);
            this.chkQuinta.TabIndex = 7;
            this.chkQuinta.Text = "Quinta";
            this.chkQuinta.UseVisualStyleBackColor = true;
            // 
            // chkDomingo
            // 
            this.chkDomingo.AutoSize = true;
            this.chkDomingo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDomingo.Location = new System.Drawing.Point(265, 41);
            this.chkDomingo.Margin = new System.Windows.Forms.Padding(4);
            this.chkDomingo.Name = "chkDomingo";
            this.chkDomingo.Size = new System.Drawing.Size(133, 33);
            this.chkDomingo.TabIndex = 10;
            this.chkDomingo.Text = "Domingo";
            this.chkDomingo.UseVisualStyleBackColor = true;
            // 
            // gpxHoraAtendimento
            // 
            this.gpxHoraAtendimento.Controls.Add(this.label3);
            this.gpxHoraAtendimento.Controls.Add(this.mktHorarioFecha);
            this.gpxHoraAtendimento.Controls.Add(this.panel2);
            this.gpxHoraAtendimento.Controls.Add(this.label2);
            this.gpxHoraAtendimento.Controls.Add(this.mktHorarioAbre);
            this.gpxHoraAtendimento.Controls.Add(this.panel_nome);
            this.gpxHoraAtendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxHoraAtendimento.Location = new System.Drawing.Point(15, 78);
            this.gpxHoraAtendimento.Margin = new System.Windows.Forms.Padding(4);
            this.gpxHoraAtendimento.Name = "gpxHoraAtendimento";
            this.gpxHoraAtendimento.Padding = new System.Windows.Forms.Padding(4);
            this.gpxHoraAtendimento.Size = new System.Drawing.Size(399, 102);
            this.gpxHoraAtendimento.TabIndex = 0;
            this.gpxHoraAtendimento.TabStop = false;
            this.gpxHoraAtendimento.Text = "Horário de atendimento";
            // 
            // panel_nome
            // 
            this.panel_nome.BackColor = System.Drawing.Color.Silver;
            this.panel_nome.Location = new System.Drawing.Point(68, 79);
            this.panel_nome.Margin = new System.Windows.Forms.Padding(4);
            this.panel_nome.Name = "panel_nome";
            this.panel_nome.Size = new System.Drawing.Size(61, 4);
            this.panel_nome.TabIndex = 9;
            // 
            // mktHorarioAbre
            // 
            this.mktHorarioAbre.ForeColor = System.Drawing.Color.Silver;
            this.mktHorarioAbre.Location = new System.Drawing.Point(68, 50);
            this.mktHorarioAbre.Mask = "00:00";
            this.mktHorarioAbre.Name = "mktHorarioAbre";
            this.mktHorarioAbre.Size = new System.Drawing.Size(61, 30);
            this.mktHorarioAbre.TabIndex = 1;
            this.mktHorarioAbre.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Abre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fecha";
            // 
            // mktHorarioFecha
            // 
            this.mktHorarioFecha.ForeColor = System.Drawing.Color.Silver;
            this.mktHorarioFecha.Location = new System.Drawing.Point(244, 50);
            this.mktHorarioFecha.Mask = "00:00";
            this.mktHorarioFecha.Name = "mktHorarioFecha";
            this.mktHorarioFecha.Size = new System.Drawing.Size(61, 30);
            this.mktHorarioFecha.TabIndex = 2;
            this.mktHorarioFecha.ValidatingType = typeof(System.DateTime);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(244, 79);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(61, 4);
            this.panel2.TabIndex = 12;
            // 
            // gpxFimSemana
            // 
            this.gpxFimSemana.Controls.Add(this.label8);
            this.gpxFimSemana.Controls.Add(this.label7);
            this.gpxFimSemana.Controls.Add(this.mktFechaDom);
            this.gpxFimSemana.Controls.Add(this.label9);
            this.gpxFimSemana.Controls.Add(this.panel5);
            this.gpxFimSemana.Controls.Add(this.panel6);
            this.gpxFimSemana.Controls.Add(this.mktAbreDom);
            this.gpxFimSemana.Controls.Add(this.label5);
            this.gpxFimSemana.Controls.Add(this.label4);
            this.gpxFimSemana.Controls.Add(this.mktFechaSab);
            this.gpxFimSemana.Controls.Add(this.label6);
            this.gpxFimSemana.Controls.Add(this.panel3);
            this.gpxFimSemana.Controls.Add(this.panel4);
            this.gpxFimSemana.Controls.Add(this.mktAbreSab);
            this.gpxFimSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxFimSemana.Location = new System.Drawing.Point(15, 364);
            this.gpxFimSemana.Margin = new System.Windows.Forms.Padding(4);
            this.gpxFimSemana.Name = "gpxFimSemana";
            this.gpxFimSemana.Padding = new System.Windows.Forms.Padding(4);
            this.gpxFimSemana.Size = new System.Drawing.Size(399, 129);
            this.gpxFimSemana.TabIndex = 11;
            this.gpxFimSemana.TabStop = false;
            this.gpxFimSemana.Text = "Fim de semana";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sábado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Fecha";
            // 
            // mktFechaSab
            // 
            this.mktFechaSab.ForeColor = System.Drawing.Color.Silver;
            this.mktFechaSab.Location = new System.Drawing.Point(324, 32);
            this.mktFechaSab.Mask = "00:00";
            this.mktFechaSab.Name = "mktFechaSab";
            this.mktFechaSab.Size = new System.Drawing.Size(61, 30);
            this.mktFechaSab.TabIndex = 12;
            this.mktFechaSab.ValidatingType = typeof(System.DateTime);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(324, 61);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(61, 4);
            this.panel3.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Abre";
            // 
            // mktAbreSab
            // 
            this.mktAbreSab.ForeColor = System.Drawing.Color.Silver;
            this.mktAbreSab.Location = new System.Drawing.Point(168, 32);
            this.mktAbreSab.Mask = "00:00";
            this.mktAbreSab.Name = "mktAbreSab";
            this.mktAbreSab.Size = new System.Drawing.Size(61, 30);
            this.mktAbreSab.TabIndex = 11;
            this.mktAbreSab.ValidatingType = typeof(System.DateTime);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(168, 61);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(61, 4);
            this.panel4.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Fecha";
            // 
            // mktFechaDom
            // 
            this.mktFechaDom.ForeColor = System.Drawing.Color.Silver;
            this.mktFechaDom.Location = new System.Drawing.Point(324, 74);
            this.mktFechaDom.Mask = "00:00";
            this.mktFechaDom.Name = "mktFechaDom";
            this.mktFechaDom.Size = new System.Drawing.Size(61, 30);
            this.mktFechaDom.TabIndex = 14;
            this.mktFechaDom.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(107, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Abre";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(324, 103);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(61, 4);
            this.panel5.TabIndex = 26;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Location = new System.Drawing.Point(168, 103);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(61, 4);
            this.panel6.TabIndex = 24;
            // 
            // mktAbreDom
            // 
            this.mktAbreDom.ForeColor = System.Drawing.Color.Silver;
            this.mktAbreDom.Location = new System.Drawing.Point(168, 74);
            this.mktAbreDom.Mask = "00:00";
            this.mktAbreDom.Name = "mktAbreDom";
            this.mktAbreDom.Size = new System.Drawing.Size(61, 30);
            this.mktAbreDom.TabIndex = 13;
            this.mktAbreDom.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Domingo:";
            // 
            // gpxFeriados
            // 
            this.gpxFeriados.Controls.Add(this.label10);
            this.gpxFeriados.Controls.Add(this.chkFeriado);
            this.gpxFeriados.Controls.Add(this.mktFechaFeriado);
            this.gpxFeriados.Controls.Add(this.label11);
            this.gpxFeriados.Controls.Add(this.panel7);
            this.gpxFeriados.Controls.Add(this.panel8);
            this.gpxFeriados.Controls.Add(this.mktAbreFeriado);
            this.gpxFeriados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxFeriados.Location = new System.Drawing.Point(15, 501);
            this.gpxFeriados.Margin = new System.Windows.Forms.Padding(4);
            this.gpxFeriados.Name = "gpxFeriados";
            this.gpxFeriados.Padding = new System.Windows.Forms.Padding(4);
            this.gpxFeriados.Size = new System.Drawing.Size(398, 122);
            this.gpxFeriados.TabIndex = 15;
            this.gpxFeriados.TabStop = false;
            this.gpxFeriados.Text = "Feriados";
            // 
            // chkFeriado
            // 
            this.chkFeriado.AutoSize = true;
            this.chkFeriado.Location = new System.Drawing.Point(7, 30);
            this.chkFeriado.Name = "chkFeriado";
            this.chkFeriado.Size = new System.Drawing.Size(229, 29);
            this.chkFeriado.TabIndex = 15;
            this.chkFeriado.Text = "Trabalha em feriados?";
            this.chkFeriado.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Fecha";
            // 
            // mktFechaFeriado
            // 
            this.mktFechaFeriado.ForeColor = System.Drawing.Color.Silver;
            this.mktFechaFeriado.Location = new System.Drawing.Point(244, 72);
            this.mktFechaFeriado.Mask = "00:00";
            this.mktFechaFeriado.Name = "mktFechaFeriado";
            this.mktFechaFeriado.Size = new System.Drawing.Size(61, 30);
            this.mktFechaFeriado.TabIndex = 17;
            this.mktFechaFeriado.ValidatingType = typeof(System.DateTime);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Location = new System.Drawing.Point(244, 101);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(61, 4);
            this.panel7.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "Abre";
            // 
            // mktAbreFeriado
            // 
            this.mktAbreFeriado.ForeColor = System.Drawing.Color.Silver;
            this.mktAbreFeriado.Location = new System.Drawing.Point(68, 72);
            this.mktAbreFeriado.Mask = "00:00";
            this.mktAbreFeriado.Name = "mktAbreFeriado";
            this.mktAbreFeriado.Size = new System.Drawing.Size(61, 30);
            this.mktAbreFeriado.TabIndex = 16;
            this.mktAbreFeriado.ValidatingType = typeof(System.DateTime);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Silver;
            this.panel8.Location = new System.Drawing.Point(68, 101);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(61, 4);
            this.panel8.TabIndex = 17;
            // 
            // gpxFormaPagamento
            // 
            this.gpxFormaPagamento.Controls.Add(this.chkDinheiro);
            this.gpxFormaPagamento.Controls.Add(this.chkCredito);
            this.gpxFormaPagamento.Controls.Add(this.chkDebito);
            this.gpxFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxFormaPagamento.Location = new System.Drawing.Point(13, 631);
            this.gpxFormaPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.gpxFormaPagamento.Name = "gpxFormaPagamento";
            this.gpxFormaPagamento.Padding = new System.Windows.Forms.Padding(4);
            this.gpxFormaPagamento.Size = new System.Drawing.Size(399, 101);
            this.gpxFormaPagamento.TabIndex = 16;
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
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(14, 740);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(169, 57);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(242, 739);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(169, 57);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // Atendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 809);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gpxFormaPagamento);
            this.Controls.Add(this.gpxFeriados);
            this.Controls.Add(this.gpxFimSemana);
            this.Controls.Add(this.gpxHoraAtendimento);
            this.Controls.Add(this.gpxDiasSemana);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Atendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpxDiasSemana.ResumeLayout(false);
            this.gpxDiasSemana.PerformLayout();
            this.gpxHoraAtendimento.ResumeLayout(false);
            this.gpxHoraAtendimento.PerformLayout();
            this.gpxFimSemana.ResumeLayout(false);
            this.gpxFimSemana.PerformLayout();
            this.gpxFeriados.ResumeLayout(false);
            this.gpxFeriados.PerformLayout();
            this.gpxFormaPagamento.ResumeLayout(false);
            this.gpxFormaPagamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpxDiasSemana;
        private System.Windows.Forms.CheckBox chkQuarta;
        private System.Windows.Forms.CheckBox chkTerca;
        private System.Windows.Forms.CheckBox chkSegunda;
        private System.Windows.Forms.CheckBox chkDomingo;
        private System.Windows.Forms.CheckBox chkSabado;
        private System.Windows.Forms.CheckBox chkSexta;
        private System.Windows.Forms.CheckBox chkQuinta;
        private System.Windows.Forms.GroupBox gpxHoraAtendimento;
        private System.Windows.Forms.Panel panel_nome;
        private System.Windows.Forms.MaskedTextBox mktHorarioAbre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mktHorarioFecha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpxFimSemana;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mktFechaDom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.MaskedTextBox mktAbreDom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mktFechaSab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MaskedTextBox mktAbreSab;
        private System.Windows.Forms.GroupBox gpxFeriados;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkFeriado;
        private System.Windows.Forms.MaskedTextBox mktFechaFeriado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.MaskedTextBox mktAbreFeriado;
        private System.Windows.Forms.GroupBox gpxFormaPagamento;
        private System.Windows.Forms.CheckBox chkDinheiro;
        private System.Windows.Forms.CheckBox chkCredito;
        private System.Windows.Forms.CheckBox chkDebito;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
    }
}