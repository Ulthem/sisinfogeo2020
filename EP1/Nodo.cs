using System;
using System.Collections.Generic;

namespace EP1
{
    class Nodo
    {
        string ip;
        string tipo; 
        int puertos;
        int saltos;
        string so; 
        string fi;  
        List <Vulnerabilidad> vulnerabilidades;

        public Nodo(string ip, string tipo, int puertos, int saltos, string so, string fi){
            this.ip = ip;
            this.tipo = tipo;
            this.puertos = puertos;
            this.saltos = saltos;
            this.so = so;
            this.fi = fi;
            vulnerabilidades = new List<Vulnerabilidad>();
        }

        public string Ip
        {
            get{return ip;} 
            set{ ip = value;}
        }
        public string Tipo
        {
            get{return tipo;} 
            set{tipo = value;}
        }
        public int Puertos
        {
            get{return puertos;} 
            set{puertos = value;}
        }
        public int Saltos
        {
            get{return saltos;} 
            set{saltos = value;}
        }
        public string So
        {
            get{return so;} 
            set{so = value;}
        }
        public string FI
        {
            get{return fi;} 
            set{fi = value;}
        }
        public List <Vulnerabilidad> Vulneravilidad
        {
            get{ return vulnerabilidades;}
            set{ vulnerabilidades = value;}
        }
        public void nuevaVulnerabilidad(Vulnerabilidad vulne)
        {
            vulnerabilidades.Add(vulne);
        }
    }
}