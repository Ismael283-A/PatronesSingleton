using System;
namespace PatronSingleton

{

    internal class Program

    {

        static void Main(string[] args)

        {

            // Accediendo a la instancia única 

            var config1 = GestorConfiguracion.Instancia();

            var config2 = GestorConfiguracion.Instancia();



            // Usando métodos 

            config1.GuardarValor("apiUrl", "https://api.ejemplo.com");

            Console.WriteLine(config2.ObtenerValor("apiUrl"));



            // Verificamos que ambas instancias son la misma 

            Console.WriteLine(Object.ReferenceEquals(config1, config2)); // True 



            // Evita que se cierre la consola 

            Console.WriteLine("\nPresiona cualquier tecla para salir...");

            Console.ReadLine();

        }

    }

}

