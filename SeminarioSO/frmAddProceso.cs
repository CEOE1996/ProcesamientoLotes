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
    public partial class frmAddProceso : Form
    {
        int NProcesos;
        int Counter = 1;
        List<clsProceso> Procesos = new List<clsProceso>();

        public frmAddProceso(int N)
        {
            NProcesos = N;
            InitializeComponent();
            lblCounter.Text = Counter.ToString() + " de " + NProcesos.ToString();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {

        }
    }
}
