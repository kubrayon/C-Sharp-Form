namespace GP1
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
            this.btnDoldur = new System.Windows.Forms.Button();
            this.btnToplam = new System.Windows.Forms.Button();
            this.lbListele = new System.Windows.Forms.ListBox();
            this.lblToplam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDoldur
            // 
            this.btnDoldur.Location = new System.Drawing.Point(38, 30);
            this.btnDoldur.Name = "btnDoldur";
            this.btnDoldur.Size = new System.Drawing.Size(75, 23);
            this.btnDoldur.TabIndex = 0;
            this.btnDoldur.Text = "Sayı üret";
            this.btnDoldur.UseVisualStyleBackColor = true;
            this.btnDoldur.Click += new System.EventHandler(this.btnDoldur_Click);
            // 
            // btnToplam
            // 
            this.btnToplam.Location = new System.Drawing.Point(304, 29);
            this.btnToplam.Name = "btnToplam";
            this.btnToplam.Size = new System.Drawing.Size(75, 23);
            this.btnToplam.TabIndex = 1;
            this.btnToplam.Text = "button2";
            this.btnToplam.UseVisualStyleBackColor = true;
            this.btnToplam.Click += new System.EventHandler(this.btnToplam_Click);
            // 
            // lbListele
            // 
            this.lbListele.FormattingEnabled = true;
            this.lbListele.Location = new System.Drawing.Point(149, 12);
            this.lbListele.Name = "lbListele";
            this.lbListele.Size = new System.Drawing.Size(120, 225);
            this.lbListele.TabIndex = 2;
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(408, 12);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(35, 13);
            this.lblToplam.TabIndex = 3;
            this.lblToplam.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 304);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.lbListele);
            this.Controls.Add(this.btnToplam);
            this.Controls.Add(this.btnDoldur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoldur;
        private System.Windows.Forms.Button btnToplam;
        private System.Windows.Forms.ListBox lbListele;
        private System.Windows.Forms.Label lblToplam;
    }
}

