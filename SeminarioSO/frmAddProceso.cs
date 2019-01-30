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
        const int MAX_LOTE = 3;
        int NProcesos;
        int Counter = 1;
        Queue<clsProceso> Procesos = new Queue<clsProceso>();

        public frmAddProceso(int N)
        {
            NProcesos = N;
            InitializeComponent();
            lblCounter.Text = Counter.ToString() + " de " + NProcesos.ToString();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtNombre.Text) || txtNumero.Value <= 0 || String.IsNullOrEmpty(cboOp.SelectedItem.ToString()))
            {
                MessageBox.Show("Datos Inválidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if((cboOp.SelectedItem.ToString() == "/" || cboOp.SelectedItem.ToString() == "%") && txtN2.Value == 0)
            {
                MessageBox.Show("Imposible Dividir entre 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach(clsProceso p in Procesos){
                if(p.Numero == txtNumero.Value)
                {
                    MessageBox.Show("Identificador Duplicado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            clsProceso NuevoProceso = new clsProceso(
                                                        txtNombre.Text, 
                                                        Decimal.ToInt32(txtN1.Value),
                                                        Decimal.ToInt32(txtN2.Value),
                                                        cboOp.SelectedItem.ToString()[0],
                                                        Decimal.ToInt32(txtTiempo.Value),
                                                        Decimal.ToInt32(txtNumero.Value)
                                                    );

            Procesos.Enqueue(NuevoProceso);

            if(++Counter > NProcesos)
            {
                int i = 0;
                Queue<clsLote> ListLotes = new Queue<clsLote>();
                Queue<clsProceso> Lote = new Queue<clsProceso>();
                while (Procesos.Count > 0)
                {
                    Lote.Enqueue(Procesos.Dequeue());
                    if(++i >= MAX_LOTE)
                    {
                        i = 0;
                        ListLotes.Enqueue(new clsLote(Lote));
                        Lote = new Queue<clsProceso>();
                    }
                }

                if (Lote.Count > 0)
                {
                    ListLotes.Enqueue(new clsLote(Lote));
                }
            }
            else
            {
                lblCounter.Text = Counter.ToString() + " de " + NProcesos.ToString();
                txtNombre.Clear();
            }

        }
    }
}
