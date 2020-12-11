namespace Laboratorium5
{
    partial class window
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
            this.components = new System.ComponentModel.Container();
            this.screen = new System.Windows.Forms.PictureBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.speedTrack = new System.Windows.Forms.HScrollBar();
            this.distanceTrack = new System.Windows.Forms.HScrollBar();
            this.test = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).BeginInit();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(804, 550);
            this.screen.TabIndex = 0;
            this.screen.TabStop = false;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(17, 583);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(52, 13);
            this.speedLabel.TabIndex = 3;
            this.speedLabel.Text = "Prędkość";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(17, 635);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(56, 13);
            this.distanceLabel.TabIndex = 4;
            this.distanceLabel.Text = "Odległość";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // speedTrack
            // 
            this.speedTrack.Location = new System.Drawing.Point(77, 582);
            this.speedTrack.Maximum = 1000;
            this.speedTrack.Name = "speedTrack";
            this.speedTrack.Size = new System.Drawing.Size(718, 17);
            this.speedTrack.TabIndex = 5;
            this.speedTrack.Value = 500;
            this.speedTrack.Scroll += new System.Windows.Forms.ScrollEventHandler(this.speedTrack_Scroll);
            // 
            // distanceTrack
            // 
            this.distanceTrack.Location = new System.Drawing.Point(77, 635);
            this.distanceTrack.Maximum = 1000;
            this.distanceTrack.Name = "distanceTrack";
            this.distanceTrack.Size = new System.Drawing.Size(718, 17);
            this.distanceTrack.TabIndex = 6;
            this.distanceTrack.Value = 500;
            this.distanceTrack.Scroll += new System.Windows.Forms.ScrollEventHandler(this.distanceTrack_Scroll);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(433, 554);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(13, 13);
            this.test.TabIndex = 7;
            this.test.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 567);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(9, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 567);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(9, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 554);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "-5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(765, 567);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(9, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "|";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(763, 554);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(765, 622);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(9, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "|";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 622);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(9, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "|";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(435, 622);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(9, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "|";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(763, 609);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(96, 609);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "-5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(433, 609);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "0";
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(804, 661);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.test);
            this.Controls.Add(this.distanceTrack);
            this.Controls.Add(this.speedTrack);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.screen);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 700);
            this.MinimumSize = new System.Drawing.Size(820, 700);
            this.Name = "window";
            this.Text = "Laboratorium 5 - Patryk Morawski";
            this.Load += new System.EventHandler(this.window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.screen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox screen;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.HScrollBar speedTrack;
        private System.Windows.Forms.HScrollBar distanceTrack;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}

