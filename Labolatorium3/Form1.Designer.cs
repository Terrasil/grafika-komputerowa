namespace Labolatorium3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_yk = new System.Windows.Forms.Label();
            this.label_xk = new System.Windows.Forms.Label();
            this.label_yp = new System.Windows.Forms.Label();
            this.label_xp = new System.Windows.Forms.Label();
            this.yk = new System.Windows.Forms.NumericUpDown();
            this.xk = new System.Windows.Forms.NumericUpDown();
            this.yp = new System.Windows.Forms.NumericUpDown();
            this.xp = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_r = new System.Windows.Forms.Label();
            this.label_yo = new System.Windows.Forms.Label();
            this.xo = new System.Windows.Forms.NumericUpDown();
            this.label_xo = new System.Windows.Forms.Label();
            this.r = new System.Windows.Forms.NumericUpDown();
            this.yo = new System.Windows.Forms.NumericUpDown();
            this.przyrostowy = new System.Windows.Forms.Button();
            this.bresenhmana = new System.Windows.Forms.Button();
            this.okrag = new System.Windows.Forms.RadioButton();
            this.odcinek = new System.Windows.Forms.RadioButton();
            this.paint = new System.Windows.Forms.PictureBox();
            this.standardowe = new System.Windows.Forms.Button();
            this.czas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xp)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paint)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_yk);
            this.panel1.Controls.Add(this.label_xk);
            this.panel1.Controls.Add(this.label_yp);
            this.panel1.Controls.Add(this.label_xp);
            this.panel1.Controls.Add(this.yk);
            this.panel1.Controls.Add(this.xk);
            this.panel1.Controls.Add(this.yp);
            this.panel1.Controls.Add(this.xp);
            this.panel1.Location = new System.Drawing.Point(12, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 52);
            this.panel1.TabIndex = 0;
            // 
            // label_yk
            // 
            this.label_yk.AutoSize = true;
            this.label_yk.Location = new System.Drawing.Point(182, 29);
            this.label_yk.Name = "label_yk";
            this.label_yk.Size = new System.Drawing.Size(24, 13);
            this.label_yk.TabIndex = 6;
            this.label_yk.Text = "yk=";
            // 
            // label_xk
            // 
            this.label_xk.AutoSize = true;
            this.label_xk.Location = new System.Drawing.Point(182, 5);
            this.label_xk.Name = "label_xk";
            this.label_xk.Size = new System.Drawing.Size(24, 13);
            this.label_xk.TabIndex = 5;
            this.label_xk.Text = "xk=";
            // 
            // label_yp
            // 
            this.label_yp.AutoSize = true;
            this.label_yp.Location = new System.Drawing.Point(7, 29);
            this.label_yp.Name = "label_yp";
            this.label_yp.Size = new System.Drawing.Size(24, 13);
            this.label_yp.TabIndex = 4;
            this.label_yp.Text = "yp=";
            // 
            // label_xp
            // 
            this.label_xp.AutoSize = true;
            this.label_xp.Location = new System.Drawing.Point(7, 5);
            this.label_xp.Name = "label_xp";
            this.label_xp.Size = new System.Drawing.Size(24, 13);
            this.label_xp.TabIndex = 2;
            this.label_xp.Text = "xp=";
            // 
            // yk
            // 
            this.yk.Location = new System.Drawing.Point(212, 29);
            this.yk.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.yk.Name = "yk";
            this.yk.Size = new System.Drawing.Size(120, 20);
            this.yk.TabIndex = 3;
            // 
            // xk
            // 
            this.xk.Location = new System.Drawing.Point(212, 3);
            this.xk.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.xk.Name = "xk";
            this.xk.Size = new System.Drawing.Size(120, 20);
            this.xk.TabIndex = 2;
            // 
            // yp
            // 
            this.yp.Location = new System.Drawing.Point(37, 29);
            this.yp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.yp.Name = "yp";
            this.yp.Size = new System.Drawing.Size(120, 20);
            this.yp.TabIndex = 1;
            // 
            // xp
            // 
            this.xp.Location = new System.Drawing.Point(37, 3);
            this.xp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.xp.Name = "xp";
            this.xp.Size = new System.Drawing.Size(120, 20);
            this.xp.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_r);
            this.panel2.Controls.Add(this.label_yo);
            this.panel2.Controls.Add(this.xo);
            this.panel2.Controls.Add(this.label_xo);
            this.panel2.Controls.Add(this.r);
            this.panel2.Controls.Add(this.yo);
            this.panel2.Location = new System.Drawing.Point(12, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 52);
            this.panel2.TabIndex = 1;
            // 
            // label_r
            // 
            this.label_r.AutoSize = true;
            this.label_r.Location = new System.Drawing.Point(182, 6);
            this.label_r.Name = "label_r";
            this.label_r.Size = new System.Drawing.Size(21, 13);
            this.label_r.TabIndex = 9;
            this.label_r.Text = "R=";
            // 
            // label_yo
            // 
            this.label_yo.AutoSize = true;
            this.label_yo.Location = new System.Drawing.Point(7, 29);
            this.label_yo.Name = "label_yo";
            this.label_yo.Size = new System.Drawing.Size(24, 13);
            this.label_yo.TabIndex = 8;
            this.label_yo.Text = "yo=";
            // 
            // xo
            // 
            this.xo.Location = new System.Drawing.Point(37, 3);
            this.xo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.xo.Name = "xo";
            this.xo.Size = new System.Drawing.Size(120, 20);
            this.xo.TabIndex = 4;
            // 
            // label_xo
            // 
            this.label_xo.AutoSize = true;
            this.label_xo.Location = new System.Drawing.Point(7, 5);
            this.label_xo.Name = "label_xo";
            this.label_xo.Size = new System.Drawing.Size(24, 13);
            this.label_xo.TabIndex = 7;
            this.label_xo.Text = "xo=";
            // 
            // r
            // 
            this.r.Location = new System.Drawing.Point(212, 3);
            this.r.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(120, 20);
            this.r.TabIndex = 6;
            // 
            // yo
            // 
            this.yo.Location = new System.Drawing.Point(37, 29);
            this.yo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.yo.Name = "yo";
            this.yo.Size = new System.Drawing.Size(120, 20);
            this.yo.TabIndex = 5;
            // 
            // przyrostowy
            // 
            this.przyrostowy.Location = new System.Drawing.Point(383, 415);
            this.przyrostowy.Name = "przyrostowy";
            this.przyrostowy.Size = new System.Drawing.Size(75, 23);
            this.przyrostowy.TabIndex = 2;
            this.przyrostowy.Text = "Rys. Przyr.";
            this.przyrostowy.UseVisualStyleBackColor = true;
            this.przyrostowy.Click += new System.EventHandler(this.przyrostowy_Click);
            // 
            // bresenhmana
            // 
            this.bresenhmana.Location = new System.Drawing.Point(464, 415);
            this.bresenhmana.Name = "bresenhmana";
            this.bresenhmana.Size = new System.Drawing.Size(75, 23);
            this.bresenhmana.TabIndex = 3;
            this.bresenhmana.Text = "Rys. Bres.";
            this.bresenhmana.UseVisualStyleBackColor = true;
            this.bresenhmana.Click += new System.EventHandler(this.bresenhmana_Click);
            // 
            // okrag
            // 
            this.okrag.AutoSize = true;
            this.okrag.Location = new System.Drawing.Point(654, 412);
            this.okrag.Name = "okrag";
            this.okrag.Size = new System.Drawing.Size(52, 17);
            this.okrag.TabIndex = 4;
            this.okrag.Text = "okrąg";
            this.okrag.UseVisualStyleBackColor = true;
            this.okrag.CheckedChanged += new System.EventHandler(this.okrag_CheckedChanged);
            // 
            // odcinek
            // 
            this.odcinek.AutoSize = true;
            this.odcinek.Checked = true;
            this.odcinek.Location = new System.Drawing.Point(654, 389);
            this.odcinek.Name = "odcinek";
            this.odcinek.Size = new System.Drawing.Size(63, 17);
            this.odcinek.TabIndex = 5;
            this.odcinek.TabStop = true;
            this.odcinek.Text = "odcinek";
            this.odcinek.UseVisualStyleBackColor = true;
            this.odcinek.CheckedChanged += new System.EventHandler(this.odcinek_CheckedChanged);
            // 
            // paint
            // 
            this.paint.Location = new System.Drawing.Point(-2, 0);
            this.paint.Name = "paint";
            this.paint.Size = new System.Drawing.Size(804, 383);
            this.paint.TabIndex = 6;
            this.paint.TabStop = false;
            // 
            // standardowe
            // 
            this.standardowe.Location = new System.Drawing.Point(545, 415);
            this.standardowe.Name = "standardowe";
            this.standardowe.Size = new System.Drawing.Size(75, 23);
            this.standardowe.TabIndex = 7;
            this.standardowe.Text = "Rys. Stan.";
            this.standardowe.UseVisualStyleBackColor = true;
            this.standardowe.Click += new System.EventHandler(this.standardowe_Click);
            // 
            // czas
            // 
            this.czas.AutoSize = true;
            this.czas.Location = new System.Drawing.Point(383, 391);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(39, 13);
            this.czas.TabIndex = 8;
            this.czas.Text = "Czas: -";
            // 
            // okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.czas);
            this.Controls.Add(this.standardowe);
            this.Controls.Add(this.odcinek);
            this.Controls.Add(this.okrag);
            this.Controls.Add(this.bresenhmana);
            this.Controls.Add(this.przyrostowy);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paint);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "okno";
            this.Text = "Patryk Morawski - Laboratorium 3";
            this.Load += new System.EventHandler(this.okno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_yk;
        private System.Windows.Forms.Label label_xk;
        private System.Windows.Forms.Label label_yp;
        private System.Windows.Forms.Label label_xp;
        private System.Windows.Forms.NumericUpDown yk;
        private System.Windows.Forms.NumericUpDown xk;
        private System.Windows.Forms.NumericUpDown yp;
        private System.Windows.Forms.NumericUpDown xp;
        private System.Windows.Forms.Label label_r;
        private System.Windows.Forms.Label label_yo;
        private System.Windows.Forms.NumericUpDown xo;
        private System.Windows.Forms.Label label_xo;
        private System.Windows.Forms.NumericUpDown r;
        private System.Windows.Forms.NumericUpDown yo;
        private System.Windows.Forms.Button przyrostowy;
        private System.Windows.Forms.Button bresenhmana;
        private System.Windows.Forms.RadioButton okrag;
        private System.Windows.Forms.RadioButton odcinek;
        private System.Windows.Forms.PictureBox paint;
        private System.Windows.Forms.Button standardowe;
        private System.Windows.Forms.Label czas;
    }
}

