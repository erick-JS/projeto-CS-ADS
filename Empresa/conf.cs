using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa
{
    public partial class Conf : Form
    {
        public Conf()
        {
            InitializeComponent();
        }

        Atendimento aten = new Atendimento();
        Servicos servi = new Servicos();
        Conta cont = new Conta();
        Caixa cai = new Caixa();

        private void btnAtendimento_Click(object sender, EventArgs e)
        {
            aten.TopLevel = false;
            aten.Visible = true;
            servi.Visible = false;
            cont.Visible = false;
            cai.Visible = false;

            info.Controls.Add(aten);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            servi.TopLevel = false;
            servi.Visible = true;
            aten.Visible = false;
            cont.Visible = false;
            cai.Visible = false;

            info.Controls.Add(servi);
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            cai.TopLevel = false;
            cai.Visible = true;
            aten.Visible = false;
            cont.Visible = false;
            servi.Visible = false;

            info.Controls.Add(cai);
        }

        private void btnConta_Click(object sender, EventArgs e)
        {
            cont.TopLevel = false;
            cont.Visible = true;
            servi.Visible = false;
            aten.Visible = false;
            cai.Visible = false;

            info.Controls.Add(cont);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int x, y;
        Point Point = new Point();

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point = Control.MousePosition;
                Point.X -= x;
                Point.Y -= y;
                this.Location = Point;
                Application.DoEvents();
            }
        }
    }
}
