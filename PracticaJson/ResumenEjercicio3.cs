using PracticaJson.Solutions.Ejercicio_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaJson
{
    internal class ResumenEjercicio3
    {
        public List<Estadistica> Estadistica { get; set; }

        public ResumenEjercicio3()//aqui debo poner la clase que sestoy usando
        {
            Estadistica = new List<Estadistica>();
        }
    }
}
