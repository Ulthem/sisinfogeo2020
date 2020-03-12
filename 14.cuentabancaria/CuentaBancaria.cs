namespace _14.cuentabancaria{

    class cuentabancaria{

        private double saldo;
        public cuentabancaria(double saldo){
            this.saldo=saldo;
        }
        public double Saldo {
            get {return saldo;}
            set {saldo+=value;}
        }

        public bool Retira(double cant){
            if(saldo>cant){
                saldo-=cant;
                return true;
            } else return false;
        }

    }
}