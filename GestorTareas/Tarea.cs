using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorTareas
{
    public class Tarea
    {
        // 1. Propiedad para el ID (número entero)
        public int ID { get; set; }

        // 2. Propiedad para el Título (texto)
        public string Titulo { get; set; }

        // 3. Propiedad para el estado "Completada" (booleano)
        public bool Completada { get; set; }


        // Constructor //

        public Tarea(string tituloInicial)
        {
            Titulo = tituloInicial;
            Completada = false;
        }
    }
}
