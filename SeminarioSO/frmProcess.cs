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
        List<clsLote> Lotes = new List<clsLote>();
        clsLote LoteActual = new clsLote();
        clsProceso ProcesoActual = new clsProceso();
        List<clsProceso> Concluidos = new List<clsProceso>();
        int TT = 0;
        int TR = 0;
        int Counter = 0;

        public frmProcess(List<clsLote> Lotes)
        {
            this.Lotes = Lotes;
            InitializeComponent();
            dgActual.DataSource = Lotes;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCounter.Text = (++Counter).ToString();
            if(TR >= 0)
            {
                txtTT.Text = (++TT).ToString();
                txtTR.Text = (--TR).ToString();
            }
            else if(LoteActual.Procesos.Count > 0)
            {
                ProcesoActual = LoteActual.Procesos.Dequeue();
                dgActual.DataSource = Lotes;
                txtNombre.Text = ProcesoActual.Nombre;
                txt .Text = ProcesoActual.Nombre;
                txtNombre.Text = ProcesoActual.Nombre;
                txtNombre.Text = ProcesoActual.Nombre;

            }


        }
    }
}
