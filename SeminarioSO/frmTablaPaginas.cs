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
    public partial class frmTablaPaginas : Form
    {
        clsMemoria Memoria;
        const int SIZE = 29;

        public frmTablaPaginas(clsMemoria Memoria)
        {
            this.Memoria = Memoria;
            InitializeComponent();

        }

        private void DrawPages()
        {
            Pen p = new Pen(Color.Black);
            SolidBrush sb = new SolidBrush(Color.Black);
            SolidBrush sbFont = new SolidBrush(Color.Black);
            int x = 0;

            Font Header = new Font("Arial", 14, FontStyle.Bold);
            Font Text = new Font("Arial", 12, FontStyle.Regular);

            foreach (clsMarco M in Memoria.Marcos)
            {
                switch (M.Estatus)
                {
                    case -1:
                        sb.Color = Color.Black;
                        break;
                    case 0:
                        sb.Color = Color.White;
                        break;
                    case 1:
                        sb.Color = Color.Blue;
                        break;
                    case 2:
                        sb.Color = Color.Red;
                        break;
                    case 3:
                        sb.Color = Color.Purple;
                        break;
                }

                pnlPaginas.CreateGraphics().DrawRectangle(p, x, 0, SIZE, 50);
                pnlPaginas.CreateGraphics().DrawString(M.ID.ToString(), Header, sbFont, x + 3, 20);

                int y = 0;
                while(y < Memoria.SizeMarco && M.Memoria[y] == true)
                {
                    pnlPaginas.CreateGraphics().FillRectangle(sb, x, y * 40 + 50, SIZE, 40);
                    y++;
                }

                pnlPaginas.CreateGraphics().DrawRectangle(p, x, 50, SIZE, 200);

                if (M.Estatus > 0)
                {
                    pnlPaginas.CreateGraphics().DrawString(M.Proceso.ToString(), Text, sbFont, x + 3, 60);
                }

                x += SIZE;
            }
        }

        private void pnlPaginas_Paint(object sender, PaintEventArgs e)
        {
           DrawPages();
        }

        private void frmTablaPaginas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Keys)char.ToUpper(e.KeyChar) == Keys.C)
            {
                this.Close();
            }

        }
    }
}
