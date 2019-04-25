using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioSO.Clases
{
    public class clsMarco
    {
        public int ID;
        public int Proceso;
        public int Estatus;
        public bool[] Memoria;
        
        public clsMarco(int ID, int MemorySize)
        {
            this.ID = ID;
            this.Proceso = 0;
            this.Estatus = 0;
            this.Memoria = new bool[MemorySize];

            for (int i = 0; i < MemorySize; i++)
                Memoria[i] = false;
        }

    }

}
