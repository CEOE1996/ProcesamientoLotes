using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeminarioSO;
using SeminarioSO.Clases;

namespace SeminarioSO
{

    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if(txtProcesos.Value <= 0)
            {
                MessageBox.Show("Número de Procesos Inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtQuantum.Value <= 0)
            {
                MessageBox.Show("Valor de Quantum Inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Queue<clsProceso> ListProcesos = new Queue<clsProceso>();
            Random R = new Random();

            for (int i = 0; i < txtProcesos.Value; i++)
            {
                ListProcesos.Enqueue(new clsProceso(R));
            }

            frmProcess Ventana = new frmProcess(ListProcesos, Int32.Parse(txtQuantum.Value.ToString()));
            this.Hide();
            Ventana.ShowDialog();
            this.Close();
        }

    }
}
