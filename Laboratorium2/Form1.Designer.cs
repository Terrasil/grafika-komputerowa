namespace Laboratorium2
{
    partial class Form1
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
            this.podglad = new System.Windows.Forms.PictureBox();
            this.zaladujPlik = new System.Windows.Forms.OpenFileDialog();
            this.wybierz = new System.Windows.Forms.Button();
            this.wynik = new System.Windows.Forms.PictureBox();
            this.rgb = new System.Windows.Forms.Button();
            this.cmy = new System.Windows.Forms.Button();
            this.szary1 = new System.Windows.Forms.Button();
            this.szary2 = new System.Windows.Forms.Button();
            this.niebieski = new System.Windows.Forms.NumericUpDown();
            this.zielony = new System.Windows.Forms.NumericUpDown();
            this.czerwony = new System.Windows.Forms.NumericUpDown();
            this.podpis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.podglad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.niebieski)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zielony)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.czerwony)).BeginInit();
            this.SuspendLayout();
            // 
            // podglad
            // 
            this.podglad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.podglad.Location = new System.Drawing.Point(12, 45);
            this.podglad.Name = "podglad";
            this.podglad.Size = new System.Drawing.Size(400, 400);
            this.podglad.TabIndex = 0;
            this.podglad.TabStop = false;
            // 
            // zaladujPlik
            // 
            this.zaladujPlik.FileName = "zaldowanyPlik";
            this.zaladujPlik.FileOk += new System.ComponentModel.CancelEventHandler(this.zaladujPlik_FileOk);
            // 
            // wybierz
            // 
            this.wybierz.Location = new System.Drawing.Point(13, 13);
            this.wybierz.Name = "wybierz";
            this.wybierz.Size = new System.Drawing.Size(75, 23);
            this.wybierz.TabIndex = 1;
            this.wybierz.Text = "Wybierz";
            this.wybierz.UseVisualStyleBackColor = true;
            this.wybierz.Click += new System.EventHandler(this.wybierz_Click);
            // 
            // wynik
            // 
            this.wynik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wynik.Location = new System.Drawing.Point(418, 45);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(400, 400);
            this.wynik.TabIndex = 2;
            this.wynik.TabStop = false;
            // 
            // rgb
            // 
            this.rgb.Location = new System.Drawing.Point(94, 13);
            this.rgb.Name = "rgb";
            this.rgb.Size = new System.Drawing.Size(75, 23);
            this.rgb.TabIndex = 3;
            this.rgb.Text = "RGB";
            this.rgb.UseVisualStyleBackColor = true;
            this.rgb.Click += new System.EventHandler(this.rgb_Click);
            // 
            // cmy
            // 
            this.cmy.Location = new System.Drawing.Point(175, 13);
            this.cmy.Name = "cmy";
            this.cmy.Size = new System.Drawing.Size(75, 23);
            this.cmy.TabIndex = 4;
            this.cmy.Text = "CMY";
            this.cmy.UseVisualStyleBackColor = true;
            this.cmy.Click += new System.EventHandler(this.cmy_Click);
            // 
            // szary1
            // 
            this.szary1.Location = new System.Drawing.Point(256, 13);
            this.szary1.Name = "szary1";
            this.szary1.Size = new System.Drawing.Size(75, 23);
            this.szary1.TabIndex = 5;
            this.szary1.Text = "SZARY 1";
            this.szary1.UseVisualStyleBackColor = true;
            this.szary1.Click += new System.EventHandler(this.szary1_Click);
            // 
            // szary2
            // 
            this.szary2.Location = new System.Drawing.Point(337, 12);
            this.szary2.Name = "szary2";
            this.szary2.Size = new System.Drawing.Size(75, 23);
            this.szary2.TabIndex = 6;
            this.szary2.Text = "SZARY 2";
            this.szary2.UseVisualStyleBackColor = true;
            this.szary2.Click += new System.EventHandler(this.szary2_Click);
            // 
            // niebieski
            // 
            this.niebieski.Location = new System.Drawing.Point(693, 19);
            this.niebieski.Name = "niebieski";
            this.niebieski.Size = new System.Drawing.Size(120, 20);
            this.niebieski.TabIndex = 7;
            this.niebieski.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // zielony
            // 
            this.zielony.Location = new System.Drawing.Point(567, 19);
            this.zielony.Name = "zielony";
            this.zielony.Size = new System.Drawing.Size(120, 20);
            this.zielony.TabIndex = 8;
            this.zielony.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // czerwony
            // 
            this.czerwony.Location = new System.Drawing.Point(441, 19);
            this.czerwony.Name = "czerwony";
            this.czerwony.Size = new System.Drawing.Size(120, 20);
            this.czerwony.TabIndex = 9;
            this.czerwony.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // podpis
            // 
            this.podpis.AutoSize = true;
            this.podpis.Location = new System.Drawing.Point(496, 3);
            this.podpis.Name = "podpis";
            this.podpis.Size = new System.Drawing.Size(261, 13);
            this.podpis.TabIndex = 10;
            this.podpis.Text = "R                                      G                                       B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.podpis);
            this.Controls.Add(this.czerwony);
            this.Controls.Add(this.zielony);
            this.Controls.Add(this.niebieski);
            this.Controls.Add(this.szary2);
            this.Controls.Add(this.szary1);
            this.Controls.Add(this.cmy);
            this.Controls.Add(this.rgb);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.wybierz);
            this.Controls.Add(this.podglad);
            this.Name = "Form1";
            this.Text = "Podstawowe operacje graficzne - Patryk Morawski";
            ((System.ComponentModel.ISupportInitialize)(this.podglad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.niebieski)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zielony)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.czerwony)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox podglad;
        private System.Windows.Forms.OpenFileDialog zaladujPlik;
        private System.Windows.Forms.Button wybierz;
        private System.Windows.Forms.PictureBox wynik;
        private System.Windows.Forms.Button rgb;
        private System.Windows.Forms.Button cmy;
        private System.Windows.Forms.Button szary1;
        private System.Windows.Forms.Button szary2;
        private System.Windows.Forms.NumericUpDown niebieski;
        private System.Windows.Forms.NumericUpDown zielony;
        private System.Windows.Forms.NumericUpDown czerwony;
        private System.Windows.Forms.Label podpis;
    }
}

