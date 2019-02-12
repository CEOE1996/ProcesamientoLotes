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
        int Counter = 0, NL = 0;

        public frmProcess(Queue<clsLote> Lotes)
        {
            this.Lotes = Lotes;
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ProcesoActual != null && ProcesoActual.TR > 0)
            {
                lblCounter.Text = (++Counter).ToString();
                txtTR.Text = (--ProcesoActual.TR).ToString();
                txtTT.Text = (ProcesoActual.TME - ProcesoActual.TR).ToString();
            }
            else if(LoteActual.Procesos.Count > 0)
            {
                if (ProcesoActual != null) {
                    Concluidos.Add(ProcesoActual);
                }

                setActual();
                setData(ProcesoActual);

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
     
        }

        private DataTable SetActual(clsLote L)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("TME");
            dt.Columns.Add("TR");

            foreach (clsProceso P in L.Procesos)
            {
                dt.Rows.Add(P.Numero, P.TME, P.TR);
            }

            return dt;
        }

        private DataTable SetConcluidos(List<clsProceso> L)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Lote");
            dt.Columns.Add("ID");
            dt.Columns.Add("Operacion");
            dt.Columns.Add("Resultado");

            foreach (clsProceso P in L)
            {
                dt.Rows.Add(P.NL, P.Numero, P.Operacion, P.Resultado);
            }

            return dt;
        }

        private void setData(clsProceso P)
        {
            txtOp.Text = P.Operacion;
            txtNumero.Text = P.Numero.ToString();
            txtTME.Text = P.TME.ToString();
            txtTT.Text = (P.TME - P.TR).ToString();
            txtTR.Text = (P.TR).ToString();
            dgActual.DataSource = SetActual(LoteActual);
        }

        private void dgActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressKey((Keys)char.ToUpper(e.KeyChar));
        }

        private void PressKey(Keys K){
            switch (K)
            {
                case Keys.I:
                    if (timer1.Enabled)
                    {
                        LoteActual.Procesos.Enqueue(ProcesoActual);
                        setActual();
                        setData(ProcesoActual);
                    }
                    break;
                case Keys.E:
                    if (timer1.Enabled)
                    {
                        ProcesoActual.Resultado = "Error";
                        ProcesoActual.TR = 0;
                    }
                    break;
                case Keys.P:
                    timer1.Stop();
                    break;
                case Keys.C:
                    timer1.Start();
                    break;
            }
        }

        private void setActual()
        {
            ProcesoActual = LoteActual.Procesos.Dequeue();
            ProcesoActual.NL = NL;
        }
    }
}
