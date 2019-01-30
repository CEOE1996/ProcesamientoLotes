using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioSO.Clases
{
    class clsProceso
    {
        public string Nombre;
        public int N1;
        public int N2;
        public char Op;
        public int TME;
        public int Numero;

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
