using System;

namespace _25.Interfaz1
{
    public class Program
    {

        static void Main(string[] args)
        {
            Perro perro = new Perro("Jerry");
            Console.WriteLine($"{perro.Nombre}");
            perro.Llorar();

            Gato gato = new Gato("Panzon");
            Console.WriteLine($"{gato.Nombre}");
            gato.Llorar();
        }
    }
}