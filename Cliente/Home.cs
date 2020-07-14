using Newtonsoft.Json;
using System;
using System.Data.SQLite;
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
        string nomes, id, nomeservicos;
        int idd = 0,posicliente;
        dynamic servi;
        
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
                int nomeposi = new int();
                nomeposi = i + 1;

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

                    nomes = label.Text;

                    servicoslista.Controls.Clear();

                    pegardados();

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

        public void pegardados()
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://adsangelinabancodedados.uc.r.appspot.com/empresa/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    nome = nomes.Trim()
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
            cidade.Text = m.cidade;
            telefone.Text = m.telefone;
            numero.Text = m.numero;
            rua.Text = m.endereco;
            id = m.id;

            servicos();

        }

        private void servicos()
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://adsangelinabancodedados.uc.r.appspot.com/servicoget/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    id = id
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

            nomeservicos = m.nome;
            string idservico = m.id;
            var idservicosa = idservico.ToArray();
            servi = m;
            var nomeservicosarrey = nomeservicos.ToArray();
            int qt = 0;

            for (int s = 0; s < nomeservicos.Length; s++)
            {
                if (s == 0)
                {
                    qt++;
                }
                if (nomeservicosarrey[s] == ' ')
                {
                    qt++;
                }
            }
            int n = 0;
            int o = 0, g = 0;
            for (int i = 0; i < qt + 1; i++)
            {
                String nome = "";
                string idser = "";
                RadioButton servi = new RadioButton();
                servi.ForeColor = Color.White;
                servi.Location = new Point(0,n);
                int nomeposi = new int();
                int idservi = new int();
                nomeposi = i + 1;
                
                for (; o < nomeservicos.Length; o++)
                {
                    if (nomeservicosarrey[o] == ' ')
                    {
                        break;
                    }
                    if (nomeservicosarrey[o] == '"')
                    {

                    }
                    else if (nomeservicosarrey[o] != ' ')
                    {
                        nome += nomeservicosarrey[o];
                    }
                }

                try
                {
                    for (; g < idservico.Length; g++)
                    {
                        if (idservicosa[g] == ' ')
                        {
                            break;
                        }
                        if (idservicosa[g] == '"')
                        {

                        }
                        else if (idservicosa[g] != ' ')
                        {
                            idser += idservicosa[g];
                        }
                    }

                    idservi = Convert.ToInt32(idser.Trim());
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }

                servi.Text = nome;


                servi.Click += new EventHandler(btt);

                void btt(Object sender, EventArgs e)
                {
                    posicliente = idservi;
                    //MessageBox.Show(idservi.ToString());
                }

                if (servi.Text != "")
                {
                    servicoslista.Controls.Add(servi);
                }

                nome = "";
                idser = "";
                n += 25;
                o++;
                g++;
            }
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
                SQLiteConnection ligacao = new SQLiteConnection();
                ligacao.ConnectionString = @"Data source = dados.db; Version=3;";
                ligacao.Open();
                string query = "SELECT * FROM login";
                SQLiteCommand dataa = new SQLiteCommand(query, ligacao);
                SQLiteDataReader rdr = dataa.ExecuteReader();

                while (rdr.Read())
                {
                    idd = rdr.GetInt32(0);
                }

                var ar = nomeservicos.ToArray();
                int qtd = 0;

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
                        id_clientes = idd,
                        id_empresa = id,
                        id_servicos = posicliente
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

                data.Text = "";
                horario.Text = "";
                MessageBox.Show("Agendado com sucesso");
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
        }
    }
}
