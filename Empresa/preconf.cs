using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Empresa
{
    public partial class preconf : Form
    {
        public preconf()
        {
            InitializeComponent();
        }

        int j = 0;
        int id = 0;

        private void alterarStatus(Panel panel, MaskedTextBox mktAbre, MaskedTextBox mktFecha, Boolean status)
        {
            panel.Enabled = status;
            if (status == false)
            {
                mktAbre.Text = "";
                mktFecha.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string segundao = " ", tercao = " ", quartao = " ", quintao = " ", sextao = " ", sabadoo = " ",domingoo = " ",feriadoo = " ";
            if(chkSegunda.Checked == true){ segundao = "sim";}else{ segundao = "nao";}
            if(chkTerca.Checked == true){ tercao = "sim";}else{ tercao = "nao";}
            if(chkQuarta.Checked == true){ quartao = "sim";}else{ quartao = "nao";}
            if(chkQuinta.Checked == true){ quintao = "sim";}else{ quintao = "nao";}
            if(chkSexta.Checked == true){ sextao = "sim";}else{ sextao = "nao";}
            if(chkSabado.Checked == true){ sabadoo = "sim";}else{ sabadoo = "nao";}
            if(chkDomingo.Checked == true){ domingoo = "sim";}else{ domingoo = "nao";}
            if(chkFeriado.Checked == true){ feriadoo = "sim";}else{ feriadoo = "nao";}

            if (j == 0)
            {
                SQLiteConnection ligacao = new SQLiteConnection();
                ligacao.ConnectionString = @"Data source = dados.db; Version=3;";
                ligacao.Open();
                string quer = "SELECT * FROM login";
                SQLiteCommand dataa = new SQLiteCommand(quer, ligacao);
                SQLiteDataReader rdr = dataa.ExecuteReader();


                string user = " ", senhaa = " ", nomee = " ", enderecoo = " ", bairroo = " ", numeroo = " ", cidadee = " ", uff = " ", telefonee = " ", dinheiroo = " ", creditoo = " ", debitoo = " ";

                while (rdr.Read())
                {
                    id = rdr.GetInt32(0);
                    user = rdr.GetString(1);
                    senhaa = rdr.GetString(2);
                    nomee = rdr.GetString(3);
                    enderecoo = rdr.GetString(5);
                    bairroo = rdr.GetString(6);
                    numeroo = rdr.GetString(4);
                    cidadee = rdr.GetString(8);
                    uff = rdr.GetString(9);
                    telefonee = rdr.GetString(7);
                    dinheiroo = rdr.GetString(10);
                    creditoo = rdr.GetString(11);
                    debitoo = rdr.GetString(12);
                }

                string query = "UPDATE login SET hatendimentoi = '" + mktHorarioAbre.Text + "', hatendimentof = '" + mktHorarioFecha.Text + "', segunda = '" + segundao + "', quinta = '" + quintao + "', domingo = '" + domingoo + "', terca = '" + tercao + "', sexta = '" + sextao + "', quarta = '" + quartao + "', sabado = '" + sabadoo + "', fsemanaabres = '" + mktAbreSab.Text + "', fsemanafechas = '" + mktFechaSab.Text + "', fsemanaabred = '" + mktAbreDom.Text + "', fsemanafechad = '" + mktFechaDom.Text + "', feriado = '" + feriadoo + "', feriadoa = '" + mktAbreFeriado.Text + "', feriadof = '" + mktFechaFeriado.Text + "' WHERE usuario ='" + user + "' and senha ='" + senhaa + "'";
                SQLiteCommand up = new SQLiteCommand(query, ligacao);
                up.ExecuteNonQuery();

                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://adsangelinabancodedados.uc.r.appspot.com/empresaget/");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "PUT";
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(new
                    {
                        usuario = user,
                        senha = senhaa,
                        nome = nomee,
                        numero = numeroo,
                        endereco = enderecoo,
                        bairro = bairroo,
                        telefone = telefonee,
                        cidade = cidadee,
                        uf = uff,
                        dinheiro = dinheiroo,
                        debito = debitoo,
                        credito = creditoo,
                        uv = user,
                        sv = senhaa,
                        hatendimentoi = mktHorarioAbre.Text,
                        hatendimentof = mktHorarioFecha.Text,
                        segunda = segundao,
                        quinta = quintao,
                        domingo = domingoo,
                        terca = tercao,
                        sexta = sextao,
                        quarta = quartao,
                        sabado = sabadoo,
                        fsemanaabres = mktAbreSab.Text,
                        fsemanafechas = mktFechaSab.Text,
                        fsemanaabred = mktAbreDom.Text,
                        fsemanafechad = mktFechaDom.Text,
                        feriado = feriadoo,
                        feriadoa = mktAbreFeriado.Text,
                        feriadof = mktFechaFeriado.Text
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

                all1.Visible = false;
                servico.Visible = true;
                j++;
            }
            else
            {
                Application.Restart();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://adsangelinabancodedados.uc.r.appspot.com/servicos/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    nome = txtServico.Text,
                    preco = txtPreco.Text,
                    horario = mstTempoEstimado.Text,
                    id_empresa = id

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

            txtServico.Text = "Serviço";
            txtPreco.Text = "Preço";
            mstTempoEstimado.Text = "Tempo estimado";

            MessageBox.Show("Serviço criado com sucesso");

        }

        private void txtServico_Enter(object sender, EventArgs e)
        {
            if (txtServico.Text == "Serviço")
            {
                txtServico.Text = "";
            }
            pnlServico.BackColor = Color.Black;
        }

        private void txtServico_Leave(object sender, EventArgs e)
        {
            if (txtServico.Text == "")
            {
                txtServico.Text = "Serviço";
            }
            pnlServico.BackColor = Color.Silver;
        }

        private void txtPreco_Enter(object sender, EventArgs e)
        {
            if (txtPreco.Text == "Preço")
            {
                txtPreco.Text = "";
            }
            pnlPreco.BackColor = Color.Black;
        }

        private void txtPreco_Leave(object sender, EventArgs e)
        {
            if (txtPreco.Text == "")
            {
                txtPreco.Text = "Preço";
            }
            pnlPreco.BackColor = Color.Silver;
        }

        private void mstTempoEstimado_Enter(object sender, EventArgs e)
        {
            if (mstTempoEstimado.Text == "Tempo estimado")
            {
                mstTempoEstimado.Text = "";
            }
            pnlTempo.BackColor = Color.Black;
        }

        private void mstTempoEstimado_Leave(object sender, EventArgs e)
        {
            if (mstTempoEstimado.Text == "")
            {
                mstTempoEstimado.Text = "Tempo estimado";
            }
            pnlTempo.BackColor = Color.Silver;
        }

        private void chkSabado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSabado.Checked)
            {
                alterarStatus(pnlSabado, mktAbreSab, mktFechaSab, true);
            }
            else
            {
                alterarStatus(pnlSabado, mktAbreSab, mktFechaSab, false);
            }
        }

        private void chkDomingo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDomingo.Checked)
            {
                alterarStatus(pnlDomingo, mktAbreDom, mktFechaDom, true);
            }
            else
            {
                alterarStatus(pnlDomingo, mktAbreDom, mktFechaDom, false);
            }
        }

        private void chkFeriado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFeriado.Checked)
            {
                alterarStatus(pnlFeriado, mktAbreFeriado, mktFechaFeriado, true);
            }
            else
            {
                alterarStatus(pnlFeriado, mktAbreFeriado, mktFechaFeriado, false);
            }
        }

        private void mktHorarioAbre_Enter(object sender, EventArgs e)
        {
            pnlAbreHora.BackColor = Color.Black;
        }

        private void mktHorarioAbre_Leave(object sender, EventArgs e)
        {
            pnlAbreHora.BackColor = Color.Silver;
        }

        private void mktHorarioFecha_Enter(object sender, EventArgs e)
        {
            pnlFechaHora.BackColor = Color.Black;
        }

        private void mktHorarioFecha_Leave(object sender, EventArgs e)
        {
            pnlFechaHora.BackColor = Color.Silver;
        }

        private void mktAbreFeriado_Enter(object sender, EventArgs e)
        {
            pnlAbreFer.BackColor = Color.Black;
        }

        private void mktAbreFeriado_Leave(object sender, EventArgs e)
        {
            pnlAbreFer.BackColor = Color.Silver;
        }

        private void mktFechaFeriado_Enter(object sender, EventArgs e)
        {
            pnlFechaFer.BackColor = Color.Black;
        }

        private void mktFechaFeriado_Leave(object sender, EventArgs e)
        {
            pnlFechaFer.BackColor = Color.Silver;
        }

        private void mktAbreSab_Enter(object sender, EventArgs e)
        {
            pnlAbreSab.BackColor = Color.Black;
        }

        private void mktAbreSab_Leave(object sender, EventArgs e)
        {
            pnlAbreSab.BackColor = Color.Silver;
        }

        private void mktFechaSab_Enter(object sender, EventArgs e)
        {
            pnlFechaSab.BackColor = Color.Black;
        }

        private void mktFechaSab_Leave(object sender, EventArgs e)
        {
            pnlAbreSab.BackColor = Color.Silver;
        }

        private void mktAbreDom_Enter(object sender, EventArgs e)
        {
            pnlAbreDom.BackColor = Color.Black;
        }

        private void mktAbreDom_Leave(object sender, EventArgs e)
        {
            pnlAbreDom.BackColor = Color.Silver;
        }

        private void mktFechaDom_Enter(object sender, EventArgs e)
        {
            pnlFechaDom.BackColor = Color.Black;
        }

        private void mktFechaDom_Leave(object sender, EventArgs e)
        {
            pnlFechaDom.BackColor = Color.Silver;
        }
    }
}

