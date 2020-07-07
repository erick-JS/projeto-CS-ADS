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
    public partial class preconf : Form
    {
        public preconf()
        {
            InitializeComponent();
        }

        int j = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (j == 0)
            {
                all1.Visible = false;
                servico.Visible = true;
                j++;
            }
            else
            {
                Application.Restart();
            }
        }
    }
}
