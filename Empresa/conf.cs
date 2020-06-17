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

        private void btnAtendimento_Click(object sender, EventArgs e)
        {
            aten.TopLevel = false;
            aten.Visible = true;
            servi.Visible = false;
            cont.Visible = false;

            info.Controls.Add(aten);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            servi.TopLevel = false;
            servi.Visible = true;
            aten.Visible = false;
            cont.Visible = false;

            info.Controls.Add(servi);
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {

        }

        private void btnConta_Click(object sender, EventArgs e)
        {
            cont.TopLevel = false;
            cont.Visible = true;
            servi.Visible = false;
            aten.Visible = false;

            info.Controls.Add(cont);
        }
    }
}
