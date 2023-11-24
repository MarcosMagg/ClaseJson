using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PracticaJson
{
    internal class Detalles
    {
        public double Peso { get; set; }
        public List<Dimensiones> Dimensiones { get; set; }

        public Detalles()
        {
            Dimensiones = new List<Dimensiones>();
        }
    }
}
