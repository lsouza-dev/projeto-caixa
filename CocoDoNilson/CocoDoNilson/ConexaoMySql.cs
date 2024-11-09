using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CocoDoNilson
{
    public class ConexaoMySql
    {

        static MySqlConnection mysqlconnection;

        private static MySqlConnection DbConnection()
        {
            try
            {
                mysqlconnection = new MySqlConnection("server=localhost;uid=root;pwd=123456;database=cocodonilson");
                mysqlconnection.Open();
                return mysqlconnection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }
        
        public void GetFechamentosExistentes()
        {
            using (var cmd = DbConnection().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM fechamentoCaixa";


                cmd.ExecuteNonQuery();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                    }
                }
                DbConnection().Close();
            }

        }
    }
}
