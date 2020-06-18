using System;

namespace _31.Delegados1
{
    public delegate void MiDelegado(string msj);

    class Program
    {
        static void Main(string[] args)
        {
            MiDelegado del;

            Console.Clear();

            del = Mensajes.Mensaje1;
            del("Juan");

            del = Mensajes.Mensaje2;
            del("Jose");

            del = (string msj) => Console.WriteLine($"{msj} - paga todo que no pare la fiesta");
            del("Carlos");

            Console.WriteLine();
        }
    }

    public class Mensajes {
        public static void Mensaje1(string msj){
            Console.WriteLine($"{msj} - lleva el pastel y la mota");
        }

        public static void Mensaje2(string msj){
            Console.WriteLine($"{msj} - fue el culpable de que se cancele la fiesta");
        }
    }
}