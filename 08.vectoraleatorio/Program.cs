using System;

namespace _08.vectoraleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Max=15;

            int[] A = new int[Max];
            int[] B = new int[Max];
            int[] C = new int[Max];

            Random Aleatorio = new Random();

            for(int i=0; i<Max; i++){
                A[i] = Aleatorio.Next(1,100);
                B[i] = Aleatorio.Next(1,100);
                C[i] = A[i] + B[i];
             }

            Console.WriteLine("\n");
            Imprime(A);
            Console.WriteLine("\n");
            Imprime(B);
            Console.WriteLine("\n");
            Imprime(C);
            Console.WriteLine("\n");
            //Muestra(A,B,C);
        }

        static void Imprime(int[] v){
            for(int i=0; i<v.Length; i++){
                Console.Write($"{v[i]} ");
            }
        }

        /*static void Muestra(int[] v1, int[] v2, int[] v3){
            for(int i=0; i<=v1.Length; i++)
                v3[i]=v1[i]+v2[i];
            
            for(int j=0; j<v3.Length; j++)
                Console.Write($"{v3[j]} ");
        }*/
    }
}
