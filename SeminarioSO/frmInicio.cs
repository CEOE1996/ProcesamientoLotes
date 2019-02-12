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
    public enum Operacion
    {
        Suma,
        Resta,
        Multiplicacion,
        Division,
        Residuo
    }

    public partial class frmInicio : Form
    {
        const int MAX_LOTE = 3;

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

            Random R = new Random();
            int N = 1, i = 0;
            decimal N1, N2, Resultado;
            char Signo;
            Operacion Op;
            Queue<clsProceso> ListProcesos = new Queue<clsProceso>();

            for (i = 0; i < txtProcesos.Value; i++)
            {
                N1 = R.Next(1, 100);
                N2 = R.Next(1, 100);
                Op = (Operacion)R.Next(5);

                switch (Op)
                {
                    case Operacion.Suma:
                        Signo = '+';
                        Resultado = N1 + N2;
                        break;

                    case Operacion.Resta:
                        Signo = '-';
                        Resultado = N1 - N2;
                        break;

                    case Operacion.Multiplicacion:
                        Signo = '*';
                        Resultado = N1 * N2;
                        break;
                    case Operacion.Division:
                        Signo = '/';
                        Resultado = N1 / N2;
                        break;
                    case Operacion.Residuo:
                        Signo = '%';
                        Resultado = N1 % N2;
                        break;
                    default:
                        Signo = '?';
                        Resultado = 0;
                        break;
                }

                ListProcesos.Enqueue(new clsProceso(
                                                        N1.ToString() + Signo + N2.ToString(),
                                                        Math.Round(Resultado, 4).ToString(),
                                                        R.Next(10),
                                                        N++
                                                    ));
            }

            i = 0;
            Queue<clsLote> ListLotes = new Queue<clsLote>();
            Queue<clsProceso> Lote = new Queue<clsProceso>();
            while (ListProcesos.Count > 0)
            {
                Lote.Enqueue(ListProcesos.Dequeue());
                if (++i >= MAX_LOTE)
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
            this.Close();
        }

    }
}
