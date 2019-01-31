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
        Queue<clsLote> Lotes = new Queue<clsLote>();
        clsLote LoteActual = new clsLote();
        clsProceso ProcesoActual;
        List<clsProceso> Concluidos = new List<clsProceso>();
        int TT = 0;
        int TR = 0;
        int Counter = 0;
        int NL = 0;

        public frmProcess(Queue<clsLote> Lotes)
        {
            this.Lotes = Lotes;
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(TR > 0)
            {
                lblCounter.Text = (++Counter).ToString();
                txtTT.Text = (++TT).ToString();
                txtTR.Text = (--TR).ToString();
            }
            else if(LoteActual.Procesos.Count > 0)
            {
                if (ProcesoActual != null) {
                    Concluidos.Add(ProcesoActual);
                }
                ProcesoActual = LoteActual.Procesos.Dequeue();
                ProcesoActual.NL = NL;
                dgActual.DataSource = Lotes;
                txtNombre.Text = ProcesoActual.Nombre;
                txtOp .Text = ProcesoActual.Operacion;
                txtNumero.Text = ProcesoActual.Numero.ToString();
                txtTME.Text = ProcesoActual.TME.ToString();
                TR = ProcesoActual.TME;
                TT = 0;
                txtTT.Text = (TT).ToString();
                txtTR.Text = (TR).ToString();
                dgActual.DataSource = SetActual(LoteActual);
                if (Concluidos.Count > 0)
                {
                    dgConcluidos.DataSource = SetConcluidos(Concluidos);
                }
            }
            else if(Lotes.Count > 0)
            {
                LoteActual = Lotes.Dequeue();
                dgActual.DataSource = SetActual(LoteActual);
                if (Concluidos.Count > 0)
                {
                    dgConcluidos.DataSource = SetConcluidos(Concluidos);
                }

                NL++;
            }
            else
            {
                if (ProcesoActual != null)
                {
                    Concluidos.Add(ProcesoActual);
                    dgConcluidos.DataSource = SetConcluidos(Concluidos);
                }
                timer1.Stop();
                MessageBox.Show("Se han concluido todos los procesos", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lblCounterLote.Text = Lotes.Count.ToString();
     
            System.Threading.Thread.Sleep(1000);

        }

        private DataTable SetActual(clsLote L)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre");
            dt.Columns.Add("TME");

            foreach(clsProceso P in L.Procesos)
            {
                dt.Rows.Add(P.Nombre, P.TME);
            }

            return dt;
        }

        private DataTable SetConcluidos(List<clsProceso> L)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Lote");
            dt.Columns.Add("Número");
            dt.Columns.Add("Operacion");
            dt.Columns.Add("Resultado");

            foreach (clsProceso P in L)
            {
                dt.Rows.Add(P.NL, P.Nombre, P.Operacion, P.Resultado);
            }

            return dt;
        }
    }
}
