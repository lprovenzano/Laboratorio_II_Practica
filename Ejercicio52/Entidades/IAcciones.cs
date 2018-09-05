using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IAcciones
    {
        //Props
         ConsoleColor Color { get; set; }
         float UnidadesDeEscritura { get; set; }

        //Methods
         EscrituraWrapper Escribir(string texto);
         bool Recargar(int unidades);

    }
}
