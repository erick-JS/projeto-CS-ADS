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
            puxarservicos();
        }

        string idsalvo = " ";
        Button teste;
        int idd = 0;

        private void puxarservicos()
        {
            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source = dados.db; Version=3;";
            ligacao.Open();
            string query = "SELECT * FROM login";
            SQLiteCommand data = new SQLiteCommand(query, ligacao);
            SQLiteDataReader rdr = data.ExecuteReader();

            while (rdr.Read())
            {
                idd = rdr.GetInt32(0);
            }

            string nome = " ";
            int qtd = 0;

            dynamic m = pegarservicos(idd);

            nome = m.nome;

            var nomearrey = nome.ToArray();

            for (int i = 0;i < nome.Length ;i++)
            {
                if (i == 0)
                {
                    qtd = 1;
                }
                if (nomearrey[i] == ' ')
                {
                    qtd++;
                }
            }

            int n = 0, j = 0;
            string nomebtn = "";
            string ids = m.id;
            var idarrey = ids.ToArray();

            for (int i = 0; i < qtd;i++)
            {
                Button btnservico = new Button();
                btnservico.Location = new Point(0, n);
                btnservico.Size = new Size(300,50);
                int id = new int();

                teste = btnservico;

                id = i+1;

                for (; j < nome.Length ;j++)
                {
                    if (nomearrey[j] == ' ')
                    {
                        j++;
                        break;
                    }
                    nomebtn += nomearrey[j];
                }

                btnservico.Text = nomebtn;

                btnservico.Click += new EventHandler(bt);

                void bt(Object sender, EventArgs e)
                {
                    descricao.Visible = true;
                    nomedoservico.Text = btnservico.Text;
                    int idcont = 0;
                    for (int k = 0;k < ids.Length;k++)
                    {
                        if (idarrey[k] == ' ')
                        {
                            idcont++;
                            if (idcont != id)
                            {
                                idsalvo = " ";
                            }
                        }
                        if (idcont == id)
                        {
                            break;
                        }
                        idsalvo += idarrey[k];
                    }
                    dynamic idsa = pegarservicoespecifico(Convert.ToInt32(idsalvo));
                    precodoservico.Text = idsa.preco;
                    tempodoservico.Text = idsa.horario;
                }

                servicospanel.Controls.Add(btnservico);
                n += 55;
                nomebtn = "";
            }

        }

        private dynamic pegarservicoespecifico(int id)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://adsangelinabancodedados.uc.r.appspot.com/servicoget/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PUT";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    id = id
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

            return m;
        }

        private dynamic pegarservicos(int idd)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://adsangelinabancodedados.uc.r.appspot.com/servicoget/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    id = idd
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

            return m;
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

            puxarservicos();

            MessageBox.Show("Serviço adicionando com sucesso");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            descricao.Visible = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://adsangelinabancodedados.uc.r.appspot.com/servicos/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "DELETE";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    id = idsalvo
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

        }

        private void btnEditarDAdos_Click(object sender, EventArgs e)
        {
            btnEditarDAdos.Enabled = false;
            btnSalvarDados.Enabled = true;

            nomedoservico.Enabled = true;
            precodoservico.Enabled = true;
            tempodoservico.Enabled = true;
        }

        private void btnSalvarDados_Click(object sender, EventArgs e)
        {

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://adsangelinabancodedados.uc.r.appspot.com/servicos/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PUT";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    nome = nomedoservico.Text,
                    preco = precodoservico.Text,
                    horario = tempodoservico.Text,
                    id_empresa = idd

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

            btnEditarDAdos.Enabled = true;
            btnSalvarDados.Enabled = false;

            nomedoservico.Enabled = false;
            precodoservico.Enabled = false;
            tempodoservico.Enabled = false;
        }
    }
}
