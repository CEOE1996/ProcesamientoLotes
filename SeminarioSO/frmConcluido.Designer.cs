namespace SeminarioSO
{
    partial class frmConcluido
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
            this.dgConcluidos = new System.Windows.Forms.DataGridView();
            this.lblCounter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgConcluidos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(532, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(103, 59);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "BCP";
            // 
            // dgConcluidos
            // 
            this.dgConcluidos.AllowUserToAddRows = false;
            this.dgConcluidos.AllowUserToDeleteRows = false;
            this.dgConcluidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgConcluidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConcluidos.Location = new System.Drawing.Point(12, 85);
            this.dgConcluidos.Name = "dgConcluidos";
            this.dgConcluidos.ReadOnly = true;
            this.dgConcluidos.RowTemplate.Height = 28;
            this.dgConcluidos.Size = new System.Drawing.Size(1143, 571);
            this.dgConcluidos.TabIndex = 5;
            // 
            // lblCounter
            // 
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.ForeColor = System.Drawing.Color.Black;
            this.lblCounter.Location = new System.Drawing.Point(974, 26);
            this.lblCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(181, 42);
            this.lblCounter.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(846, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contador:";
            // 
            // frmConcluido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 668);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgConcluidos);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmConcluido";
            this.Text = "frmConcluido";
            ((System.ComponentModel.ISupportInitialize)(this.dgConcluidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgConcluidos;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Label label4;
    }
}