using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            if (!File.Exists(@"dados.db"))
            {
                Close();
                Login newForm2 = new Login();
                newForm2.ShowDialog();
            }

            gerarEmpresas();
                //Button button2 = new Button();
                //button2.Text = "ovo";
                //Controls.Add(button2);
                //Button button1 = new Button();
                //button1.Location = new Point(0,30);
                //Controls.Add(button1);
                
        }

        private void gerarEmpresas()
        {

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://adsangelinabancodedados.uc.r.appspot.com/empresas/");
            httpWebRequest.Method = "GET";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var stream = httpResponse.GetResponseStream();
            var sr = new StreamReader(stream);
            var content = sr.ReadToEnd();

            var ar = content.ToArray();
            int qt = 0;
            for (int i = 0; i < content.Length; i++)
            {
                if (ar[i] == ' ')
                {
                    qt++;
                }
            }

            Console.WriteLine(qt);
            int o = 0;
            for (int i = 0; i < qt+1; i++)
            {
                String nome = "";
                FlowLayoutPanel flow = new FlowLayoutPanel();
                flow.Name = $"flowNome{i}";
                flow.Size = new Size(100, 74);
                flow.BorderStyle = BorderStyle.FixedSingle;
                flow.BackColor = Color.White;
                flow.Location = new Point(7, 40+i * 80);

                for (; o < content.Length; o++)
                {
                    if (ar[o] == ' ')
                    {
                        break;
                    }
                    if (ar[o] == '"')
                    {

                    }
                    else if (ar[o] != ' ')
                    {
                        nome += content[o];
                    }
                }

                Label label = new Label();
                label.Name = $"lblItem{i}";
                label.Text = nome.ToString();

                if (label.Text != " ")
                {
                    flow.Cursor = Cursors.Hand;
                    flow.Controls.Add(label);
                    Controls.Add(flow);
                }
                o++;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        int x, y;
        Point Point = new Point();
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
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

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
        }
    }
}
