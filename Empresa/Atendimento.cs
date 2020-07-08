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
        public Atendimento()
        {
            InitializeComponent();

            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source = dados.db; Version=3;";
            ligacao.Open();
            string query = "SELECT * FROM login";
            SQLiteCommand data = new SQLiteCommand(query, ligacao);
            SQLiteDataReader rdr = data.ExecuteReader();

            string dinheiro = " ", credito = " ",debito = " ";
            string segundao = " ", tercao = " ", quartao = " ", quintao = " ", sextao = " ", sabadoo = " ", domingoo = " ", feriadoo = " ";
            string a = " ", b = " ", c = " ", d = " ", e = " ", f = " ", g = " ",h = " ";

            while (rdr.Read())
            {
                dinheiro = rdr.GetString(10);
                credito = rdr.GetString(11);
                debito = rdr.GetString(12);
                segundao = rdr.GetString(15);
                tercao = rdr.GetString(18);
                quartao = rdr.GetString(20);
                quintao = rdr.GetString(16);
                sextao = rdr.GetString(19);
                sextao = rdr.GetString(10);
                sabadoo = rdr.GetString(21);
                domingoo = rdr.GetString(17);
                feriadoo = rdr.GetString(25);
                a = rdr.GetString(22);
                b = rdr.GetString(23);
                c = rdr.GetString(24);
                d = rdr.GetString(25);
                e = rdr.GetString(23);
                f = rdr.GetString(24);
                g = rdr.GetString(26);
                h = rdr.GetString(27);
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

            mktHorarioAbre.Text = a;
            mktHorarioFecha.Text = b;
            mktAbreSab.Text = c;
            mktFechaSab.Text = d;
            mktAbreDom.Text = e;
            mktFechaDom.Text = f;
            mktAbreFeriado.Text = g;
            mktFechaFeriado.Text = h;
        }

        private void alterarStatus(Panel panel, MaskedTextBox mktAbre, MaskedTextBox mktFecha, Boolean status)
        {
            panel.Enabled = status;
            mktAbre.Text = "";
            mktFecha.Text = "";
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

            btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
