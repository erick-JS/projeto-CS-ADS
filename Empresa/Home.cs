using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Empresa
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            if (!File.Exists(@"dados.db"))
            {
                Close();
                Login newForm2 = new Login();
                newForm2.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conf newConf = new Conf();
            newConf.ShowDialog();
        }
    }
}
