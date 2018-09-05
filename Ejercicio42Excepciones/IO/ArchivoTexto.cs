using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public static class ArchivoTexto
    {
        public static void Guardar(string info, string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path, true);

                //Pregunto si existe el archivo. 
                //True: Sigue y escribe. | False: Lo crea.
                if (!(File.Exists(path)))
                {
                    //Crea
                    sw = new StreamWriter(path, true);
                    
                }
                //Escribe
                sw.WriteLine(info);
                sw.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Hubo un error de tipo exception");
            }
        }


        public static string Leer(string path)
        {
            try
            {
                StreamReader sr = new StreamReader(path);
                string textoLeido = sr.ReadToEnd();
                sr.Close();
                return textoLeido;
            }
            catch (FileNotFoundException)
            {

                throw new FileNotFoundException("No se encuentra el directorio");
            }
            catch (IOException)
            {
                throw new IOException("Archivo tomado y/o sin cerrar");
            }
            catch (Exception)
            {
                throw new Exception("Excepcion inesperada");
            }
        }

    }//Clase
}//NameSpace
