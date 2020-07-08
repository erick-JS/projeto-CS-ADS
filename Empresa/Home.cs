using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using System.Data.SQLite;
using System.Net;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace Empresa
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            string logado = bd.Logado();

            if (logado != "foi")
           {
               Hide();
               Login newForm2 = new Login();
               newForm2.ShowDialog();
           }
            
           string segunda = bd.GetLogin();

           if (segunda == "")
           {
              Hide();
              preconf newForm2 = new preconf();
              newForm2.ShowDialog();
           }
        
        }
        int k = 0;
        int mes = 1;
        String[] mesExtenso = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
        "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};

        private void gerarTituloMes(int mes)
        {
            lblTitulo.Text = mesExtenso[mes] + ", " + DateTime.Now.Year.ToString();
            lblTitulo.Anchor = AnchorStyles.None;
        }

        private void gerarDias(int mes)
        {
            k = 0;
            //int data = DateTime.DaysInMonth(DateTime.Now.Year, mes);
            gerarCalendario();

            if(mes == 0)
            {
                gerarTituloMes(mes + 1);
            }
            else if(mes == 13)
            {
                gerarTituloMes(0);
            }
            else
            {
                gerarTituloMes(mes - 1);
            }
            
            //Console.WriteLine(mes);
        }

        private int ultimoDia(int mes)
        {
            DateTime dtUltimoDiaMes = new DateTime(DateTime.Now.Year, mes, 1).AddMonths(1).AddDays(-1);
            return Convert.ToInt32(dtUltimoDiaMes.Day);
        }

        private void gerarCalendario()
        {
            flowDias.Controls.Clear();
            DateTime primeiroDia = new DateTime(DateTime.Now.Year, mes, 1);
            int primeiroDiaSem = Convert.ToInt32(primeiroDia.DayOfWeek);
            int j = 1;

            //Console.WriteLine(primeiroDiaSem);
            for (int i = 0; i < 42; i++)
            {
                FlowLayoutPanel flow = new FlowLayoutPanel();
                flow.Name = $"flowDias{i}";
                flow.Size = new Size(60, 74);
                flow.BorderStyle = BorderStyle.FixedSingle;
                flow.BackColor = Color.White;
                //flow.Location = new Point(7, 219);

                Label label = new Label();
                if (i >= primeiroDiaSem)
                {
                    label.Name = $"lblItem{j}";
                    label.Text = Convert.ToString(j);

                    if (Convert.ToInt32(label.Text) == DateTime.Now.Day && mes == DateTime.Now.Month)
                    {
                        flow.BackColor = Color.DarkRed;
                        label.ForeColor = Color.White;
                    }

                    if (j <= ultimoDia(mes))
                    {
                        flow.Cursor = Cursors.Hand;
                        flow.Controls.Add(label);
                    }
                    else
                    {
                        break;
                    }

                    if (j == k)
                    {
                        if (flow.BackColor != Color.DarkRed)
                        {
                            flow.BackColor = Color.LightBlue;
                        }
                    }

                    j++;
                }

                flow.Click += new EventHandler(bt);

                void bt(Object sender, EventArgs e)
                {
                    if (label.Text != "")
                    {
                        k = Int32.Parse(label.Text);
                        gerarCalendario();
                    }
                }

                flowDias.Controls.Add(flow);
            }

        }

        private void Home_Load(object sender, EventArgs e)
        {
            DateTime dia = DateTime.Today;
            mes = dia.Month;

            //int data = DateTime.DaysInMonth(DateTime.Now.Year, mes);
            
            //Console.WriteLine(mes);
          
            gerarCalendario();
            gerarTituloMes(DateTime.Now.Month - 1);
            lblDataAtual.Text = DateTime.Now.Date.ToString("D");
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            btnAntes.Enabled = true;
            mes++;
            gerarDias(mes);
            
            if(mes == 12)
            {
                btnProximo.Enabled = false;
            }

            //Console.WriteLine(mes);
        }

        private void btnAntes_Click(object sender, EventArgs e)
        {
            btnProximo.Enabled = true;
            mes--;
            gerarDias(mes);

            if (mes == 1)
            {
                btnAntes.Enabled = false;
            }
           
            //Console.WriteLine(mes);
        }

        private void lblDataAtual_Click(object sender, EventArgs e)
        {
            int mesAtual = DateTime.Today.Month;

            if (mesAtual == 1)
            {
                btnAntes.Enabled = false;
                btnProximo.Enabled = true;
            }
            else if(mesAtual == 12)
            {
                btnProximo.Enabled = false;
                btnAntes.Enabled = true;
            }
            else
            {
                btnProximo.Enabled = true;
                btnAntes.Enabled = true;
            }

            k = 0;

            Home_Load(null, null);
        }

        private void btnAtendimento_Click(object sender, EventArgs e)
        {
            Atendimento atendimento = new Atendimento();
            atendimento.ShowDialog();
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            Servicos servicos = new Servicos();
            servicos.ShowDialog();
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
        int x, y;
        Point Point = new Point();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Conf conf = new Conf();
            conf.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("foi");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("foi");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                bd.Delete();
                Application.Restart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro:\n" + ex.Message);
            }
        }

        private void pegarinfo(string usuario,string senha,string data,string idpessoal)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://adsangelinabancodedados.uc.r.appspot.com/calendario/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PUT";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    usuario = "erick",
	                senha = "teste",
	                data = "07/07/2020",
	                idpessoal = 2
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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Conf newForm2 = new Conf();
            newForm2.ShowDialog();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            bd.Delete();
            Application.Restart();
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }
    }
}
