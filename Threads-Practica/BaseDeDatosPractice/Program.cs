using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatosPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Db context = new Db();
            SqlConnection con = context.Conectar();

            try
            {
                //context.Ejecutar(con, "insert into Production.Location(Name, CostRate, Availability, ModifiedDate) values('Test555', 15.52, 125, GETDATE())");
                context.Ejecutar(con, "update Production.Location set CostRate=200 where LocationID=64");
                Console.WriteLine("Wait...");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("DONE!!!");
                DataTable dt = new DataTable();
                dt = context.ObtenerDatos(con, "select * from Production.Location order by 1 desc");

                var result = dt.Rows[0];
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
             
                con.Close();
                Console.ReadKey();
            }
        }
    }
}
