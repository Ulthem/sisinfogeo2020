﻿using System;
using System.Collections.Generic;

namespace _18.Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definimos el diccionario y reservamos espacio en memoria para el
            //SortedDictionary<string, string> midic = new SortedDictionary<string, string>()
            SortedDictionary<string, string> midic = new SortedDictionary<string, string>();

            //Agregar entradas al diccionario
            midic.Add("txt", "Archivo de texto");
            midic.Add("jpg", "Archivo de imagen");
            midic.Add("mp3", "Archivo de sonido");
            midic.Add("htm", "Archivo de HTML");
            midic.Add("exe", "Archivo ejecutable de windows");
            midic.Add("lll", "Archivo de tipo desconocido");

            //Acceder a un elemento en base a la llave
            Console.WriteLine(midic["htm"]);

            //Verificar si una llave existe, sino agregarla
            if(midic.ContainsKey("elf"))
                Console.WriteLine("La llave ya existe");
            else 
                midic.Add("elf", "Archivo ejecutable de Linux");

            //Borrar una entrada si la llave existe
            if(midic.ContainsKey("lll"))
                midic.Remove("lll");
            
            //Modificar un valor del diccionario en base a la llave
            midic["htm"] = "Archivo de texto HTML";

            //Recorrer el diccionario e imprimir la llave y su valor
            foreach (KeyValuePair<string, string> val in midic)
            {
                Console.WriteLine($"{val.Key} - {val.Value}");
            }

            //Imprimir solo las llaves del diccionario
            foreach (string llave in midic.Keys)
                Console.WriteLine(llave);

            //Imprimir solo los valores del diccionario
            foreach(string valor in midic.Values)
                Console.WriteLine(valor);

            //Borrar todas las entradas al diccionario
            midic.Clear();  

        }
    }
}
