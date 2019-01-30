using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeminarioSO.Clases;

namespace SeminarioSO.Clases
{
    class clsLote
    {
        public Queue<clsProceso> Procesos;

        public clsLote(Queue<clsProceso> Procesos)
        {
            this.Procesos = Procesos;
        }
    }
}
