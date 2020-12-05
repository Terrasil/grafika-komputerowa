namespace Laboratorium1
{
    partial class Okno
    {
        System.Drawing.Graphics rysowanie;
        System.Drawing.Point p1, p2, o;
        int promien;
        System.Collections.Generic.List<System.Drawing.PointF> krzywa;

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
            this.scena = new System.Windows.Forms.Panel();
            this.rysuj = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.NumericUpDown();
            this.x2 = new System.Windows.Forms.NumericUpDown();
            this.y2 = new System.Windows.Forms.NumericUpDown();
            this.y1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.wypelnienie = new System.Windows.Forms.CheckBox();
            this.kolor = new System.Windows.Forms.ComboBox();
            this.wyczysc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.x1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).BeginInit();
            this.SuspendLayout();
            // 
            // scena
            // 
            this.scena.Dock = System.Windows.Forms.DockStyle.Top;
            this.scena.Location = new System.Drawing.Point(0, 0);
            this.scena.MinimumSize = new System.Drawing.Size(684, 367);
            this.scena.Name = "scena";
            this.scena.Size = new System.Drawing.Size(684, 367);
            this.scena.TabIndex = 0;
            this.scena.Click += new System.EventHandler(this.scena_Click);
            this.scena.DoubleClick += new System.EventHandler(this.scena_DoubleClick);
            this.scena.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.scena_MouseWheel);
            // 
            // rysuj
            // 
            this.rysuj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rysuj.Location = new System.Drawing.Point(12, 373);
            this.rysuj.Name = "rysuj";
            this.rysuj.Size = new System.Drawing.Size(101, 65);
            this.rysuj.TabIndex = 1;
            this.rysuj.Text = "Rysuj";
            this.rysuj.UseVisualStyleBackColor = true;
            this.rysuj.Click += new System.EventHandler(this.rysuj_Click);
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(157, 382);
            this.x1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(81, 20);
            this.x1.TabIndex = 2;
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(157, 408);
            this.x2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(81, 20);
            this.x2.TabIndex = 3;
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(282, 406);
            this.y2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(81, 20);
            this.y2.TabIndex = 0;
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(282, 382);
            this.y1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(81, 20);
            this.y1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "x1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "x2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "y2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "y1";
            // 
            // wypelnienie
            // 
            this.wypelnienie.AutoSize = true;
            this.wypelnienie.Location = new System.Drawing.Point(380, 383);
            this.wypelnienie.Name = "wypelnienie";
            this.wypelnienie.Size = new System.Drawing.Size(65, 17);
            this.wypelnienie.TabIndex = 9;
            this.wypelnienie.Text = "wypełnij";
            this.wypelnienie.UseVisualStyleBackColor = true;
            // 
            // kolor
            // 
            this.kolor.FormattingEnabled = true;
            this.kolor.Items.AddRange(new object[] {
            "Czarny",
            "Czerwony",
            "Niebieski"});
            this.kolor.Location = new System.Drawing.Point(380, 406);
            this.kolor.Name = "kolor";
            this.kolor.Size = new System.Drawing.Size(74, 21);
            this.kolor.TabIndex = 10;
            this.kolor.Text = "Czarny";
            // 
            // wyczysc
            // 
            this.wyczysc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wyczysc.Location = new System.Drawing.Point(571, 373);
            this.wyczysc.Name = "wyczysc";
            this.wyczysc.Size = new System.Drawing.Size(101, 65);
            this.wyczysc.TabIndex = 11;
            this.wyczysc.Text = "Wyczyść";
            this.wyczysc.UseVisualStyleBackColor = true;
            this.wyczysc.Click += new System.EventHandler(this.wyczysc_Click);
            // 
            // Okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.wyczysc);
            this.Controls.Add(this.kolor);
            this.Controls.Add(this.wypelnienie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.rysuj);
            this.Controls.Add(this.scena);
            this.Name = "Okno";
            this.Text = "Podstawowe operacje graficzne - Patryk Morawski";
            this.Load += new System.EventHandler(this.Okno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.x1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel scena;
        private System.Windows.Forms.Button rysuj;
        private System.Windows.Forms.NumericUpDown x1;
        private System.Windows.Forms.NumericUpDown x2;
        private System.Windows.Forms.NumericUpDown y2;
        private System.Windows.Forms.NumericUpDown y1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox wypelnienie;
        private System.Windows.Forms.ComboBox kolor;
        private System.Windows.Forms.Button wyczysc;
    }
}

