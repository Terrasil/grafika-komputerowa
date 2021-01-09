namespace Labroatorium_6
{
    partial class okno
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.a = new System.Windows.Forms.NumericUpDown();
            this.b = new System.Windows.Forms.NumericUpDown();
            this.c = new System.Windows.Forms.NumericUpDown();
            this.d = new System.Windows.Forms.NumericUpDown();
            this.operator2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.operator3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.operator4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.probki = new System.Windows.Forms.NumericUpDown();
            this.paint = new System.Windows.Forms.Button();
            this.obraz = new System.Windows.Forms.PictureBox();
            this.operator1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obraz)).BeginInit();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.DecimalPlaces = 3;
            this.a.Location = new System.Drawing.Point(87, 446);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 20);
            this.a.TabIndex = 0;
            // 
            // b
            // 
            this.b.DecimalPlaces = 3;
            this.b.Location = new System.Drawing.Point(253, 446);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 20);
            this.b.TabIndex = 1;
            // 
            // c
            // 
            this.c.DecimalPlaces = 3;
            this.c.Location = new System.Drawing.Point(420, 446);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(100, 20);
            this.c.TabIndex = 2;
            // 
            // d
            // 
            this.d.DecimalPlaces = 3;
            this.d.Location = new System.Drawing.Point(576, 446);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(100, 20);
            this.d.TabIndex = 3;
            // 
            // operator2
            // 
            this.operator2.FormattingEnabled = true;
            this.operator2.Items.AddRange(new object[] {
            "+",
            "-"});
            this.operator2.Location = new System.Drawing.Point(211, 446);
            this.operator2.Name = "operator2";
            this.operator2.Size = new System.Drawing.Size(36, 21);
            this.operator2.TabIndex = 4;
            this.operator2.Text = "+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(190, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "x";
            // 
            // operator3
            // 
            this.operator3.FormattingEnabled = true;
            this.operator3.Items.AddRange(new object[] {
            "+",
            "-"});
            this.operator3.Location = new System.Drawing.Point(378, 446);
            this.operator3.Name = "operator3";
            this.operator3.Size = new System.Drawing.Size(36, 21);
            this.operator3.TabIndex = 6;
            this.operator3.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "x";
            // 
            // operator4
            // 
            this.operator4.FormattingEnabled = true;
            this.operator4.Items.AddRange(new object[] {
            "+",
            "-"});
            this.operator4.Location = new System.Drawing.Point(534, 446);
            this.operator4.Name = "operator4";
            this.operator4.Size = new System.Drawing.Size(36, 21);
            this.operator4.TabIndex = 8;
            this.operator4.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(194, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(361, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "f(x) = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(488, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ilość próbkowań:";
            // 
            // probki
            // 
            this.probki.Location = new System.Drawing.Point(576, 419);
            this.probki.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.probki.Name = "probki";
            this.probki.Size = new System.Drawing.Size(100, 20);
            this.probki.TabIndex = 14;
            this.probki.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // paint
            // 
            this.paint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.paint.Location = new System.Drawing.Point(682, 412);
            this.paint.Name = "paint";
            this.paint.Size = new System.Drawing.Size(110, 63);
            this.paint.TabIndex = 15;
            this.paint.Text = "Rysuj";
            this.paint.UseVisualStyleBackColor = true;
            this.paint.Click += new System.EventHandler(this.paint_Click);
            // 
            // obraz
            // 
            this.obraz.Location = new System.Drawing.Point(13, 13);
            this.obraz.Name = "obraz";
            this.obraz.Size = new System.Drawing.Size(779, 393);
            this.obraz.TabIndex = 16;
            this.obraz.TabStop = false;
            this.obraz.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.obraz_MouseWheel);
            // 
            // operator1
            // 
            this.operator1.FormattingEnabled = true;
            this.operator1.Items.AddRange(new object[] {
            "+",
            "-"});
            this.operator1.Location = new System.Drawing.Point(45, 446);
            this.operator1.Name = "operator1";
            this.operator1.Size = new System.Drawing.Size(36, 21);
            this.operator1.TabIndex = 17;
            this.operator1.Text = "+";
            // 
            // okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 481);
            this.Controls.Add(this.operator1);
            this.Controls.Add(this.obraz);
            this.Controls.Add(this.paint);
            this.Controls.Add(this.probki);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.operator4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.operator3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.operator2);
            this.Controls.Add(this.d);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.MaximumSize = new System.Drawing.Size(820, 520);
            this.MinimumSize = new System.Drawing.Size(820, 520);
            this.Name = "okno";
            this.Text = "Patryk Morawski - Laboratorium 6";
            this.Load += new System.EventHandler(this.okno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obraz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown a;
        private System.Windows.Forms.NumericUpDown b;
        private System.Windows.Forms.NumericUpDown c;
        private System.Windows.Forms.NumericUpDown d;
        private System.Windows.Forms.ComboBox operator2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox operator3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox operator4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown probki;
        private System.Windows.Forms.Button paint;
        private System.Windows.Forms.PictureBox obraz;
        private System.Windows.Forms.ComboBox operator1;
    }
}

