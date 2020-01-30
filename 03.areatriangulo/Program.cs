using System;

namespace _03.areatriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double bas, altura, area;

            Console.WriteLine("Programa que calcula el area del triagulo");

            Console.WriteLine("Dame la base: ");
            bas=double.Parse(Console.ReadLine());
            Console.WriteLine("Dame la altura: ");
            altura=double.Parse(Console.ReadLine());

            area=(bas*altura)/2;
            
            Console.WriteLine($"El area es {area}");
            Console.ReadLine();           
        }
    }
}
