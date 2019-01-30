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
        public string Operacion;
        public decimal Resultado;
        public int TME;
        public int Numero;

        public clsProceso(String Nombre, string Operacion, decimal Resultado, int TME, int Numero)
        {
            this.Nombre = Nombre;
            this.Operacion = Operacion;
            this.Resultado = Resultado;
            this.TME = TME;
            this.Numero = Numero;
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
