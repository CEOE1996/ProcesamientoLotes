using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeminarioSO.Clases;

namespace SeminarioSO.Clases
{
    public class clsLote
    {
        public Queue<clsProceso> Procesos;

        public clsLote()
        {
            Procesos = new Queue<clsProceso>();
        }

        public clsLote(Queue<clsProceso> Procesos)
        {
            this.Procesos = Procesos;
        }
    }
}
