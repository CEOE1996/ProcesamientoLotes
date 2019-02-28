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

        public frmConcluido(List<clsProceso> L)
        {
            this.ListProcesos = L;
            InitializeComponent();
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

            foreach (clsProceso P in ListProcesos)
            {
                dt.Rows.Add(P.Numero, P.Operacion, P.Resultado, P.TME, P.Llegada, P.Finalizacion, P.Retorno, P.Respuesta, P.Espera, P.Servicio);
            }

            dgConcluidos.DataSource = dt;
        }
    }
}
