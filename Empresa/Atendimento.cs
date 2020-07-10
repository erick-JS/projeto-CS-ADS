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
    public partial class Atendimento : Form
    {
        string dinheiro = " ", credito = " ", debito = " ", user = " ",senhaa = " ";
        string segundao = " ", tercao = " ", quartao = " ", quintao = " ", sextao = " ", sabadoo = " ", domingoo = " ", feriadoo = " ";
        string mktHorarioAbre1 = " ", mktHorarioFecha1 = " ", mktAbreSab1 = " ", mktAbreDom1 = " ", mktFechaDom1 = " ", mktAbreFeriado1 = " ", mktFechaFeriado1 = " ", mktFechaSab1 = " ";

        public Atendimento()
        {
            InitializeComponent();

            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source = dados.db; Version=3;";
            ligacao.Open();
            string query = "SELECT * FROM login";
            SQLiteCommand data = new SQLiteCommand(query, ligacao);
            SQLiteDataReader rdr = data.ExecuteReader();

            while (rdr.Read())
            {
                user = rdr.GetString(1);
                senhaa = rdr.GetString(2);
                dinheiro = rdr.GetString(10);
                credito = rdr.GetString(11);
                debito = rdr.GetString(12);
                segundao = rdr.GetString(15);
                tercao = rdr.GetString(18);
                quartao = rdr.GetString(20);
                quintao = rdr.GetString(16);
                sextao = rdr.GetString(19);
                sabadoo = rdr.GetString(21);
                domingoo = rdr.GetString(17);
                feriadoo = rdr.GetString(26);
                mktHorarioAbre1 = rdr.GetString(13);
                mktHorarioFecha1 = rdr.GetString(14);
                mktAbreSab1 = rdr.GetString(22);
                mktFechaSab1 = rdr.GetString(23);
                mktAbreDom1 = rdr.GetString(24);
                mktFechaDom1 = rdr.GetString(25);
                mktAbreFeriado1 = rdr.GetString(27);
                mktFechaFeriado1 = rdr.GetString(28);
            }

            if (dinheiro == "sim")
            {
                chkDinheiro.Checked = true;
            }

            if (credito == "sim")
            {
                chkCredito.Checked = true;
            }

            if (debito == "sim")
            {
                chkDebito.Checked = true;
            }

            if (segundao == "sim") { chkSegunda.Checked = true; } 
            if (tercao == "sim") { chkTerca.Checked = true; } 
            if (quartao == "sim") { chkQuarta.Checked = true; }
            if (quintao == "sim") { chkQuinta.Checked = true; } 
            if (sextao == "sim") { chkSexta.Checked = true; } 
            if (sabadoo == "sim") { chkSabado.Checked = true; } 
            if (domingoo == "sim") { chkDomingo.Checked = true; } 
            if (feriadoo == "sim") { chkFeriado.Checked = true; }

            mktHorarioAbre.Text = mktHorarioAbre1;
            mktHorarioFecha.Text = mktHorarioFecha1;
            mktAbreSab.Text = mktAbreSab1;
            mktFechaSab.Text = mktFechaSab1;
            mktAbreDom.Text = mktAbreDom1;
            mktFechaDom.Text = mktFechaDom1;
            mktAbreFeriado.Text = mktAbreFeriado1;
            mktFechaFeriado.Text = mktFechaFeriado1;
        }

        private void alterarStatus(Panel panel, MaskedTextBox mktAbre, MaskedTextBox mktFecha, Boolean status)
        {
            panel.Enabled = status;
            if (status == false)
            {
                mktAbre.Text = "";
                mktFecha.Text = "";
            }
        }

        private void Atendimento_Load(object sender, EventArgs e)
        {
            gpxHoraAtendimento.Enabled = false;
            gpxDiasSemana.Enabled = false;
            gpxFeriados.Enabled = false;
            gpxFimSemana.Enabled = false;
            gpxFormaPagamento.Enabled = false;

            pnlSabado.Enabled = false;
            pnlDomingo.Enabled = false;
            pnlFeriado.Enabled = false;

            btnSalvar.Enabled = false;
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
                alterarStatus(pnlFeriado, mktAbreFeriado, mktAbreFeriado, true);
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
            pnlFechaSab.BackColor = Color.Silver;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;

            gpxHoraAtendimento.Enabled = true;
            gpxDiasSemana.Enabled = true;
            gpxFeriados.Enabled =   true;
            gpxFimSemana.Enabled = true;
            gpxFormaPagamento.Enabled = true;

            if (chkFeriado.Checked)
            {
                alterarStatus(pnlFeriado, mktAbreFeriado, mktAbreFeriado, true);
            }
            else
            {
                alterarStatus(pnlFeriado, mktAbreFeriado, mktFechaFeriado, false);
            }

            if (chkDomingo.Checked)
            {
                alterarStatus(pnlDomingo, mktAbreDom, mktFechaDom, true);
            }
            else
            {
                alterarStatus(pnlDomingo, mktAbreDom, mktFechaDom, false);
            }

            if (chkSabado.Checked)
            {
                alterarStatus(pnlSabado, mktAbreSab, mktFechaSab, true);
            }
            else
            {
                alterarStatus(pnlSabado, mktAbreSab, mktFechaSab, false);
            }

            btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomee = " ", enderecoo = " ", bairroo = " ", numeroo = " ", cidadee = " ", uff = " ", telefonee = " ", dinheiroo = " ", creditoo = " ", debitoo = " ";

            if (chkSegunda.Checked == true) { segundao = "sim"; } else { segundao = "nao"; }
            if (chkTerca.Checked == true) { tercao = "sim"; } else { tercao = "nao"; }
            if (chkQuarta.Checked == true) { quartao = "sim"; } else { quartao = "nao"; }
            if (chkQuinta.Checked == true) { quintao = "sim"; } else { quintao = "nao"; }
            if (chkSexta.Checked == true) { sextao = "sim"; } else { sextao = "nao"; }
            if (chkSabado.Checked == true) { sabadoo = "sim"; } else { sabadoo = "nao"; }
            if (chkDomingo.Checked == true) { domingoo = "sim"; } else { domingoo = "nao"; }
            if (chkFeriado.Checked == true) { feriadoo = "sim"; } else { feriadoo = "nao"; }

            if (chkCredito.Checked == true) { credito = "sim"; } else { credito = "nao"; }
            if (chkDebito.Checked == true) { debito = "sim"; } else { debito = "nao"; }
            if (chkDinheiro.Checked == true) { dinheiro = "sim"; } else { dinheiro = "nao"; }

            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source = dados.db; Version=3;";
            ligacao.Open();

            string query1 = "UPDATE login SET hatendimentoi = '" + mktHorarioAbre.Text + "', hatendimentof = '" + mktHorarioFecha.Text + "', segunda = '" + segundao + "', quinta = '" + quintao + "', domingo = '" + domingoo + "', terca = '" + tercao + "', sexta = '" + sextao + "', quarta = '" + quartao + "', sabado = '" + sabadoo + "', fsemanaabres = '" + mktAbreSab.Text + "', fsemanafechas = '" + mktFechaSab.Text + "', fsemanaabred = '" + mktAbreDom.Text + "', fsemanafechad = '" + mktFechaDom.Text + "', feriado = '" + feriadoo + "', feriadoa = '" + mktAbreFeriado.Text + "', feriadof = '" + mktFechaFeriado.Text + "', debito = '"+debito+"', credito = '"+credito+"', dinheiro = '"+dinheiro+"' WHERE usuario ='" + user + "' and senha ='" + senhaa + "'";
            SQLiteCommand up = new SQLiteCommand(query1, ligacao);
            up.ExecuteNonQuery();


            string query = "SELECT * FROM login";
            SQLiteCommand data = new SQLiteCommand(query, ligacao);
            SQLiteDataReader rdr = data.ExecuteReader();

            while (rdr.Read())
            {
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
                segundao = rdr.GetString(15);
                tercao = rdr.GetString(18);
                quartao = rdr.GetString(20);
                quintao = rdr.GetString(16);
                sextao = rdr.GetString(19);
                sabadoo = rdr.GetString(21);
                domingoo = rdr.GetString(17);
                feriadoo = rdr.GetString(26);
                mktHorarioAbre1 = rdr.GetString(13);
                mktHorarioFecha1 = rdr.GetString(14);
                mktAbreSab1 = rdr.GetString(22);
                mktFechaSab1 = rdr.GetString(23);
                mktAbreDom1 = rdr.GetString(24);
                mktFechaDom1 = rdr.GetString(25);
                mktAbreFeriado1 = rdr.GetString(27);
                mktFechaFeriado1 = rdr.GetString(28);
            }

            string userv = senhaa, senhav = user;


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
                    uv = userv,
                    sv = senhav,
                    hatendimentoi = mktHorarioAbre1,
                    hatendimentof = mktHorarioFecha1,
                    segunda = segundao,
                    quinta = quintao,
                    domingo = domingoo,
                    terca = tercao,
                    sexta = sextao,
                    quarta = quartao,
                    sabado = sabadoo,
                    fsemanaabres = mktAbreSab1,
                    fsemanafechas = mktFechaSab1,
                    fsemanaabred = mktAbreDom1,
                    fsemanafechad = mktFechaDom1,
                    feriado = feriadoo,
                    feriadoa = mktAbreFeriado1,
                    feriadof = mktFechaFeriado1
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

            gpxHoraAtendimento.Enabled = false;
            gpxDiasSemana.Enabled = false;
            gpxFeriados.Enabled = false;
            gpxFimSemana.Enabled = false;
            gpxFormaPagamento.Enabled = false;
            btnEditar.Enabled = true;
            btnSalvar.Enabled = false;

            MessageBox.Show("Editado com sucesso");

        }
    }
}
