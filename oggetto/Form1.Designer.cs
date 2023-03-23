namespace oggetto
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.lbl_Titolo = new System.Windows.Forms.Label();
            this.nUD_1 = new System.Windows.Forms.NumericUpDown();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.nUD_2 = new System.Windows.Forms.NumericUpDown();
            this.pnl_Scelta = new System.Windows.Forms.Panel();
            this.rd5 = new System.Windows.Forms.RadioButton();
            this.rd4 = new System.Windows.Forms.RadioButton();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.lbl_4 = new System.Windows.Forms.Label();
            this.nUD_3 = new System.Windows.Forms.NumericUpDown();
            this.btn_Ridisegna = new System.Windows.Forms.Button();
            this.pnl_Dati = new System.Windows.Forms.Panel();
            this.pnl_FrattSemplice = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdb_t12 = new System.Windows.Forms.RadioButton();
            this.rdb_t11 = new System.Windows.Forms.RadioButton();
            this.rdb_t10 = new System.Windows.Forms.RadioButton();
            this.rdb_t9 = new System.Windows.Forms.RadioButton();
            this.rdb_t4 = new System.Windows.Forms.RadioButton();
            this.rdb_t3 = new System.Windows.Forms.RadioButton();
            this.rdb_t2 = new System.Windows.Forms.RadioButton();
            this.rdb_t1 = new System.Windows.Forms.RadioButton();
            this.rdb_t8 = new System.Windows.Forms.RadioButton();
            this.rdb_t7 = new System.Windows.Forms.RadioButton();
            this.rdb_t6 = new System.Windows.Forms.RadioButton();
            this.rdb_t5 = new System.Windows.Forms.RadioButton();
            this.lbldsf = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_2)).BeginInit();
            this.pnl_Scelta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_3)).BeginInit();
            this.pnl_Dati.SuspendLayout();
            this.pnl_FrattSemplice.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Yellow;
            this.btnStart.Location = new System.Drawing.Point(4, 185);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 39);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Calcola";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnl.Location = new System.Drawing.Point(19, 304);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(189, 122);
            this.pnl.TabIndex = 1;
            this.pnl.Visible = false;
            // 
            // lbl_Titolo
            // 
            this.lbl_Titolo.AutoSize = true;
            this.lbl_Titolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titolo.Location = new System.Drawing.Point(12, 9);
            this.lbl_Titolo.Name = "lbl_Titolo";
            this.lbl_Titolo.Size = new System.Drawing.Size(592, 37);
            this.lbl_Titolo.TabIndex = 0;
            this.lbl_Titolo.Text = "Un insieme di Mandelbrot al computer";
            // 
            // nUD_1
            // 
            this.nUD_1.Location = new System.Drawing.Point(159, 0);
            this.nUD_1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nUD_1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_1.Name = "nUD_1";
            this.nUD_1.Size = new System.Drawing.Size(120, 20);
            this.nUD_1.TabIndex = 1;
            this.nUD_1.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(3, 0);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(139, 20);
            this.lbl_1.TabIndex = 4;
            this.lbl_1.Text = "Numero ripetizioni:";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.Location = new System.Drawing.Point(3, 0);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(131, 20);
            this.lbl_2.TabIndex = 5;
            this.lbl_2.Text = "Valore confronto:";
            // 
            // nUD_2
            // 
            this.nUD_2.DecimalPlaces = 4;
            this.nUD_2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nUD_2.Location = new System.Drawing.Point(159, 0);
            this.nUD_2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.nUD_2.Name = "nUD_2";
            this.nUD_2.Size = new System.Drawing.Size(120, 20);
            this.nUD_2.TabIndex = 2;
            this.nUD_2.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // pnl_Scelta
            // 
            this.pnl_Scelta.Controls.Add(this.rd5);
            this.pnl_Scelta.Controls.Add(this.rd4);
            this.pnl_Scelta.Controls.Add(this.rd3);
            this.pnl_Scelta.Controls.Add(this.lbl_3);
            this.pnl_Scelta.Location = new System.Drawing.Point(4, 3);
            this.pnl_Scelta.Name = "pnl_Scelta";
            this.pnl_Scelta.Size = new System.Drawing.Size(279, 31);
            this.pnl_Scelta.TabIndex = 3;
            // 
            // rd5
            // 
            this.rd5.AutoSize = true;
            this.rd5.Location = new System.Drawing.Point(210, 3);
            this.rd5.Name = "rd5";
            this.rd5.Size = new System.Drawing.Size(67, 17);
            this.rd5.TabIndex = 4;
            this.rd5.Text = "Suprema";
            this.rd5.UseVisualStyleBackColor = true;
            // 
            // rd4
            // 
            this.rd4.AutoSize = true;
            this.rd4.Location = new System.Drawing.Point(149, 3);
            this.rd4.Name = "rd4";
            this.rd4.Size = new System.Drawing.Size(55, 17);
            this.rd4.TabIndex = 3;
            this.rd4.Text = "Ottima";
            this.rd4.UseVisualStyleBackColor = true;
            // 
            // rd3
            // 
            this.rd3.AutoSize = true;
            this.rd3.Checked = true;
            this.rd3.Location = new System.Drawing.Point(87, 3);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(56, 17);
            this.rd3.TabIndex = 2;
            this.rd3.TabStop = true;
            this.rd3.Text = "Buona";
            this.rd3.UseVisualStyleBackColor = true;
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3.Location = new System.Drawing.Point(4, 0);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(63, 20);
            this.lbl_3.TabIndex = 0;
            this.lbl_3.Text = "Qualità:";
            // 
            // btn_Restart
            // 
            this.btn_Restart.BackColor = System.Drawing.Color.Yellow;
            this.btn_Restart.Location = new System.Drawing.Point(1045, 12);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(81, 37);
            this.btn_Restart.TabIndex = 6;
            this.btn_Restart.Text = "Restart";
            this.btn_Restart.UseVisualStyleBackColor = false;
            this.btn_Restart.Visible = false;
            this.btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // lbl_4
            // 
            this.lbl_4.AutoSize = true;
            this.lbl_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_4.Location = new System.Drawing.Point(-1, -3);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(118, 20);
            this.lbl_4.TabIndex = 7;
            this.lbl_4.Text = "Elevazione di z:";
            // 
            // nUD_3
            // 
            this.nUD_3.Location = new System.Drawing.Point(159, 0);
            this.nUD_3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUD_3.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUD_3.Name = "nUD_3";
            this.nUD_3.Size = new System.Drawing.Size(120, 20);
            this.nUD_3.TabIndex = 8;
            this.nUD_3.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btn_Ridisegna
            // 
            this.btn_Ridisegna.BackColor = System.Drawing.Color.Yellow;
            this.btn_Ridisegna.Location = new System.Drawing.Point(1132, 12);
            this.btn_Ridisegna.Name = "btn_Ridisegna";
            this.btn_Ridisegna.Size = new System.Drawing.Size(81, 37);
            this.btn_Ridisegna.TabIndex = 9;
            this.btn_Ridisegna.Text = "Ridisegna";
            this.btn_Ridisegna.UseVisualStyleBackColor = false;
            this.btn_Ridisegna.Visible = false;
            this.btn_Ridisegna.Click += new System.EventHandler(this.AggiornaGrafica);
            // 
            // pnl_Dati
            // 
            this.pnl_Dati.Controls.Add(this.pnl_FrattSemplice);
            this.pnl_Dati.Controls.Add(this.panel1);
            this.pnl_Dati.Controls.Add(this.panel3);
            this.pnl_Dati.Controls.Add(this.pnl_Scelta);
            this.pnl_Dati.Controls.Add(this.btnStart);
            this.pnl_Dati.Location = new System.Drawing.Point(19, 49);
            this.pnl_Dati.Name = "pnl_Dati";
            this.pnl_Dati.Size = new System.Drawing.Size(594, 249);
            this.pnl_Dati.TabIndex = 10;
            // 
            // pnl_FrattSemplice
            // 
            this.pnl_FrattSemplice.Controls.Add(this.panel2);
            this.pnl_FrattSemplice.Controls.Add(this.panel4);
            this.pnl_FrattSemplice.Location = new System.Drawing.Point(287, 78);
            this.pnl_FrattSemplice.Name = "pnl_FrattSemplice";
            this.pnl_FrattSemplice.Size = new System.Drawing.Size(298, 85);
            this.pnl_FrattSemplice.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_1);
            this.panel2.Controls.Add(this.nUD_1);
            this.panel2.Location = new System.Drawing.Point(6, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 31);
            this.panel2.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_4);
            this.panel4.Controls.Add(this.nUD_3);
            this.panel4.Location = new System.Drawing.Point(6, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(279, 31);
            this.panel4.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdb_t12);
            this.panel1.Controls.Add(this.rdb_t11);
            this.panel1.Controls.Add(this.rdb_t10);
            this.panel1.Controls.Add(this.rdb_t9);
            this.panel1.Controls.Add(this.rdb_t4);
            this.panel1.Controls.Add(this.rdb_t3);
            this.panel1.Controls.Add(this.rdb_t2);
            this.panel1.Controls.Add(this.rdb_t1);
            this.panel1.Controls.Add(this.rdb_t8);
            this.panel1.Controls.Add(this.rdb_t7);
            this.panel1.Controls.Add(this.rdb_t6);
            this.panel1.Controls.Add(this.rdb_t5);
            this.panel1.Controls.Add(this.lbldsf);
            this.panel1.Location = new System.Drawing.Point(4, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 102);
            this.panel1.TabIndex = 14;
            // 
            // rdb_t12
            // 
            this.rdb_t12.AutoSize = true;
            this.rdb_t12.Location = new System.Drawing.Point(191, 69);
            this.rdb_t12.Name = "rdb_t12";
            this.rdb_t12.Size = new System.Drawing.Size(61, 17);
            this.rdb_t12.TabIndex = 17;
            this.rdb_t12.Text = "Tipo 12";
            this.rdb_t12.UseVisualStyleBackColor = true;
            // 
            // rdb_t11
            // 
            this.rdb_t11.AutoSize = true;
            this.rdb_t11.Location = new System.Drawing.Point(130, 69);
            this.rdb_t11.Name = "rdb_t11";
            this.rdb_t11.Size = new System.Drawing.Size(61, 17);
            this.rdb_t11.TabIndex = 16;
            this.rdb_t11.Text = "Tipo 11";
            this.rdb_t11.UseVisualStyleBackColor = true;
            // 
            // rdb_t10
            // 
            this.rdb_t10.AutoSize = true;
            this.rdb_t10.Location = new System.Drawing.Point(69, 69);
            this.rdb_t10.Name = "rdb_t10";
            this.rdb_t10.Size = new System.Drawing.Size(61, 17);
            this.rdb_t10.TabIndex = 15;
            this.rdb_t10.Text = "Tipo 10";
            this.rdb_t10.UseVisualStyleBackColor = true;
            // 
            // rdb_t9
            // 
            this.rdb_t9.AutoSize = true;
            this.rdb_t9.Location = new System.Drawing.Point(8, 69);
            this.rdb_t9.Name = "rdb_t9";
            this.rdb_t9.Size = new System.Drawing.Size(55, 17);
            this.rdb_t9.TabIndex = 14;
            this.rdb_t9.Text = "Tipo 9";
            this.rdb_t9.UseVisualStyleBackColor = true;
            // 
            // rdb_t4
            // 
            this.rdb_t4.AutoSize = true;
            this.rdb_t4.Location = new System.Drawing.Point(191, 23);
            this.rdb_t4.Name = "rdb_t4";
            this.rdb_t4.Size = new System.Drawing.Size(55, 17);
            this.rdb_t4.TabIndex = 13;
            this.rdb_t4.Text = "Tipo 4";
            this.rdb_t4.UseVisualStyleBackColor = true;
            // 
            // rdb_t3
            // 
            this.rdb_t3.AutoSize = true;
            this.rdb_t3.Location = new System.Drawing.Point(130, 23);
            this.rdb_t3.Name = "rdb_t3";
            this.rdb_t3.Size = new System.Drawing.Size(55, 17);
            this.rdb_t3.TabIndex = 12;
            this.rdb_t3.Text = "Tipo 3";
            this.rdb_t3.UseVisualStyleBackColor = true;
            // 
            // rdb_t2
            // 
            this.rdb_t2.AutoSize = true;
            this.rdb_t2.Location = new System.Drawing.Point(69, 23);
            this.rdb_t2.Name = "rdb_t2";
            this.rdb_t2.Size = new System.Drawing.Size(55, 17);
            this.rdb_t2.TabIndex = 11;
            this.rdb_t2.Text = "Tipo 2";
            this.rdb_t2.UseVisualStyleBackColor = true;
            // 
            // rdb_t1
            // 
            this.rdb_t1.AutoSize = true;
            this.rdb_t1.Checked = true;
            this.rdb_t1.Location = new System.Drawing.Point(8, 23);
            this.rdb_t1.Name = "rdb_t1";
            this.rdb_t1.Size = new System.Drawing.Size(55, 17);
            this.rdb_t1.TabIndex = 10;
            this.rdb_t1.TabStop = true;
            this.rdb_t1.Text = "Tipo 1";
            this.rdb_t1.UseVisualStyleBackColor = true;
            this.rdb_t1.CheckedChanged += new System.EventHandler(this.rdb_t1_CheckedChanged);
            // 
            // rdb_t8
            // 
            this.rdb_t8.AutoSize = true;
            this.rdb_t8.Location = new System.Drawing.Point(191, 46);
            this.rdb_t8.Name = "rdb_t8";
            this.rdb_t8.Size = new System.Drawing.Size(55, 17);
            this.rdb_t8.TabIndex = 9;
            this.rdb_t8.Text = "Tipo 8";
            this.rdb_t8.UseVisualStyleBackColor = true;
            // 
            // rdb_t7
            // 
            this.rdb_t7.AutoSize = true;
            this.rdb_t7.Location = new System.Drawing.Point(130, 46);
            this.rdb_t7.Name = "rdb_t7";
            this.rdb_t7.Size = new System.Drawing.Size(55, 17);
            this.rdb_t7.TabIndex = 8;
            this.rdb_t7.Text = "Tipo 7";
            this.rdb_t7.UseVisualStyleBackColor = true;
            // 
            // rdb_t6
            // 
            this.rdb_t6.AutoSize = true;
            this.rdb_t6.Location = new System.Drawing.Point(69, 46);
            this.rdb_t6.Name = "rdb_t6";
            this.rdb_t6.Size = new System.Drawing.Size(55, 17);
            this.rdb_t6.TabIndex = 7;
            this.rdb_t6.Text = "Tipo 6";
            this.rdb_t6.UseVisualStyleBackColor = true;
            // 
            // rdb_t5
            // 
            this.rdb_t5.AutoSize = true;
            this.rdb_t5.Location = new System.Drawing.Point(8, 46);
            this.rdb_t5.Name = "rdb_t5";
            this.rdb_t5.Size = new System.Drawing.Size(55, 17);
            this.rdb_t5.TabIndex = 6;
            this.rdb_t5.Text = "Tipo 5";
            this.rdb_t5.UseVisualStyleBackColor = true;
            // 
            // lbldsf
            // 
            this.lbldsf.AutoSize = true;
            this.lbldsf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldsf.Location = new System.Drawing.Point(4, 0);
            this.lbldsf.Name = "lbldsf";
            this.lbldsf.Size = new System.Drawing.Size(113, 20);
            this.lbldsf.TabIndex = 0;
            this.lbldsf.Text = "Tipo di frattale:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_2);
            this.panel3.Controls.Add(this.nUD_2);
            this.panel3.Location = new System.Drawing.Point(4, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 31);
            this.panel3.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1234, 861);
            this.Controls.Add(this.pnl_Dati);
            this.Controls.Add(this.btn_Ridisegna);
            this.Controls.Add(this.btn_Restart);
            this.Controls.Add(this.lbl_Titolo);
            this.Controls.Add(this.pnl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nUD_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_2)).EndInit();
            this.pnl_Scelta.ResumeLayout(false);
            this.pnl_Scelta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_3)).EndInit();
            this.pnl_Dati.ResumeLayout(false);
            this.pnl_FrattSemplice.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label lbl_Titolo;
        private System.Windows.Forms.NumericUpDown nUD_1;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.NumericUpDown nUD_2;
        private System.Windows.Forms.Panel pnl_Scelta;
        private System.Windows.Forms.RadioButton rd4;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.RadioButton rd5;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.Label lbl_4;
        private System.Windows.Forms.NumericUpDown nUD_3;
        private System.Windows.Forms.Button btn_Ridisegna;
        private System.Windows.Forms.Panel pnl_Dati;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_FrattSemplice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdb_t12;
        private System.Windows.Forms.RadioButton rdb_t11;
        private System.Windows.Forms.RadioButton rdb_t10;
        private System.Windows.Forms.RadioButton rdb_t9;
        private System.Windows.Forms.RadioButton rdb_t4;
        private System.Windows.Forms.RadioButton rdb_t3;
        private System.Windows.Forms.RadioButton rdb_t2;
        private System.Windows.Forms.RadioButton rdb_t1;
        private System.Windows.Forms.RadioButton rdb_t8;
        private System.Windows.Forms.RadioButton rdb_t7;
        private System.Windows.Forms.RadioButton rdb_t6;
        private System.Windows.Forms.RadioButton rdb_t5;
        private System.Windows.Forms.Label lbldsf;
    }
}

