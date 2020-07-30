namespace GUI
{
    partial class Form1
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
            this.kolMechanik = new System.Windows.Forms.ListBox();
            this.kolMechanikP = new System.Windows.Forms.ListBox();
            this.kolDiagnostyka = new System.Windows.Forms.ListBox();
            this.kolBlach = new System.Windows.Forms.ListBox();
            this.mech1 = new System.Windows.Forms.ListBox();
            this.mech2 = new System.Windows.Forms.ListBox();
            this.diagnostyka = new System.Windows.Forms.ListBox();
            this.blacharstwo = new System.Windows.Forms.ListBox();
            this.mechanik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kolMechanik
            // 
            this.kolMechanik.FormattingEnabled = true;
            this.kolMechanik.Location = new System.Drawing.Point(55, 152);
            this.kolMechanik.Name = "kolMechanik";
            this.kolMechanik.Size = new System.Drawing.Size(128, 251);
            this.kolMechanik.TabIndex = 0;
            // 
            // kolMechanikP
            // 
            this.kolMechanikP.FormattingEnabled = true;
            this.kolMechanikP.Location = new System.Drawing.Point(237, 152);
            this.kolMechanikP.Name = "kolMechanikP";
            this.kolMechanikP.Size = new System.Drawing.Size(128, 251);
            this.kolMechanikP.TabIndex = 1;
            // 
            // kolDiagnostyka
            // 
            this.kolDiagnostyka.FormattingEnabled = true;
            this.kolDiagnostyka.Location = new System.Drawing.Point(425, 152);
            this.kolDiagnostyka.Name = "kolDiagnostyka";
            this.kolDiagnostyka.Size = new System.Drawing.Size(128, 251);
            this.kolDiagnostyka.TabIndex = 2;
            // 
            // kolBlach
            // 
            this.kolBlach.FormattingEnabled = true;
            this.kolBlach.Location = new System.Drawing.Point(615, 152);
            this.kolBlach.Name = "kolBlach";
            this.kolBlach.Size = new System.Drawing.Size(128, 251);
            this.kolBlach.TabIndex = 3;
            // 
            // mech1
            // 
            this.mech1.FormattingEnabled = true;
            this.mech1.Location = new System.Drawing.Point(55, 53);
            this.mech1.Name = "mech1";
            this.mech1.Size = new System.Drawing.Size(128, 43);
            this.mech1.TabIndex = 4;
            // 
            // mech2
            // 
            this.mech2.FormattingEnabled = true;
            this.mech2.Location = new System.Drawing.Point(237, 53);
            this.mech2.Name = "mech2";
            this.mech2.Size = new System.Drawing.Size(128, 43);
            this.mech2.TabIndex = 5;
            // 
            // diagnostyka
            // 
            this.diagnostyka.FormattingEnabled = true;
            this.diagnostyka.Location = new System.Drawing.Point(425, 53);
            this.diagnostyka.Name = "diagnostyka";
            this.diagnostyka.Size = new System.Drawing.Size(128, 43);
            this.diagnostyka.TabIndex = 6;
            // 
            // blacharstwo
            // 
            this.blacharstwo.FormattingEnabled = true;
            this.blacharstwo.Location = new System.Drawing.Point(615, 53);
            this.blacharstwo.Name = "blacharstwo";
            this.blacharstwo.Size = new System.Drawing.Size(128, 43);
            this.blacharstwo.TabIndex = 7;
            // 
            // mechanik
            // 
            this.mechanik.AutoSize = true;
            this.mechanik.Location = new System.Drawing.Point(55, 22);
            this.mechanik.Name = "mechanik";
            this.mechanik.Size = new System.Drawing.Size(63, 13);
            this.mechanik.TabIndex = 8;
            this.mechanik.Text = "MECHANIK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "MECHANIK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "DIAGNOSTYKA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "BLACHARSTWO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "KolejkaMechanik";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "KolejkaUprzywilejowanaMechanik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "KolejkaDiagnostyka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(612, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "KolejkaBlacharstwo";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(357, 415);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 16;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mechanik);
            this.Controls.Add(this.blacharstwo);
            this.Controls.Add(this.diagnostyka);
            this.Controls.Add(this.mech2);
            this.Controls.Add(this.mech1);
            this.Controls.Add(this.kolBlach);
            this.Controls.Add(this.kolDiagnostyka);
            this.Controls.Add(this.kolMechanikP);
            this.Controls.Add(this.kolMechanik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox kolMechanik;
        public System.Windows.Forms.ListBox kolMechanikP;
        public System.Windows.Forms.ListBox kolDiagnostyka;
        public System.Windows.Forms.ListBox kolBlach;
        private System.Windows.Forms.ListBox mech1;
        private System.Windows.Forms.ListBox mech2;
        private System.Windows.Forms.ListBox diagnostyka;
        private System.Windows.Forms.ListBox blacharstwo;
        private System.Windows.Forms.Label mechanik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button startButton;
    }
}

