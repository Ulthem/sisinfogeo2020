using System;

namespace _14.cuentabancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            cuentabancaria chelines= new cuentabancaria(1000);
            Console.WriteLine($"Saldo al crear {chelines.Saldo}");

            chelines.Saldo=500;
            Console.WriteLine($"Saldo despues del domiengo {chelines.Saldo}");
            if(chelines.Retira(600))
                Console.WriteLine($"Saldo despues de la peda {chelines.Saldo}");
            
            else            
                Console.WriteLine($"No puedes organizar la peda {chelines.Saldo}");





        }
    }
}
