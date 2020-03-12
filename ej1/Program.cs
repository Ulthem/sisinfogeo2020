using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            empleado empleado01= new empleado();

            empleado empleado02;
            empleado02= new empleado();

            empleado empleado03= new empleado("Maria", 25);

            empleado01.Nombre= "Juan";
            empleado01.Edad= 25;

            Console.WriteLine($"Nombre: {empleado01.Nombre}, edad: {empleado01.Edad}"); //Se accede a los metodos no a las variables
            Console.WriteLine($"{empleado01.ToString()}");

            Console.WriteLine($"Te vas de vacaciones:\n {DateTime.Now.ToString("dd/mm/yy")}\nRegresas:");
            Console.Write(empleado01.Vacaciones(DateTime.Now, 30));
        }
    }
}
