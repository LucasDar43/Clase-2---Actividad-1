using System.Linq;

namespace Actividad1{
      class Program{
        static void Main(string[] args) {

            Console.WriteLine("Bienvenido al Programa de la Act 1 de la Clase 2");
            Console.WriteLine("A continuacion te pediremos 5 nombres y su respectiva edad");

            int i;
            string[] nombres = new string[5];
            int[] edades = new int[5];

            for(i = 0; i < 5; i++){
                Console.WriteLine("Nombre de la Persona N° " + (i + 1));
                nombres[i] = Console.ReadLine();
                Console.WriteLine("Edad de la Persona N° " + (i + 1));
                int v = int.Parse(Console.ReadLine());
                edades[i] = v;
            }

            //sumamos todos los numeros de cada celda del array
            int sum = edades.Sum();
            double total = Convert.ToDouble(sum);
            double promedio = total / 5;

            Console.WriteLine("El promedio de edad es de "+promedio);

        } 
    }
}
