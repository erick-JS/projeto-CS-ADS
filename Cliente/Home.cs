using Empresa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
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
    }
}
