using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaJson
{
    internal class Catalogo
    {
        public List<Producto> Productos { get; set; }

        public Catalogo()
        {
            Productos = new List<Producto>();
        }
    }

}
