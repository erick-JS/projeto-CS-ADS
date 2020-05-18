namespace Empresa
{
    partial class Login
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
            this.button1 = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.TextBox();
            this.Passwd = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_user = new System.Windows.Forms.Panel();
            this.panel_passwd = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(210, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.Color.White;
            this.User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.Silver;
            this.User.Location = new System.Drawing.Point(12, 74);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(300, 31);
            this.User.TabIndex = 1;
            this.User.Text = "Usuario";
            this.User.Enter += new System.EventHandler(this.User_Enter);
            this.User.Leave += new System.EventHandler(this.User_Leave);
            // 
            // Passwd
            // 
            this.Passwd.BackColor = System.Drawing.Color.White;
            this.Passwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwd.ForeColor = System.Drawing.Color.Silver;
            this.Passwd.Location = new System.Drawing.Point(12, 149);
            this.Passwd.Name = "Passwd";
            this.Passwd.Size = new System.Drawing.Size(300, 31);
            this.Passwd.TabIndex = 2;
            this.Passwd.Text = "Senha";
            this.Passwd.Enter += new System.EventHandler(this.Passwd_Enter);
            this.Passwd.Leave += new System.EventHandler(this.Passwd_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel_user
            // 
            this.panel_user.BackColor = System.Drawing.Color.Silver;
            this.panel_user.Location = new System.Drawing.Point(12, 102);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(299, 3);
            this.panel_user.TabIndex = 6;
            // 
            // panel_passwd
            // 
            this.panel_passwd.BackColor = System.Drawing.Color.Silver;
            this.panel_passwd.Location = new System.Drawing.Point(13, 177);
            this.panel_passwd.Name = "panel_passwd";
            this.panel_passwd.Size = new System.Drawing.Size(299, 3);
            this.panel_passwd.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Login";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 37);
            this.panel2.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(324, 269);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_passwd);
            this.Controls.Add(this.panel_user);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Passwd);
            this.Controls.Add(this.User);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Passwd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel_user;
        private System.Windows.Forms.Panel panel_passwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}