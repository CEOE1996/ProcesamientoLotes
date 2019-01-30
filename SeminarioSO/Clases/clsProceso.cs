using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioSO.Clases
{
    class clsProceso
    {
        private string Nombre;
        private int N1;
        private int N2;
        private char Op;
        private int TME;
        private int Numero;

        public clsProceso(String Nombre, int N1, int N2, char Op, int TME, int Numero)
        {
            this.Nombre = Nombre;
            this.N1 = N1;
            this.N2 = N2;
            this.Op = Op;
            this.TME = TME;
            this.Numero = Numero;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
