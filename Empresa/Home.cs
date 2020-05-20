using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Empresa
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection();

            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\libus\Documents\GitHub\projeto-CS-ADS\Empresa\DB.mdf;Integrated Security=True";

            con.Open();

            SqlCommand cmd = new SqlCommand();


            int login = 0;

            if (login == 0)
            {
                Close();
                Login newLogin = new Login();
                newLogin.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conf newConf = new Conf();
            newConf.ShowDialog();
        }
    }
}
