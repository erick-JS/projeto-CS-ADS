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
    public partial class Atendimento : Form
    {
        public Atendimento()
        {
            InitializeComponent();
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
    }
}
