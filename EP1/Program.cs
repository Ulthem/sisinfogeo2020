//Examen 1 by Luis Manuel Guzman Ortiz
using System;
using System.IO;

namespace EP1
{
    class Program
    {
        static void Main(string[] args)
        {   
            Red redP = null;

            redP = new Red("Telmex", "Danan Cortez", "El anexo");

            Inicializacion(redP);
            Mostrar(redP);
        }
        static void Inicializacion(Red red)
        {
            red.nuevoNodo(new Nodo("192.168.1.2", "Servidor FTP", 10, 5, "Linux", "02/05/16"));
            red.nuevoNodo(new Nodo("192.168.1.10", "BD", 15, 9, "Linux", "05/09/10"));
            red.nuevoNodo(new Nodo("192.168.1.12", "Computadora", 1, 1, "Linux", "01/01/01"));
            
            red.Nodos[1].nuevaVulnerabilidad(new Vulnerabilidad("CVE-2010-2603", "Telnet", "Falla lector", "Remota", DateTime.Parse("08/09/2018")));
            red.Nodos[0].nuevaVulnerabilidad(new Vulnerabilidad("CVE-2009-2504", "EIA", "Servidor caido", "Mundial", DateTime.Parse("11/7/2011")));
            red.Nodos[2].nuevaVulnerabilidad(new Vulnerabilidad("CVE-2101-2501", "Facebook", "Usuario bloqueado", "Remota", DateTime.Parse("11/4/2011")));
        }
        static void Mostrar(Red red)
        {
            Console.Clear();
            Console.WriteLine($"Empresa: {red.Empresa}");
            Console.WriteLine($"Dueño: {red.Propietario}");
            Console.WriteLine($"Ubicacion: {red.Ubicacion}");
            Console.WriteLine($"Total de Nodos: {red.Nodos.Count}");
            Console.WriteLine($"Total de Vulnerabilidades: {red.TotalVulnerabilidades()}\n");
            Console.WriteLine($"Datos generales de los nodos: \n");

            foreach(Nodo nodo in red.Nodos)
            {
                Console.WriteLine($"Ip:{nodo.Ip}, Tipo:{nodo.Tipo}, Puertos: {nodo.Puertos}, Saltos: {nodo.Saltos}, SO:{nodo.So}, ToVul: {nodo.Vulneravilidad.Count}");
            }

            Console.WriteLine($" Mayor numero de saltos: {red.saltoMayor()}");
            Console.WriteLine($" Menor numero de saltos: {red.saltoMenor()}\n");
            Console.WriteLine($" Vulnerabilidades por nodo\n");
            foreach(Nodo nodo in red.Nodos){
                Console.WriteLine($"Ip: {nodo.Ip}, Tipo: {nodo.Tipo}\n");
                foreach(Vulnerabilidad vul in nodo.Vulneravilidad)
                {
                    Console.WriteLine($"Clave: {vul.Clave}, Vendedor: {vul.Vendedor}, Descripcion: {vul.Descripcion},Tipo: {vul.Tipo}, Fecha: {vul.Fecha}");
                    Console.WriteLine("\n");   
                }
            }
        }
    }
}