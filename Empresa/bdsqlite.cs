using System;
using System.Data;
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
                    cmd.CommandText = "CREATE TABLE login(id_empresa INT AUTO_INCREMENT PRIMARY KEY,usuario VARCHAR(25) NOT NULL UNIQUE,senha VARCHAR(10) NOT NULL,nome VARCHAR(50) NOT NULL,numero VARCHAR(8) NOT NULL,endereco VARCHAR(50) NOT NULL,bairro VARCHAR(20) NOT NULL,telefone VARCHAR(20) NOT NULL,cidade VARCHAR(50) NOT NULL,uf VARCHAR(2) NOT NULL,dinheiro VARCHAR(3) NOT NULL,credito VARCHAR(3) NOT NULL,debito VARCHAR(3) NOT NULL,hatendimentoi INT NULL,hatendimentof INT NULL,segunda VARCHAR(3) NULL,quinta VARCHAR(3) NULL,domingo VARCHAR(3) NULL,terça VARCHAR(3) NULL,sexta VARCHAR(3) NULL,quarta VARCHAR(3) NULL,sabado VARCHAR(3) NULL,fsemanaabres INT NULL,fsemanafechas INT NULL,fsemanaabred INT NULL,fsemanafechad INT NULL,feriado VARCHAR(3) NULL,feriadoa INT NULL,feriadof INT NULL)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE dataempresa(id_dataem INT AUTO_INCREMENT PRIMARY KEY,data DATE NOT NULL,horarioinicio TIME NOT NULL,horariofim TIME NOT NULL,id_empresa INT,id_clientes INT,FOREIGN KEY(id_empresa) REFERENCES empresa(id_empresa),FOREIGN KEY(id_clientes) REFERENCES clientes(id_clientes))";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE servicos(id_servicos INT AUTO_INCREMENT PRIMARY KEY,nome VARCHAR(20) NOT NULL UNIQUE,preco REAL NOT NULL,horario TIME NOT NULL,id_empresa INT,FOREIGN KEY(id_empresa) REFERENCES empresa(id_empresa))";
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
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM login";
                    using (var info = new SQLiteCommand(cmd.CommandText, DbConnection()))
                    {
                        using (SQLiteDataReader rdr = info.ExecuteReader())
                        {
                            string dinheiro = " ", credito = " ", debito = " ", segunda = " ";

                            while (rdr.Read())
                            {
                                dinheiro = rdr.GetString(10);
                                credito = rdr.GetString(11);
                                debito = rdr.GetString(12);
                                segunda = rdr.GetString(15);
                            }

                            return segunda;
                        }
                    }
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
                    cmd.CommandText = "INSERT INTO login VALUES(0, '"+u+"', '"+p+ "', '" + data.nome + "', '" + data.numero + "', '" + data.endereco + "', '" + data.bairro + "', '" + data.telefone + "', '" + data.cidade + "', '" + data.uf + "', '" + data.dinheiro + "', '" + data.credito + "', '" + data.debito + "', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '')";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /*
        public static void Update(Cliente cliente)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    if (cliente.Id != null)
                    {
                        cmd.CommandText = "UPDATE Clientes SET Nome=@Nome, Email=@Email WHERE Id=@Id";
                        cmd.Parameters.AddWithValue("@Id", cliente.Id);
                        cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                        cmd.Parameters.AddWithValue("@Email", cliente.Email);
                        cmd.ExecuteNonQuery();
                    }
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }*/

        public static void Delete()
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "drop table login";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "drop table dataempresa";
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