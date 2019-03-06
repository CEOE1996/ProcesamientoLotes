using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioSO.Clases
{

    public class clsProceso
    {
        public enum OperacionEnum
        {
            Suma,
            Resta,
            Multiplicacion,
            Division,
            Residuo
        }

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

        private static int ID;

        public clsProceso(string Operacion, string Resultado, int TME, int Numero)
        {
            this.Operacion = Operacion;
            this.Resultado = Resultado;
            this.TME = this.Servicio = TME;
            this.TR = TME;
            this.Numero = Numero;
            this.Respuesta = -1;
        }

        //Se requiere recibir el Random para evitar la misma informacion
        public clsProceso(Random R)
        {
            decimal N1, N2, Resultado;
            char Signo;
            OperacionEnum Op;

            N1 = R.Next(1, 100);
            N2 = R.Next(1, 100);
            Op = (OperacionEnum)R.Next(5);

            switch (Op)
            {
                case OperacionEnum.Suma:
                    Signo = '+';
                    Resultado = N1 + N2;
                    break;

                case OperacionEnum.Resta:
                    Signo = '-';
                    Resultado = N1 - N2;
                    break;

                case OperacionEnum.Multiplicacion:
                    Signo = '*';
                    Resultado = N1 * N2;
                    break;
                case OperacionEnum.Division:
                    Signo = '/';
                    Resultado = N1 / N2;
                    break;
                case OperacionEnum.Residuo:
                    Signo = '%';
                    Resultado = N1 % N2;
                    break;
                default:
                    Signo = '?';
                    Resultado = 0;
                    break;
            }

            this.Operacion = N1.ToString() + Signo + N2.ToString();
            this.Resultado = Math.Round(Resultado, 4).ToString();
            this.TME = this.TR = this.Servicio = R.Next(7, 18);
            
            this.Numero = ++ID;
            this.Respuesta = -1;
        }

        public clsProceso() { }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
