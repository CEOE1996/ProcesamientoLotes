using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioSO.Clases
{
    public class clsProceso
    {
        public string Operacion;
        public string Resultado;
        public int TME; //Tiempo Maximo Estimado
        public int TR; //Tiempo Restante
        public int Numero;
        public int NL;

        public clsProceso(string Operacion, string Resultado, int TME, int Numero)
        {
            this.Operacion = Operacion;
            this.Resultado = Resultado;
            this.TME = TME;
            this.TR = TME;
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
