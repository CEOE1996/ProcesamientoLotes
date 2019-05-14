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

        public clsMarco(clsMarco M)
        {
            this.Proceso = M.Proceso;
            this.Estatus = M.Estatus;
            this.Memoria = new bool[M.Memoria.Count()];

            for (int i = 0; i < M.Memoria.Count(); i++)
            {
                Memoria[i] = M.Memoria[i];
            }
        }
    }

}
