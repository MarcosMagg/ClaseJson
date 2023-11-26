using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PracticaJson
{
    internal class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Existencias { get; set; }

        [JsonPropertyName("descuento_disponible")]
        public bool DescuentoDisponible { get; set; }
        public List<string> Etiquetas { get; set; }
        public Detalles Detalles { get; set; }


        public Producto()
        {
            Etiquetas = new List<string>();
        }
       
    
      

    }
}
