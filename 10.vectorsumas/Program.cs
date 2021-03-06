﻿using System;

namespace _10.vectorsumas
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Max=30;

            double[] A = new double[Max];
            Random Aleatorio = new Random();
            
            int cp=0, cn=0, cz=0;
            double sp=0, sn=0, sz=0;

            for(int i=0; i<Max; i++){
                A[i] = Aleatorio.Next(-50,50);
                if(A[i]>0){
                    cp++;
                    sp+=A[i];
                }
                else if(A[i]<0){
                    cn++;
                    sn+=A[i];
                }
                else{
                    cz++;
                    sz+=A[i];
                }
            }


             Console.WriteLine("Eleva al cubo 30 elementos en un vector\n ");
             Imprime(A);
             Console.WriteLine($"los positivos son {cp} y suman {sp}");
             Console.WriteLine($"los negativos son {cn} y suman {sn}");
             Console.WriteLine($"los zeros son {cz} y suman {sz}");
           
        }

        static void Imprime(double [] v){
            for(int i=0; i<v.Length; i++){
                Console.Write($"{v[i]} ");
                
            }Console.WriteLine();
        }
    }
}
