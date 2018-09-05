using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

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
                SqlCommand query = new SqlCommand(command, con);
                query.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("No se pudo ejecutar el comando", e);
            }
        }

        public DataTable ObtenerDatos(SqlConnection con, string command) 
        {
            SqlCommand query = new SqlCommand(command, con);
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = query;
            DataTable ds = new DataTable();
            da.Fill(ds);

            return ds;
        }

    }
}
