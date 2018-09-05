using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace BaseDeDatosPractice
{
    public class Db
    {
        string connectionString;

        public SqlConnection Conectar()
        {
            try
            {
                SqlConnection con = new SqlConnection(this.connectionString);
                con.Open();
                return con;
            }
            catch (Exception e)
            {
                throw new Exception("No se conecto a la db", e);
            }
        }

        public Db()
        {
            this.connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        }

        public void Ejecutar(SqlConnection con, string command)
        {
            try
            {
                con.Open();
                SqlCommand query = new SqlCommand();
                query.CommandText = command;
                query.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("No se pudo ejecutar el comando", e);
            }
            finally
            {
                con.Close();
            }

        }

    }
}
