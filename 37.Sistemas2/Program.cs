using System;
using System.Net;
using System.Net.NetworkInformation;

namespace _37.Sistemas2
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Lenght < 1) Menu();
            else{
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                switch (int.Parse(args[0]))
                {
                    case 1: Ping("www.google.com"); break;
                    case 2: DsnAndIPLocal(); break;
                    case 3: InterfacesRed(); break;
                    default: Console.WriteLine("Opcion invalida ..."); break;
                }
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }

        static void Menu(){
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[-] Menu de opciones operaciones de red\n");
            Console.WriteLine("[-] Hacer ping a google.com  ................... [1]");
            Console.WriteLine("[-] Obtener el nombre host e ip de mi maquina .. [2]");
            Console.WriteLine("[-] Obtener interfaces de red de mi maquina  ... [3]");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        static void Ping(string ipaddr){
            Ping ping = new Ping();
            Console.WriteLine("Haciendo ping a google.com");
            PingReply reply = ping.Send(ipaddr, 1000);
            Console.WriteLine($"Respuestas: {reply.Status.ToString()}");
        }

        static void DnsAndIPLocal(){
            string hostname = Dns.GetHostName();
            string ip = Dns.GetHostEntry(hostname).AddressList[0].ToString();
            Console.WriteLine($"Nombre del host : {hostname}");
            Console.WriteLine($"Ip del host     : {ip}");
        }

        static void InterfacesRed(){
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            Console.WriteLine($"Interfaces Wireless o Ethernet");
            foreach(NetworkInterface interfaz in interfaces)
            {
                if(interfaz.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || interfaz.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    Console.WriteLine($"{interfaz.Id.ToString(), -0}");
                    Console.WriteLine($"{interfaz.NetworkInterfaceType.ToString(), -10}");
                    Console.WriteLine($"{interfaz.GetPhysicalAddress().ToString(), -13}");
                    UnicastIPAddressInformationCollection uniIps = interfaz.GetIPProperties().UnicastAddresses;
                    foreach(UnicastIPAddressInformation ip in uniIps)
                        Console.WriteLine($"{ip.Address.ToString(), -30}");
                    Console.WriteLine();
                }
            }
        }

        
        
    }
}
