﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeminarioSO.Clases;

namespace SeminarioSO
{
    public partial class frmProcess : Form
    {
        const int MAX_PROCESOS = 3;
        int MAX_QUANTUM;
        const int MAX_MEMORY = 36;
        const int MAX_MARCO = 5;
        const int SIZE_SO = 10;

        Queue<clsProceso> ProcesosNuevos = new Queue<clsProceso>();
        Queue<clsProceso> ProcesosListos = new Queue<clsProceso>();
        Queue<clsProceso> ProcesosBloqueados = new Queue<clsProceso>();
        clsProceso ProcesoActual;
        clsMemoria Memoria = new clsMemoria(MAX_MEMORY, MAX_MARCO);

        List<clsProceso> Concluidos = new List<clsProceso>();
        int Counter = 0, CountProcesos = 0, Quantum = 0;
        Random R = new Random();

        public frmProcess(Queue<clsProceso> Nuevos, int Quantum)
        {
            this.ProcesosNuevos = Nuevos;
            MAX_QUANTUM = Quantum;
            InitializeComponent();
            //Adding SO
            Memoria.addProcess(new clsProceso("", "", 0, -1, SIZE_SO));
            Memoria.changeStatus(-1, -1);

            timer1.Start();
            lblMaxQuantum.Text = Quantum.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Procesar();
        }
        
        private void Procesar()
        {
            while(ProcesosNuevos.Count > 0 && Memoria.canAccess(ProcesosNuevos.First().Tamano))
            {
                clsProceso P = ProcesosNuevos.Dequeue();
                P.Llegada = Counter;
                ProcesosListos.Enqueue(P);
                Memoria.addProcess(P);
                CountProcesos++;
            }

            if (ProcesoActual != null && ProcesoActual.TR > 0)
            {
                lblCounter.Text = (++Counter).ToString();
                txtTR.Text = (--ProcesoActual.TR).ToString();
                txtTT.Text = (ProcesoActual.TME - ProcesoActual.TR).ToString();
                lblQuantum.Text = (++Quantum).ToString();
            }
            else if (ProcesosListos.Count > 0)
            {
                AddConcluido();
                setActual();
                pnlPaginas.Invalidate();
            }
            else if(ProcesosNuevos.Count == 0 && ProcesosBloqueados.Count == 0)
            {
                AddConcluido();
                timer1.Stop();
                MessageBox.Show("Se han concluido todos los procesos", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblCounter.Text = (++Counter).ToString();
            }

            lblCounterLote.Text = ProcesosNuevos.Count.ToString();
            setData(ProcesoActual);
            dgSiguiente.DataSource = SetSiguiente(ProcesosNuevos);
            ProcessBloqueados();

            if (Quantum >= MAX_QUANTUM)
            {
                ProcesosListos.Enqueue(ProcesoActual);
                Memoria.changeStatus(ProcesoActual.Numero, 1);
                setActual();
            }
        }

        private DataTable SetListos(Queue<clsProceso> L)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("TME");
            dt.Columns.Add("TR");

            foreach (clsProceso P in L)
            {
                dt.Rows.Add(P.Numero, P.TME, P.TR);
            }

            return dt;
        }

        private DataTable SetSiguiente(Queue<clsProceso> L)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Tamano");

            if(L.Count > 0)
            {
                dt.Rows.Add(L.First().Numero, L.First().Tamano);
            }

            return dt;
        }

        private void AddConcluido()
        {
            if (ProcesoActual == null)
            {
                return;
            }

            ProcesoActual.Finalizacion = Counter;
            ProcesoActual.Concluido = true;
            Memoria.removeProcess(ProcesoActual.Numero);
            Concluidos.Add(ProcesoActual);
            CountProcesos--;
        }

        private void ProcessBloqueados()
        {
            ProcesosBloqueados.Select(c => { c.Bloqueado++; return c; }).ToList();

            if(ProcesosBloqueados.Count > 0 && ProcesosBloqueados.First().Bloqueado > 9)
            {
                clsProceso Unblock = ProcesosBloqueados.Dequeue();
                ProcesosListos.Enqueue(Unblock);
                Memoria.changeStatus(Unblock.Numero, 1);
            }

            dgBloqueados.DataSource = SetBloqueados(ProcesosBloqueados);
        }

        private DataTable SetBloqueados(Queue<clsProceso> L)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Bloqueado");

            foreach (clsProceso P in L)
            {
                dt.Rows.Add(P.Numero, P.Bloqueado);
            }

