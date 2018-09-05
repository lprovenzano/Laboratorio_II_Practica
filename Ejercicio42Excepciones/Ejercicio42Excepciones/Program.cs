using IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Division.Operar(4, 0));
            }
            catch (DivideByZeroException e)
            {
                ArchivoTexto.Guardar(e.Message, "log.txt");
            }
            catch (UnaException e)
            {
                ArchivoTexto.Guardar(e.Message, "log.txt");
            }
            catch (MiException e)
            {
                ArchivoTexto.Guardar(e.Message, "log.txt");
                ArchivoTexto.Guardar(e.InnerException.ToString(), "log.txt");
            }
            finally
            {
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine(ArchivoTexto.Leer("log.txt"));
            Console.ReadKey();

           
        }
    }
}
