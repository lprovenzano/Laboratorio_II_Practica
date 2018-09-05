using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatosPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;

            try
            {
                Db context = new Db();
                context.Conectar();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
