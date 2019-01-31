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
            if(String.IsNullOrEmpty(txtNombre.Text) || txtNumero.Value <= 0 || txtTiempo.Value <= 0 || String.IsNullOrEmpty(cboOp.SelectedItem.ToString()))
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

            decimal Resultado;
            switch (cboOp.SelectedItem.ToString()[0])
            {
                case '+':
                    Resultado = txtN1.Value + txtN2.Value;
                    break;

                case '-':
                    Resultado = txtN1.Value - txtN2.Value;
                    break;

                case '*':
                    Resultado = txtN1.Value * txtN2.Value;
                    break;
                case '/':
                    Resultado = txtN1.Value / txtN2.Value;
                    break;
                case '%':
                    Resultado = txtN1.Value % txtN2.Value;
                    break;
                default:
                    Resultado = 0;
                    break;
            }

            clsProceso NuevoProceso = new clsProceso(
                                                        txtNombre.Text, 
                                                        txtN1.Value.ToString() + cboOp.SelectedItem.ToString()[0] + txtN2.Value.ToString(),
                                                        Resultado,
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

                frmProcess Ventana = new frmProcess(ListLotes);
                this.Hide();
                Ventana.ShowDialog();
            }
            else
            {
                lblCounter.Text = Counter.ToString() + " de " + NProcesos.ToString();
                txtNombre.Clear();
                txtNombre.Focus();
            }

        }
    }
}
