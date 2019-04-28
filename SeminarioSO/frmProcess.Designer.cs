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
            this.lblTitle = new System.Windows.Forms.Label();
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
            this.label10 = new System.Windows.Forms.Label();
            this.dgBloqueados = new System.Windows.Forms.DataGridView();
            this.lblMaxQuantum = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblQuantum = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgSiguiente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSuspendidos = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgConcluidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBloqueados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Procesos Nuevos:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(259, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(306, 39);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Procesos en Ejecución";
            // 
            // lblCounterLote
            // 
            this.lblCounterLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounterLote.ForeColor = System.Drawing.Color.Black;
            this.lblCounterLote.Location = new System.Drawing.Point(154, 59);
            this.lblCounterLote.Name = "lblCounterLote";
            this.lblCounterLote.Size = new System.Drawing.Size(74, 20);
            this.lblCounterLote.TabIndex = 5;
            // 
            // lblCounter
            // 
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.ForeColor = System.Drawing.Color.Black;
            this.lblCounter.Location = new System.Drawing.Point(756, 59);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(74, 20);
            this.lblCounter.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(669, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contador:";
            // 
            // dgActual
            // 
            this.dgActual.AllowUserToAddRows = false;
            this.dgActual.AllowUserToDeleteRows = false;
            this.dgActual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgActual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgActual.Location = new System.Drawing.Point(15, 224);
            this.dgActual.Name = "dgActual";
            this.dgActual.ReadOnly = true;
            this.dgActual.Size = new System.Drawing.Size(240, 182);
            this.dgActual.TabIndex = 8;
            this.dgActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgActual_KeyPress);
            // 
            // dgConcluidos
            // 
            this.dgConcluidos.AllowUserToAddRows = false;
            this.dgConcluidos.AllowUserToDeleteRows = false;
            this.dgConcluidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgConcluidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConcluidos.Location = new System.Drawing.Point(590, 131);
            this.dgConcluidos.Name = "dgConcluidos";
            this.dgConcluidos.ReadOnly = true;
            this.dgConcluidos.Size = new System.Drawing.Size(240, 365);
            this.dgConcluidos.TabIndex = 9;
            this.dgConcluidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgActual_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(74, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Procesos Listos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(627, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Procesos Concluidos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(328, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Proceso en Ejecución";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(266, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 27);
            this.label7.TabIndex = 16;
            this.label7.Text = "Número de Programa:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(266, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 27);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tiempo Máximo Estimado:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(266, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 27);
            this.label9.TabIndex = 14;
            this.label9.Text = "Operación:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(266, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 27);
            this.label11.TabIndex = 17;
            this.label11.Text = "Tiempo Transcurrido:";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(266, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 27);
            this.label12.TabIndex = 18;
            this.label12.Text = "Tiempo Restante:";
            // 
            // txtTR
            // 
            this.txtTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTR.ForeColor = System.Drawing.Color.Black;
            this.txtTR.Location = new System.Drawing.Point(443, 289);
            this.txtTR.Name = "txtTR";
            this.txtTR.Size = new System.Drawing.Size(132, 27);
            this.txtTR.TabIndex = 24;
            // 
            // txtTT
            // 
            this.txtTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTT.ForeColor = System.Drawing.Color.Black;
            this.txtTT.Location = new System.Drawing.Point(443, 251);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(132, 27);
            this.txtTT.TabIndex = 23;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.Color.Black;
            this.txtNumero.Location = new System.Drawing.Point(443, 138);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(132, 27);
            this.txtNumero.TabIndex = 22;
            // 
            // txtTME
            // 
            this.txtTME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTME.ForeColor = System.Drawing.Color.Black;
            this.txtTME.Location = new System.Drawing.Point(443, 213);
            this.txtTME.Name = "txtTME";
            this.txtTME.Size = new System.Drawing.Size(132, 27);
            this.txtTME.TabIndex = 21;
            // 
            // txtOp
            // 
            this.txtOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOp.ForeColor = System.Drawing.Color.Black;
            this.txtOp.Location = new System.Drawing.Point(443, 175);
            this.txtOp.Name = "txtOp";
            this.txtOp.Size = new System.Drawing.Size(132, 27);
            this.txtOp.TabIndex = 20;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(335, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Procesos Bloqueados";
            // 
            // dgBloqueados
            // 
            this.dgBloqueados.AllowUserToAddRows = false;
            this.dgBloqueados.AllowUserToDeleteRows = false;
            this.dgBloqueados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgBloqueados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBloqueados.Location = new System.Drawing.Point(298, 387);
            this.dgBloqueados.Name = "dgBloqueados";
            this.dgBloqueados.ReadOnly = true;
            this.dgBloqueados.Size = new System.Drawing.Size(240, 109);
            this.dgBloqueados.TabIndex = 25;
            // 
            // lblMaxQuantum
            // 
            this.lblMaxQuantum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxQuantum.ForeColor = System.Drawing.Color.Black;
            this.lblMaxQuantum.Location = new System.Drawing.Point(574, 59);
            this.lblMaxQuantum.Name = "lblMaxQuantum";
            this.lblMaxQuantum.Size = new System.Drawing.Size(74, 20);
            this.lblMaxQuantum.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(456, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Max Quantum:";
            // 
            // lblQuantum
            // 
            this.lblQuantum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantum.ForeColor = System.Drawing.Color.Black;
            this.lblQuantum.Location = new System.Drawing.Point(443, 326);
            this.lblQuantum.Name = "lblQuantum";
            this.lblQuantum.Size = new System.Drawing.Size(132, 27);
            this.lblQuantum.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(266, 326);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 27);
            this.label14.TabIndex = 29;
            this.label14.Text = "Quantum:";
            // 
            // dgSiguiente
            // 
            this.dgSiguiente.AllowUserToAddRows = false;
            this.dgSiguiente.AllowUserToDeleteRows = false;
            this.dgSiguiente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgSiguiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSiguiente.Location = new System.Drawing.Point(15, 131);
            this.dgSiguiente.Name = "dgSiguiente";
            this.dgSiguiente.ReadOnly = true;
            this.dgSiguiente.Size = new System.Drawing.Size(240, 53);
            this.dgSiguiente.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(65, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Proceso Siguiente";
            // 
            // lblSuspendidos
            // 
            this.lblSuspendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuspendidos.ForeColor = System.Drawing.Color.Black;
            this.lblSuspendidos.Location = new System.Drawing.Point(361, 59);
            this.lblSuspendidos.Name = "lblSuspendidos";
            this.lblSuspendidos.Size = new System.Drawing.Size(74, 20);
            this.lblSuspendidos.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(249, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 20);
            this.label16.TabIndex = 33;
            this.label16.Text = "Suspendidos:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(54, 421);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(165, 20);
            this.label15.TabIndex = 36;
            this.label15.Text = "Suspendido Siguiente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 443);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 53);
            this.dataGridView1.TabIndex = 35;
            // 
            // frmProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 504);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblSuspendidos);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgSiguiente);
            this.Controls.Add(this.lblQuantum);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblMaxQuantum);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgBloqueados);
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
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.Name = "frmProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProcess";
            ((System.ComponentModel.ISupportInitialize)(this.dgActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgConcluidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBloqueados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgBloqueados;
        private System.Windows.Forms.Label lblMaxQuantum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblQuantum;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgSiguiente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSuspendidos;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}