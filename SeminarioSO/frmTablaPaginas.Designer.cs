namespace SeminarioSO
{
    partial class frmTablaPaginas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlPaginas = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(415, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(243, 39);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Tabla de Paginas";
            // 
            // pnlPaginas
            // 
            this.pnlPaginas.Location = new System.Drawing.Point(9, 63);
            this.pnlPaginas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlPaginas.Name = "pnlPaginas";
            this.pnlPaginas.Size = new System.Drawing.Size(1045, 257);
            this.pnlPaginas.TabIndex = 5;
            this.pnlPaginas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPaginas_Paint);
            // 
            // frmTablaPaginas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 329);
            this.Controls.Add(this.pnlPaginas);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmTablaPaginas";
            this.Text = "Tabla Paginas";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmTablaPaginas_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlPaginas;
    }
}