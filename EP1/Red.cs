using System;
using System.Collections.Generic;

namespace EP1
{
    [Serializable()]
    
    class Red{
        private string empresa;
        private string propietario; 
        private string ubicacion;
        private List <Nodo> nodos;

        public Red(){
            nodos = new List<Nodo>();
        }

        public Red(string empresa, string propietario, string ubicacion){
            this.empresa = empresa;
            this.propietario = propietario;
            this.ubicacion = ubicacion;
            nodos = new List <Nodo>();
        }

        public string Empresa{
            get{return empresa; }
            set{empresa = value; }
        }

        public string Propietario{
            get{return propietario; }
            set{propietario = value; }
        }

        public string Ubicacion{
            get{return ubicacion; }
            set{ubicacion = value; }
        }
        public List <Nodo> Nodos{
            get{ return nodos;}
            set{ nodos = value;}
        }
        public void nuevoNodo(Nodo nod){
            nodos.Add(nod);
        }
        public int TotalVulnerabilidades(){
            int tot = 0;
            foreach(Nodo n in nodos){
                tot+= n.Vulneravilidad.Count;
            }
            return tot;
        }
        public int saltoMayor(){
            int sal1 = 0;
            foreach(Nodo n in nodos){
                sal1 += n.Saltos;
            }
            return sal1;
        }
        public int saltoMenor(){
            int sal2 = 100;
            foreach(Nodo n in nodos){
                if(n.Saltos < sal2)
                    sal2 = n.Saltos;
            }
            return sal2;
        }
    }   
}