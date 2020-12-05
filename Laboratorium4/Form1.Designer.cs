namespace Laboratorium4
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.labely = new System.Windows.Forms.Label();
            this.labelx = new System.Windows.Forms.Label();
            this.posy = new System.Windows.Forms.NumericUpDown();
            this.posx = new System.Windows.Forms.NumericUpDown();
            this.fill8 = new System.Windows.Forms.Button();
            this.fillOdd = new System.Windows.Forms.Button();
            this.fill4 = new System.Windows.Forms.Button();
            this.symbol = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.drawSymbol = new System.Windows.Forms.Button();
            this.drawFigure = new System.Windows.Forms.Button();
            this.uwaga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posx)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(804, 380);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.labely);
            this.controlPanel.Controls.Add(this.labelx);
            this.controlPanel.Controls.Add(this.posy);
            this.controlPanel.Controls.Add(this.posx);
            this.controlPanel.Controls.Add(this.fill8);
            this.controlPanel.Controls.Add(this.fillOdd);
            this.controlPanel.Controls.Add(this.fill4);
            this.controlPanel.Controls.Add(this.symbol);
            this.controlPanel.Controls.Add(this.clear);
            this.controlPanel.Controls.Add(this.drawSymbol);
            this.controlPanel.Controls.Add(this.drawFigure);
            this.controlPanel.Controls.Add(this.uwaga);
            this.controlPanel.Location = new System.Drawing.Point(0, 378);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(804, 84);
            this.controlPanel.TabIndex = 1;
            // 
            // labely
            // 
            this.labely.AutoSize = true;
            this.labely.Location = new System.Drawing.Point(557, 44);
            this.labely.Name = "labely";
            this.labely.Size = new System.Drawing.Size(14, 13);
            this.labely.TabIndex = 11;
            this.labely.Text = "Y";
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Location = new System.Drawing.Point(401, 44);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(14, 13);
            this.labelx.TabIndex = 10;
            this.labelx.Text = "X";
            // 
            // posy
            // 
            this.posy.Location = new System.Drawing.Point(577, 41);
            this.posy.Maximum = new decimal(new int[] {
            370,
            0,
            0,
            0});
            this.posy.Name = "posy";
            this.posy.Size = new System.Drawing.Size(120, 20);
            this.posy.TabIndex = 9;
            this.posy.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // posx
            // 
            this.posx.Location = new System.Drawing.Point(421, 41);
            this.posx.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.posx.Name = "posx";
            this.posx.Size = new System.Drawing.Size(120, 20);
            this.posx.TabIndex = 8;
            this.posx.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // fill8
            // 
            this.fill8.Location = new System.Drawing.Point(301, 38);
            this.fill8.Name = "fill8";
            this.fill8.Size = new System.Drawing.Size(90, 23);
            this.fill8.TabIndex = 7;
            this.fill8.Text = "Ośmiospójnie";
            this.fill8.UseVisualStyleBackColor = true;
            this.fill8.Click += new System.EventHandler(this.fill8_Click);
            // 
            // fillOdd
            // 
            this.fillOdd.Location = new System.Drawing.Point(109, 9);
            this.fillOdd.Name = "fillOdd";
            this.fillOdd.Size = new System.Drawing.Size(282, 23);
            this.fillOdd.TabIndex = 6;
            this.fillOdd.Text = "Kontrola parzystości";
            this.fillOdd.UseVisualStyleBackColor = true;
            this.fillOdd.Click += new System.EventHandler(this.fillOdd_Click);
            // 
            // fill4
            // 
            this.fill4.Location = new System.Drawing.Point(205, 38);
            this.fill4.Name = "fill4";
            this.fill4.Size = new System.Drawing.Size(90, 23);
            this.fill4.TabIndex = 4;
            this.fill4.Text = "Czterospójnie";
            this.fill4.UseVisualStyleBackColor = true;
            this.fill4.Click += new System.EventHandler(this.fill4_Click);
            // 
            // symbol
            // 
            this.symbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.26F);
            this.symbol.Location = new System.Drawing.Point(110, 39);
            this.symbol.MaxLength = 1;
            this.symbol.Name = "symbol";
            this.symbol.Size = new System.Drawing.Size(90, 20);
            this.symbol.TabIndex = 3;
            this.symbol.Text = "A";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(717, 9);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 52);
            this.clear.TabIndex = 2;
            this.clear.Text = "WYCZYŚĆ";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // drawSymbol
            // 
            this.drawSymbol.Location = new System.Drawing.Point(14, 38);
            this.drawSymbol.Name = "drawSymbol";
            this.drawSymbol.Size = new System.Drawing.Size(89, 23);
            this.drawSymbol.TabIndex = 1;
            this.drawSymbol.Text = "Rysuj Symbol";
            this.drawSymbol.UseVisualStyleBackColor = true;
            this.drawSymbol.Click += new System.EventHandler(this.drawSymbol_Click);
            // 
            // drawFigure
            // 
            this.drawFigure.Location = new System.Drawing.Point(14, 9);
            this.drawFigure.Name = "drawFigure";
            this.drawFigure.Size = new System.Drawing.Size(89, 23);
            this.drawFigure.TabIndex = 0;
            this.drawFigure.Text = "Rysuj Figure";
            this.drawFigure.UseVisualStyleBackColor = true;
            this.drawFigure.Click += new System.EventHandler(this.drawFigure_Click);
            // 
            // uwaga
            // 
            this.uwaga.AutoSize = true;
            this.uwaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uwaga.Location = new System.Drawing.Point(413, 9);
            this.uwaga.Name = "uwaga";
            this.uwaga.Size = new System.Drawing.Size(284, 12);
            this.uwaga.TabIndex = 12;
            this.uwaga.Text = "Nie udało się w 100% pozbyc problemu lokalnych ekstremum brzegu";
            // 
            // okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 447);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.picture);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 486);
            this.MinimumSize = new System.Drawing.Size(820, 486);
            this.Name = "okno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Laboratorium 4 - Patryk Morawski";
            this.Load += new System.EventHandler(this.okno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button fill8;
        private System.Windows.Forms.Button fillOdd;
        private System.Windows.Forms.Button fill4;
        private System.Windows.Forms.TextBox symbol;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button drawSymbol;
        private System.Windows.Forms.Button drawFigure;
        private System.Windows.Forms.Label labely;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.NumericUpDown posy;
        private System.Windows.Forms.NumericUpDown posx;
        private System.Windows.Forms.Label uwaga;
    }
}

