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

        public int Llegada;
        public int Finalizacion;
        public int Retorno { get { return this.Finalizacion - this.Llegada; } }
        public int Respuesta;
        public int Espera { get { return this.Retorno - this.Servicio; } }
        public int Servicio;
        public int Bloqueado;

        public clsProceso(string Operacion, string Resultado, int TME, int Numero)
        {
            this.Operacion = Operacion;
            this.Resultado = Resultado;
            this.TME = this.Servicio = TME;
            this.TR = TME;
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
