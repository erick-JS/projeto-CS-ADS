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
    public partial class Servicos : Form
    {
        public Servicos()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void Servicos_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source = dados.db; Version=3;";
            ligacao.Open();
            string query = "SELECT * FROM login";
            SQLiteCommand data = new SQLiteCommand(query, ligacao);
            SQLiteDataReader rdr = data.ExecuteReader();

            int id = 0;

            while (rdr.Read())
            {
                id = rdr.GetInt32(0);
            }

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

            MessageBox.Show("Serviço adicionando com sucesso");

        }
    }
}
