using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PracticaJson
{
    internal class Estadistica
    {

        [JsonPropertyName("equipo")]
        public string Nombre { get; set; }
        public List<Jugador> Jugadores { get; set; }//decalro una lista con la clase Jugador
        public bool Campeon { get; set; }

        public Estadistica()//aqui debo poner la clase que sestoy usando
        {
            Jugadores = new List<Jugador>();
        }






    }
}
