namespace SeminarioSO
{
    partial class frmProcess
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCounterLote = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgActual = new System.Windows.Forms.DataGridView();
            this.dgConcluidos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTR = new System.Windows.Forms.Label();
            this.txtTT = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.Label();
            this.txtTME = new System.Windows.Forms.Label();
            this.txtOp = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgConcluidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lotes Pendientes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(339, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Procesamiento de Lotes";
            // 
            // lblCounterLote
            // 
            this.lblCounterLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounterLote.ForeColor = System.Drawing.Color.Black;
            this.lblCounterLote.Location = new System.Drawing.Point(263, 69);
            this.lblCounterLote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounterLote.Name = "lblCounterLote";
            this.lblCounterLote.Size = new System.Drawing.Size(212, 34);
            this.lblCounterLote.TabIndex = 5;
            // 
            // lblCounter
            // 
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.ForeColor = System.Drawing.Color.Black;
            this.lblCounter.Location = new System.Drawing.Point(892, 69);
            this.lblCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(212, 34);
            this.lblCounter.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(645, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contador:";
            // 
            // dgActual
            // 
            this.dgActual.AllowUserToAddRows = false;
            this.dgActual.AllowUserToDeleteRows = false;
            this.dgActual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgActual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgActual.Location = new System.Drawing.Point(21, 180);
            this.dgActual.Margin = new System.Windows.Forms.Padding(4);
            this.dgActual.Name = "dgActual";
            this.dgActual.ReadOnly = true;
            this.dgActual.Size = new System.Drawing.Size(320, 335);
            this.dgActual.TabIndex = 8;
            this.dgActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgActual_KeyPress);
            // 
            // dgConcluidos
            // 
            this.dgConcluidos.AllowUserToAddRows = false;
            this.dgConcluidos.AllowUserToDeleteRows = false;
            this.dgConcluidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgConcluidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConcluidos.Location = new System.Drawing.Point(787, 180);
            this.dgConcluidos.Margin = new System.Windows.Forms.Padding(4);
            this.dgConcluidos.Name = "dgConcluidos";
            this.dgConcluidos.ReadOnly = true;
            this.dgConcluidos.Size = new System.Drawing.Size(320, 335);
            this.dgConcluidos.TabIndex = 9;
            this.dgConcluidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgActual_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(116, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lote Actual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(823, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Procesos Concluidos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(437, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Proceso en Ejecución";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(355, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 34);
            this.label7.TabIndex = 16;
            this.label7.Text = "Número de Programa:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(355, 314);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 34);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tiempo Máximo Estimado:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(355, 247);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 34);
            this.label9.TabIndex = 14;
            this.label9.Text = "Operación:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(355, 381);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(228, 34);
            this.label11.TabIndex = 17;
            this.label11.Text = "Tiempo Transcurrido:";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(355, 448);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(228, 34);
            this.label12.TabIndex = 18;
            this.label12.Text = "Tiempo Restante:";
            // 
            // txtTR
            // 
            this.txtTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTR.ForeColor = System.Drawing.Color.Black;
            this.txtTR.Location = new System.Drawing.Point(591, 448);
            this.txtTR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTR.Name = "txtTR";
            this.txtTR.Size = new System.Drawing.Size(176, 34);
            this.txtTR.TabIndex = 24;
            // 
            // txtTT
            // 
            this.txtTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTT.ForeColor = System.Drawing.Color.Black;
            this.txtTT.Location = new System.Drawing.Point(591, 381);
            this.txtTT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(176, 34);
            this.txtTT.TabIndex = 23;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.Color.Black;
            this.txtNumero.Location = new System.Drawing.Point(591, 180);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(176, 34);
            this.txtNumero.TabIndex = 22;
            // 
            // txtTME
            // 
            this.txtTME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTME.ForeColor = System.Drawing.Color.Black;
            this.txtTME.Location = new System.Drawing.Point(591, 314);
            this.txtTME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTME.Name = "txtTME";
            this.txtTME.Size = new System.Drawing.Size(176, 34);
            this.txtTME.TabIndex = 21;
            // 
            // txtOp
            // 
            this.txtOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOp.ForeColor = System.Drawing.Color.Black;
            this.txtOp.Location = new System.Drawing.Point(591, 247);
            this.txtOp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtOp.Name = "txtOp";
            this.txtOp.Size = new System.Drawing.Size(176, 34);
            this.txtOp.TabIndex = 20;
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 529);
            this.Controls.Add(this.txtTR);
            this.Controls.Add(this.txtTT);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtTME);
            this.Controls.Add(this.txtOp);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgConcluidos);
            this.Controls.Add(this.dgActual);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCounterLote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProcess";
            ((System.ComponentModel.ISupportInitialize)(this.dgActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgConcluidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCounterLote;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgActual;
        private System.Windows.Forms.DataGridView dgConcluidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtTR;
        private System.Windows.Forms.Label txtTT;
        private System.Windows.Forms.Label txtNumero;
        private System.Windows.Forms.Label txtTME;
        private System.Windows.Forms.Label txtOp;
        private System.Windows.Forms.Timer timer1;
    }
}