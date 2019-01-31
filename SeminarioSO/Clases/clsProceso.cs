using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioSO.Clases
{
    public class clsProceso
    {
        public string Nombre;
        public string Operacion;
        public decimal Resultado;
        public int TME;
        public int Numero;
        public int NL;

        public clsProceso(String Nombre, string Operacion, decimal Resultado, int TME, int Numero)
        {
            this.Nombre = Nombre;
            this.Operacion = Operacion;
            this.Resultado = Resultado;
            this.TME = TME;
            this.Numero = Numero;
            this.NL = 0;
        }

        public clsProceso()
        {
            
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
