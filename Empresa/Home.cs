using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD

=======
using System.Data.SQLite;
using System.IO;
>>>>>>> 83d6ebc29bd46b46f094f39f911168cdee21d2f7

namespace Empresa
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        int mes = 1;
        String[] mesExtenso = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
        "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};

        private void gerarTituloMes(int mes)
        {
            lblTitulo.Text = mesExtenso[mes] + ", " + DateTime.Now.Year.ToString();
        }

        private void gerarDias(int mes)
        {
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
                flow.Size = new Size(60, 84);
                flow.BorderStyle = BorderStyle.FixedSingle;
                flow.BackColor = Color.White;
                flow.Location = new Point(7, 219);

                Label label = new Label();
                if (i >= primeiroDiaSem)
                {
                    label.Name = $"lblItem{j}";
                    label.Text = Convert.ToString(j);

                    if (i == DateTime.Now.Day && mes == DateTime.Now.Month)
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

                    j++;
                }

                flowDias.Controls.Add(flow);
=======
            if (!File.Exists(@"dados.db"))
            {
                Close();
                Login newForm2 = new Login();
                newForm2.ShowDialog();
>>>>>>> 83d6ebc29bd46b46f094f39f911168cdee21d2f7
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

            Console.WriteLine(mes);
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
           
            Console.WriteLine(mes);
        }

        private void lblDataAtual_Click(object sender, EventArgs e)
        {
            if(mes == 1)
            {
                btnAntes.Enabled = false;
                btnProximo.Enabled = true;
            }

            if(mes == 12)
            {
                btnProximo.Enabled = false;
                btnAntes.Enabled = true;
            }

            Home_Load(null, null);
        }
    }
}
