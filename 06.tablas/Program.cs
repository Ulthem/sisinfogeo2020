using System;

namespace _06.tablas
{
    class Program
    {
        static void Main(string[] args)
        {   
            int op, t, tf, ri, rf, i, y, r;
            if(args.Length==0)
                Menu();
            Console.Clear();
            op=int.Parse(args[0]);
            t=int.Parse(args[1]);
            

            Console.Clear();

            if(op==1){
                
                Console.Clear();
                for(i=1; i<=10; i++){
                    r=t*i;
                    Console.WriteLine($"{t}*{i}= {r}");
                }
            }
            else if(op==2){
                Console.Clear();
                tf=int.Parse(args[2]);
                ri=int.Parse(args[3]);
                rf=int.Parse(args[4]);
                for(i=t; i<=tf; i++){
                    for(y=ri; y<rf; y++){
                        r=i*y;
                        Console.WriteLine($"{i}*{y}={r}");
                    }
                    Console.WriteLine("\n");
                }
            }

            static void Menu(){
            Console.WriteLine("\nOpciones de tablas de multiplicar: ");
            Console.WriteLine("[1] Introducir la tabla que quieres ver");
            Console.WriteLine("[2] Introducir la tabla inicio y la tabla final y su rango");
            }
        }
    }
}