            return dt;
        }

        private DataTable SetConcluidos(List<clsProceso> L)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Operacion");
            dt.Columns.Add("Resultado");

            foreach (clsProceso P in L)
            {
                dt.Rows.Add(P.Numero, P.Operacion, P.Resultado);
            }

            return dt;
        }

        private void setData(clsProceso P)
        {
            if (P != null)
            {
                txtOp.Text = P.Operacion;
                txtNumero.Text = P.Numero.ToString();
                txtTME.Text = P.TME.ToString();
                txtTT.Text = (P.TME - P.TR).ToString();
                txtTR.Text = (P.TR).ToString();
                lblQuantum.Text = Quantum.ToString();
            }
            else
            {
                txtOp.Text = "";
                txtNumero.Text = "";
                txtTME.Text = "";
                txtTT.Text = "";
                txtTR.Text = "";
                lblQuantum.Text = "";
            }
            dgActual.DataSource = SetListos(ProcesosListos);
            dgConcluidos.DataSource = SetConcluidos(Concluidos);
            DrawPages();
        }

        private void dgActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressKey((Keys)char.ToUpper(e.KeyChar));
        }

        private void pnlPaginas_Paint(object sender, PaintEventArgs e)
        {
            DrawPages();
        }

        private void PressKey(Keys K){
            switch (K)
            {
                case Keys.I: //Interrupcion
                    if (timer1.Enabled)
                    {
                        ProcesoActual.Bloqueado = 0;
                        ProcesosBloqueados.Enqueue(ProcesoActual);
                        Memoria.changeStatus(ProcesoActual.Numero, 3);
                        setActual();
                        setData(ProcesoActual);
                    }
                    break;
                case Keys.E: //Error
                    if (timer1.Enabled)
                    {
                        ProcesoActual.Resultado = "Error";
                        ProcesoActual.Servicio = ProcesoActual.TME - ProcesoActual.TR;
                        ProcesoActual.TR = 0;
                        Procesar();
                    }
                    break;
                case Keys.P: //Pausa
                    timer1.Stop();
                    lblTitle.Text = "Procesos en Pausa";
                    break;
                case Keys.C: //Continuar
                    timer1.Start();
                    lblTitle.Text = "Procesos en Ejecución";
                    break;
                case Keys.N: //Nuevo
                    if (timer1.Enabled)
                    {
                        ProcesosNuevos.Enqueue(new clsProceso(R));
                        Procesar();
                    }
                    break;
                case Keys.T: //Tabla BCP
                    if (timer1.Enabled)
                    {
                        timer1.Stop();
                        List<clsProceso> BCP = new List<clsProceso>();
                        BCP.AddRange(Concluidos);

                        if (ProcesoActual != null)
                        {
                            BCP.Add(ProcesoActual);
                        }

                        BCP.AddRange(ProcesosListos);
                        BCP.AddRange(ProcesosBloqueados);
                        BCP.AddRange(ProcesosNuevos);

                        foreach (clsProceso p in BCP) {
                            if (!p.Concluido)
                            {
                                p.Finalizacion = Counter;
                                p.Servicio = p.TME - p.TR;
                            }
                        }

                        frmConcluido Ventana = new frmConcluido(Counter, BCP, false);
                        this.Hide();
                        Ventana.ShowDialog();
                        this.Show();
                        dgActual.Focus();
                        timer1.Start();
                    }
                    break;
                case Keys.M: //Tabla paginas
                    timer1.Stop();
                    frmTablaPaginas Paginas = new frmTablaPaginas(Memoria);
                    this.Hide();
                    Paginas.ShowDialog();
                    this.Show();
                    timer1.Start();
                    break;
            }
        }

        private void setActual()
        {
            if (ProcesosListos.Count > 0)
            {
                ProcesoActual = ProcesosListos.Dequeue();
                Memoria.changeStatus(ProcesoActual.Numero, 2);
                if(ProcesoActual.Respuesta == -1)
                {
                    ProcesoActual.Respuesta = Counter - ProcesoActual.Llegada;
                }
                Quantum = 0;
            }
            else
            {
                ProcesoActual = null;
            }
        }

        private void DrawPages()
        {
            Pen p = new Pen(Color.Black);
            SolidBrush sb = new SolidBrush(Color.Black);
            SolidBrush sbFont = new SolidBrush(Color.Black);
            int x = 0;
            int SIZE = 23;

            Font Header = new Font("Arial", 11, FontStyle.Bold);
            Font Text = new Font("Arial", 9, FontStyle.Regular);

            foreach (clsMarco M in Memoria.Marcos)
            {
                switch (M.Estatus)
                {
                    case -1:
                        sb.Color = Color.Black;
                        break;
                    case 0:
                        sb.Color = Color.White;
                        break;
                    case 1:
                        sb.Color = Color.Blue;
                        break;
                    case 2:
                        sb.Color = Color.Red;
                        break;
                    case 3:
                        sb.Color = Color.Purple;
                        break;
                }

                pnlPaginas.CreateGraphics().DrawRectangle(p, x, 0, SIZE, 30);
                pnlPaginas.CreateGraphics().DrawString(M.ID.ToString(), Header, sbFont, x + 3, 5);

                int y = 0;
                while (y < Memoria.SizeMarco && M.Memoria[y] == true)
                {
                    pnlPaginas.CreateGraphics().FillRectangle(sb, x, y * 20 + 30, SIZE, 20);
                    y++;
                }

                pnlPaginas.CreateGraphics().DrawRectangle(p, x, 30, SIZE, 100);

                if (M.Estatus > 0)
                {
                    pnlPaginas.CreateGraphics().DrawString(M.Proceso.ToString(), Text, sbFont, x + 3, 35);
                }

                x += SIZE;
            }
        }
    }
}
