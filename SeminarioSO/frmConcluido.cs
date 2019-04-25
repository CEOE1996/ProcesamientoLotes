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
    public partial class frmConcluido : Form
    {
        List<clsProceso> ListProcesos = new List<clsProceso>();
        bool Finish;

        public frmConcluido(int c, List<clsProceso> L, bool Finish = true)
        {
            this.ListProcesos = L;
            this.Finish = Finish;
            InitializeComponent();
            lblCounter.Text = c.ToString();
            FillGrid();
        }

        private void FillGrid()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Operacion");
            dt.Columns.Add("Resultado");
            dt.Columns.Add("TME");
            dt.Columns.Add("Llegada");
            dt.Columns.Add("Finalizacion");
            dt.Columns.Add("Retorno");
            dt.Columns.Add("Respuesta");
            dt.Columns.Add("Espera");
            dt.Columns.Add("Servicio");
            if(!Finish)
            {
                dt.Columns.Add("Bloqueado");
            }

            foreach (clsProceso P in ListProcesos)
            {
                if (Finish)
                {
                    dt.Rows.Add(P.Numero, P.Operacion, P.Resultado, P.TME, P.Llegada, P.Finalizacion, P.Retorno, P.Respuesta, P.Espera, P.Servicio);
                }
                else if (P.Concluido)
                {
                    dt.Rows.Add(P.Numero, P.Operacion, P.Resultado, P.TME, P.Llegada, P.Finalizacion, P.Retorno, P.Respuesta, P.Espera, P.Servicio, 10 - P.Bloqueado);
                }
                else if (P.Llegada == -1)
                {
                    dt.Rows.Add(P.Numero, P.Operacion, "", P.TME, "", "", "", "", "", "", "");
                }
                else 
                {
                    dt.Rows.Add(P.Numero, P.Operacion, "", P.TME, P.Llegada, "", "", P.Respuesta == -1 ? "" : P.Respuesta.ToString(), P.Espera, P.Servicio, P.Bloqueado > 0 ? 10 - P.Bloqueado: P.Bloqueado);
                }
            }

            dgConcluidos.DataSource = dt;
        }

        private void dgConcluidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)char.ToUpper(e.KeyChar) == Keys.C)
                this.Close();
        }
    }
}
