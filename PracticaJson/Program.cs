using PracticaJson.Solutions.Ejercicio_3;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PracticaJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Carga del directorio de los JSON
            string pathEjercicioUno = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ejercicio1.json");
            string pathEjercicioDos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ejercicio2.json");
            string pathEjercicioTres = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ejercicio3.json");
            string pathEjercicioCuatro = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ejercicio4.json");
            #endregion

            string ejercicio1 = File.ReadAllText(pathEjercicioUno);

            string ejercicio2 = File.ReadAllText(pathEjercicioDos);

            string ejercicio3 = File.ReadAllText(pathEjercicioTres);

            string ejercicio4 = File.ReadAllText(pathEjercicioCuatro);


            //EJERCICIO1----------------------
            /*
            Ejercicio1 ejercicio = JsonSerializer.Deserialize<Ejercicio1>(ejercicio1);

            Console.WriteLine(ejercicio.nombre);
            Console.WriteLine(ejercicio.edad);
            Console.WriteLine(ejercicio.pais);
            Console.WriteLine(ejercicio.activo);
            */





            //EJERCICIO2--------------------------

            /*
            Ejercicio2 ejercicio = JsonSerializer.Deserialize<Ejercicio2>(ejercicio2);
            Console.WriteLine(ejercicio.usuario);
            foreach (string amigos in ejercicio.AmigosDeUsuario)
            {   
                Console.WriteLine(amigos);

            }
            Console.WriteLine(ejercicio.notificacionesDeUsuario);
            */

            var options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };


            //EJERCICIO3-------------------------//
            /*
            ResumenEjercicio3 estadistica = JsonSerializer.Deserialize<ResumenEjercicio3>(ejercicio3, options)!;
            foreach(var equipo in estadistica.Estadistica)
            {
                Console.WriteLine($"Equipo {equipo.Nombre}");
                Console.WriteLine($"Campeon {equipo.Campeon}");

                foreach(var jugador in equipo.Jugadores)
                {
                    Console.WriteLine($"  nombre {jugador.Nombre}");
                    Console.WriteLine($"  kills {jugador.Kills}");
                    Console.WriteLine($"  death {jugador.Death}");
                }
                
            }
            */


            //EJERCICIO4------------------------------------//
            Catalogo catalogo = JsonSerializer.Deserialize<Catalogo>(ejercicio4 , options)!;


            foreach(var producto in catalogo.Productos)
            {
                Console.WriteLine(producto.Nombre);
                Console.WriteLine(producto.Precio);
                Console.WriteLine(producto.Existencia);
                Console.WriteLine(producto.DescuentoDisponible);
                Console.WriteLine("Etiquetas");
                foreach (var etiqueta in producto.Etiquetas)
                {
                    Console.WriteLine(etiqueta);
                }

                Console.WriteLine("Detalles:");
                Console.WriteLine(producto.Detalles.Peso.);
                Console.WriteLine("Dimensiones");
                Console.WriteLine(producto.Detalles.Dimensiones.Alto);//aqui no se por que no lo toma
                Console.WriteLine(producto.Detalles.Dimensiones.Hancho);
                Console.WriteLine(producto.Detalles.Dimensiones.Profundidad);


            }


        }




        public class Ejercicio1
        {
            public string nombre {  get; set; }
            public int edad {  get; set; }
            public string pais {  get; set; }
            public bool activo {  get; set; }
        }




        public class Ejercicio2
        {
            public string usuario { get; set; }

            [JsonPropertyName("amigos_usuario")]
            public List<string>AmigosDeUsuario { get; set; }//decalro una lista

            public Ejercicio2()
            {
                AmigosDeUsuario = new List<string>();
            }
            [JsonPropertyName("notificaciones_usuario")]
            public bool notificacionesDeUsuario { get; set; }
        }




       
            
        }
    }
