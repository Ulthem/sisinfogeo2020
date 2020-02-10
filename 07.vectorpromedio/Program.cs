using System;

namespace _07.vectorpromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            float promedio=0;

            int [] vector = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100,
                              10, 20, 30, 40, 50, 60, 70, 80, 90, 100,
                              10, 20, 30, 40, 50, 60, 70, 80, 90, 100,
                              10, 20, 30, 40, 50, 60, 70, 80, 90, 100,
                              10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            

                        
            Console.WriteLine("El promedio de los valores\n");
            Console.WriteLine("Los elementos son: \n");

            Imprimir(vector);
            promedio=Prome(vector);

            Console.WriteLine($"\nEl promedio de los 50 valores son {promedio}");
            Console.WriteLine($"Numeros mayor que el promedio {Mayor(vector,promedio)}");
        }


        static int Mayor(int[] v, float p){
            int suma=0;
            for(int i=0; i<v.Length; i++) {
                if(v[i]>p) suma++;
            }
            return suma;
        }
        static void Imprimir(int[] v){
            for(int i=0; i<v.Length; i++){
                if(i<v.Length-1)
                Console.Write($"{v[i]}, ");

                else 
                Console.Write($"y {v[i]}. ");
            }
            Console.WriteLine();
        }

        static float Prome(int[] v){

            int suma=0;
            for(int i=0; i<v.Length; i++)
                suma=suma+v[i];

            return suma / v.Length;
        }
    }
}

