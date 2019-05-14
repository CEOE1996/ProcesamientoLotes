using System;
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
        Queue<clsProceso> ProcesosSuspendidos = new Queue<clsProceso>();
        clsProceso ProcesoActual;
        clsMemoria Memoria = new clsMemoria(MAX_MEMORY, MAX_MARCO);
        clsMemoria MemoriaVirtual = new clsMemoria(MAX_MEMORY, MAX_MARCO);

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
                P.Estado = "Listo";
                ProcesosListos.Enqueue(P);
                Memoria.addProcess(P);
                CountProcesos++;
                dgSiguiente.DataSource = SetSiguiente(ProcesosNuevos);
            }

            if (ProcesoActual != null && ProcesoActual.TR > 0)
            {
                lblCounter.Text = (++Counter).ToString();
                txtTR.Text = (--ProcesoActual.TR).ToString();
                txtTT.Text = (ProcesoActual.TME - ProcesoActual.TR).ToString();
                lblQuantum.Text = (++Quantum).ToString();
            }
            else if (ProcesoActual != null)
            {
                AddConcluido();
                pnlPaginas.Invalidate();
            }
            else if(ProcesosListos.Count > 0)
            {
                setActual();
                pnlPaginas.Invalidate();
            }
            else
            {
                lblCounter.Text = (++Counter).ToString();
            }

            if(ProcesosListos.Count + ProcesosNuevos.Count + ProcesosBloqueados.Count + ProcesosSuspendidos.Count == 0 && ProcesoActual == null)
            {
                timer1.Stop();
                MessageBox.Show("Se han concluido todos los procesos", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            lblCounterLote.Text = ProcesosNuevos.Count.ToString();
            lblSuspendidos.Text = ProcesosSuspendidos.Count.ToString();
            setData(ProcesoActual);
            ProcessBloqueados();

            if (Quantum >= MAX_QUANTUM)
            {
                ProcesoActual.Estado = "Listo";
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

            ProcesoActual.Estado = "Concluido";
            ProcesoActual.Finalizacion = Counter;
            ProcesoActual.Concluido = true;
            Memoria.removeProcess(ProcesoActual.Numero);
            Concluidos.Add(ProcesoActual);
            CountProcesos--;

            ProcesoActual = null;
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
                        ProcesoActual.Estado = "Bloqueado";
                        ProcesosBloqueados.Enqueue(ProcesoActual);
                        Memoria.changeStatus(ProcesoActual.Numero, 3);
                        setActual();
                        setData(ProcesoActual);
                    }
                    break;
                case Keys.E: //Error
                    if (timer1.Enabled && ProcesoActual != null)
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
                        dgSiguiente.DataSource = SetSiguiente(ProcesosNuevos);
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
                        BCP.AddRange(ProcesosSuspendidos);

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
                    frmTablaPaginas Paginas = new frmTablaPaginas(Memoria, MemoriaVirtual);
                    this.Hide();
                    Paginas.ShowDialog();
                    this.Show();
                    timer1.Start();
                    break;
                case Keys.S: //Suspendido
                    if(ProcesosBloqueados.Count > 0)
                    {
                        clsProceso Suspendido = ProcesosBloqueados.Dequeue();
                        Memoria.removeProcess(Suspendido.Numero);
                        Suspendido.Estado = "Suspendido";
                        ProcesosSuspendidos.Enqueue(Suspendido);
                        pnlPaginas.Invalidate();
                        GuardarSuspendidos();
                    }
                    break;
                case Keys.R: //Regresa Suspendido
                    if (ProcesosSuspendidos.Count > 0 && Memoria.canAccess(ProcesosSuspendidos.First().Tamano))
                    {
                        clsProceso Suspendido = ProcesosSuspendidos.Dequeue();
                        Memoria.addProcess(Suspendido, 3);
                        Suspendido.Estado = "Bloqueado";
                        ProcesosBloqueados.Enqueue(Suspendido);
                        GuardarSuspendidos();
                    }
                    break;
                case Keys.U: //Memoria Virtual
                    if (timer1.Enabled)
                    {
                        foreach(int i in Memoria.getDistinctProcess())
                        {
                            List<clsMarco> Virtual = Memoria.getProcess(i);
                            int len = Virtual.Count - 1;

                            if (len > 0 && Virtual[len].Estatus != 2 && MemoriaVirtual.canAccess(1))
                            {
                                MemoriaVirtual.addMarco(Memoria.removeMarco(Virtual[len].ID));
                            }
                        }
                    }
                    pnlPaginas.Invalidate();
                    break;
            }
        }

        private void setActual()
        {
            if (ProcesosListos.Count > 0)
            {
                Quantum = 0;
                ProcesoActual = ProcesosListos.Dequeue();

                if(Memoria.getSizeProceso(ProcesoActual.Numero) < ProcesoActual.Tamano / (double)MAX_MARCO)
                {
                    if(!Memoria.canAccess(MemoriaVirtual.getSizeProceso(ProcesoActual.Numero) * MAX_MARCO))
                    {
                        ProcesosListos.Enqueue(ProcesoActual);
                        ProcesoActual = null;
                        return;
                    }

                    List<clsMarco> Virtual = MemoriaVirtual.getProcess(ProcesoActual.Numero);
                    foreach(clsMarco M in Virtual)
                    {
                        Memoria.addMarco(MemoriaVirtual.removeMarco(M.ID));
                    }
                }

                ProcesoActual.Estado = "En Ejecucion";
                Memoria.changeStatus(ProcesoActual.Numero, 2);
                if(ProcesoActual.Respuesta == -1)
                {
                    ProcesoActual.Respuesta = Counter - ProcesoActual.Llegada;
                }
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

        private void GuardarSuspendidos()
        {
            System.IO.StreamWriter Escribir = new System.IO.StreamWriter("Suspendidos.txt");
            foreach (clsProceso P in ProcesosSuspendidos)
            {
                Escribir.WriteLine(P.ToString());
            }
            Escribir.Close();

            dgSuspendidos.DataSource = SetSiguiente(ProcesosSuspendidos);
        }
    }
}
