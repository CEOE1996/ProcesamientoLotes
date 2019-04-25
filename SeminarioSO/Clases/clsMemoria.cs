﻿using System;
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

    class clsMemoria
    {
        public List<clsMarco> Marcos;
        public int Size;
        public int SizeMarco;

        public clsMemoria(int Size, int SizeMarco)
        {
            this.Size = Size;
            this.SizeMarco = SizeMarco;

            for(int i = 0; i < Size; i++)
                Marcos.Add(new clsMarco(i, SizeMarco));
        }

        public int getDisponible()
        {
            return Marcos.Where(c => c.Estatus == (int)Estatus.Disponible).Count();
        }

        public void addProcess(clsProceso P)
        {
            if(getDisponible() < P.TME / SizeMarco)
            {
                return;
            }

            int TME = P.TME;
            int count = 0;

            while(TME > 0)
            {
                if(Marcos[count].Estatus == (int)Estatus.Disponible)
                {
                    Marcos[count].Proceso = P.Numero;
                    Marcos[count].Estatus = (int)Estatus.Listo;

                    for(int i = 0; i < SizeMarco; i++)
                    {
                        Marcos[count].Memoria[i] = true;
                        TME--;

                        if (TME == 0) break;
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
                    for (int j = 0; j < SizeMarco; j++)
                        Marcos[i].Memoria[j] = false;
                }
            }
        }

    }
}
