using System;

namespace _09.vectorcubo
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Max=30;

            double[] A = new double[Max];
            double[] B = new double[Max];

            Random aleatorio = new Random();

            for(int i=0; i<Max; i++){
                A[i] = aleatorio.Next(1,100);
                
                B[i] = Math.Pow(A[i],3);
             }


             Console.WriteLine("Eleva al cubo los 30 elementos del vector\n ");


             Imprime(A);
             Console.WriteLine();
             Imprime(B);
             Console.WriteLine();

           
        }

        static void Imprime(double [] v){
            for(int i=0; i<v.Length; i++){
                Console.Write($"{v[i]} ");
                
            }Console.WriteLine();
        }
    }
}
