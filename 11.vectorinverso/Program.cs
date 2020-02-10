using System;

namespace _11.vectorinverso
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Max=15;
            int i=0, j=14;

            double[] A = new double[Max];
            double[] B = new double[Max];

            Random Aleatorio = new Random();

            for(i=0; i<Max; i++){
                A[i] = Aleatorio.Next(1,100);
                B[j] = A[i];
                j--;
            }

            Imprime(A);
            Imprime(B);

            static void Imprime(double [] v){
                for(int i=0; i<v.Length; i++){
                Console.Write($"{v[i]} ");
                
                }Console.WriteLine();
            }
        }
    }
}
