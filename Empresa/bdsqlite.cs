using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace Empresa
{
    public class bd
    {
        private static SQLiteConnection sqlconnect;

        public bd()
        { }

        private static SQLiteConnection DbConnection()
        {
            sqlconnect = new SQLiteConnection(@"Data source = dados.db; Version=3;");
            sqlconnect.Open();
            return sqlconnect;
        }

        public static void CriarBancoSQLite()
        {
            try
            {
                SQLiteConnection.CreateFile(@"Data source = dados.db; Version=3;");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void CriarTabelaSQlite()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE login(id_empresa INT AUTO_INCREMENT PRIMARY KEY,usuario VARCHAR(25) NOT NULL UNIQUE,senha VARCHAR(10) NOT NULL,nome VARCHAR(50) NOT NULL,numero VARCHAR(8) NOT NULL,endereco VARCHAR(50) NOT NULL,bairro VARCHAR(20) NOT NULL,telefone VARCHAR(20) NOT NULL,cidade VARCHAR(50) NOT NULL,uf VARCHAR(2) NOT NULL,dinheiro VARCHAR(3) NOT NULL,credito VARCHAR(3) NOT NULL,debito VARCHAR(3) NOT NULL,hatendimentoi VARCHAR(4) NULL,hatendimentof VARCHAR(4) NULL,segunda VARCHAR(3) NULL,quinta VARCHAR(3) NULL,domingo VARCHAR(3) NULL,terca VARCHAR(3) NULL,sexta VARCHAR(3) NULL,quarta VARCHAR(3) NULL,sabado VARCHAR(3) NULL,fsemanaabres VARCHAR(4) NULL,fsemanafechas VARCHAR(4) NULL,fsemanaabred VARCHAR(4) NULL,fsemanafechad VARCHAR(4) NULL,feriado VARCHAR(3) NULL,feriadoa VARCHAR(4) NULL,feriadof VARCHAR(4) NULL)";
                    cmd.ExecuteNonQuery();

                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetClientes()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Clientes";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string GetLogin()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection())
                {
                    string query = "SELECT * FROM login";
                    SQLiteCommand data = new SQLiteCommand(query, cmd);
                    SQLiteDataReader rdr = data.ExecuteReader();

                    string dinheiro = " ", credito = " ", debito = " ", quinta = " ";

                    while (rdr.Read())
                    {
                        dinheiro = rdr.GetString(10);
                        credito = rdr.GetString(11);
                        debito = rdr.GetString(12);
                        quinta = rdr.GetString(15);
                    }

                    return quinta;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(" ");
                return "deu merda";
            }
        }
      
        public static void Add(string u,string p, dynamic data)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO login VALUES("+data.id+", '"+u+"', '"+p+ "', '" + data.nome + "', '" + data.numero + "', '" + data.endereco + "', '" + data.bairro + "', '" + data.telefone + "', '" + data.cidade + "', '" + data.uf + "', '" + data.dinheiro + "', '" + data.credito + "', '" + data.debito + "', '"+data.hatendimentoi + "', '" + data.hatendimentof + "', '" + data.segunda + "', '" + data.quinta + "', '" + data.domingo + "', '" + data.terca + "', '" + data.sexta + "', '" + data.quarta + "', '" + data.sabado + "', '" + data.fsemanaabres + "', '" + data.fsemanafechas + "', '" + data.fsemanaabred + "', '" + data.fsemanafechad + "', '" + data.feriado + "', '" + data.feriadoa + "', '" + data.feriadof + "')";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Delete()
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "drop table login";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "drop table servicos";
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string Logado()
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "SELECT * FROM login";
                    cmd.ExecuteNonQuery();
                }
                return "foi";
            }
            catch (Exception ex)
            {
                Console.WriteLine("não foi");
                return " ";
            }
        }
    }
}