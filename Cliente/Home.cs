using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Home : Form
    {
        int cdempresa = 0, cdcliente = 0;
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

                flow.Click += new EventHandler(bt);

                void bt(Object sender, EventArgs e)
                {
                    text.Text = label.Text;

                    string nomes = label.Text;



                    pegardados("teste");
                 
                }

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

        public void pegardados(string nome)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://adsangelinabancodedados.uc.r.appspot.com/empresa/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    nome = nome,
                });
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var stream = httpResponse.GetResponseStream();
            var sr = new StreamReader(stream);
            var content = sr.ReadToEnd();
            dynamic m = JsonConvert.DeserializeObject(content);

            panel1.Visible = true;
            numero.Text = m.numero;
            telefone.Text = m.telefone;
            cidade.Text = m.cidade;
            cdcliente = 1;
            cdempresa = m.id;

            rua.Text = m.endereco;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://adsangelinabancodedados.uc.r.appspot.com/cliente/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    data = data.Text,
	                horarioinicio = horario.Text,
	                id_clientes = 1,
	                id_empresa = 2
                });
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var stream = httpResponse.GetResponseStream();
            var sr = new StreamReader(stream);
            var content = sr.ReadToEnd();
            dynamic m = JsonConvert.DeserializeObject(content);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
        }
    }
}
