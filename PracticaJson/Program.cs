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
            
            Ejercicio2 ejercicio = JsonSerializer.Deserialize<Ejercicio2>(ejercicio2);
            Console.WriteLine(ejercicio.usuario);
            foreach (string amigos in ejercicio.AmigosDeUsuario)
            {   
                Console.WriteLine(amigos);

            }
            Console.WriteLine(ejercicio.notificacionesDeUsuario);
            




            //EJERCICIO3-------------------------
            //Ejercicio3 ejercicio = JsonSerializer.Deserialize<Ejercicio3>(ejercicio3);


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




        public class Ejercicio3
        {
            public string estadistica { get; set; }
            public string equipo { get; set; }
            public List<string> jugadores {  get; set; }//lista jugadores
            public Ejercicio3()//la inicio
            {
                jugadores = new List<string>();
            }
            
        }
    }
}