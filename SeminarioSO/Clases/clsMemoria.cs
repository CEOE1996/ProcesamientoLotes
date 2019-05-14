using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioSO.Clases
{
    enum Estatus
    {
        SO = -1,
        Disponible = 0,
        Listo = 1,
        EnProceso = 2,
        Bloqueado = 3
    }

    public class clsMemoria
    {
        public List<clsMarco> Marcos;
        public int Size;
        public int SizeMarco;

        public clsMemoria(int Size, int SizeMarco)
        {
            this.Size = Size;
            this.SizeMarco = SizeMarco;
            this.Marcos = new List<clsMarco>();

            for(int i = 0; i < Size; i++)
                Marcos.Add(new clsMarco(i, SizeMarco));
        }

        public int getDisponible()
        {
            return Marcos.Where(c => c.Estatus == (int)Estatus.Disponible).Count();
        }

        public bool canAccess(double TME)
        {
            if (getDisponible() < TME)
            {
                return false;
            }

            return true;
        }

        public void addProcess(clsProceso P)
        {
            this.addProcess(P, (int)Estatus.Listo);
        }
        public void addProcess(clsProceso P, int Estado)
        {
            if(!canAccess(P.Tamano))
            {
                return;
            }

            int Tamano = P.Tamano;
            int count = 0;

            while(Tamano > 0)
            {
                if(Marcos[count].Estatus == (int)Estatus.Disponible)
                {
                    Marcos[count].Proceso = P.Numero;
                    Marcos[count].Estatus = Estado;

                    for(int i = 0; i < SizeMarco; i++)
                    {
                        Marcos[count].Memoria[i] = true;
                        Tamano--;

                        if (Tamano == 0) break;
                    }
                }

                count++;
            }
        }

        public void changeStatus(int Proceso, int Estatus)
        {
            Marcos.Where(c => c.Proceso == Proceso).Select(c => { c.Estatus = Estatus; return c; }).ToList();
        }

        public void removeProcess(int Proceso)
        {
            for(int i = 0; i < Size; i++)
            {
                if (Marcos[i].Proceso == Proceso)
                {
                    Marcos[i].Estatus = (int)Estatus.Disponible;
                    Marcos[i].Proceso = 0;
                    for (int j = 0; j < SizeMarco; j++)
                        Marcos[i].Memoria[j] = false;
                }
            }
        }

        public int getSizeProceso(int Proceso)
        {
            return Marcos.Where(c => c.Proceso == Proceso).Count();
        }

        public List<clsMarco> getProcess(int Proceso)
        {
            return (Marcos.Where(c => c.Proceso == Proceso)).ToList();
        }

        public clsMarco removeMarco(int ID)
        {
            clsMarco M = Marcos[ID];
            Marcos[ID].Estatus = (int)Estatus.Disponible;
            for (int j = 0; j < SizeMarco; j++)
                Marcos[ID].Memoria[j] = false;

            return M;
        }

        public void addMarco(clsMarco M)
        {
            if (!canAccess(1))
            {
                return;
            }

            for(int i = 0; i < Size; i++)
            {
                if(Marcos[i].Estatus == (int)Estatus.Disponible)
                {
                    Marcos[i] = M;
                    break;
                }
            }
        }

        public IEnumerable<int> getDistinctProcess()
        {
            return Marcos.Select(c => c.Proceso).Distinct();
        }
    }
}
