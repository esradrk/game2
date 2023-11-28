namespace oyun
{
    partial class Frmoyun
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
            this.btnyakala = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.lblbilgi = new System.Windows.Forms.Label();
            this.lblsure = new System.Windows.Forms.Label();
            this.lblskor = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnyakala
            // 
            this.btnyakala.BackColor = System.Drawing.Color.DarkOrange;
            this.btnyakala.Location = new System.Drawing.Point(0, 0);
            this.btnyakala.Name = "btnyakala";
            this.btnyakala.Size = new System.Drawing.Size(87, 54);
            this.btnyakala.TabIndex = 0;
            this.btnyakala.UseVisualStyleBackColor = false;
            this.btnyakala.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnyakala_MouseMove);
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.Yellow;
            this.pnl.Controls.Add(this.lblbilgi);
            this.pnl.Controls.Add(this.lblsure);
            this.pnl.Controls.Add(this.lblskor);
            this.pnl.Location = new System.Drawing.Point(631, 1);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(169, 452);
            this.pnl.TabIndex = 1;
            // 
            // lblbilgi
            // 
            this.lblbilgi.AutoSize = true;
            this.lblbilgi.Location = new System.Drawing.Point(39, 277);
            this.lblbilgi.Name = "lblbilgi";
            this.lblbilgi.Size = new System.Drawing.Size(0, 13);
            this.lblbilgi.TabIndex = 2;
            // 
            // lblsure
            // 
            this.lblsure.AutoSize = true;
            this.lblsure.Location = new System.Drawing.Point(39, 134);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(0, 13);
            this.lblsure.TabIndex = 1;
            // 
            // lblskor
            // 
            this.lblskor.AutoSize = true;
            this.lblskor.Location = new System.Drawing.Point(39, 32);
            this.lblskor.Name = "lblskor";
            this.lblskor.Size = new System.Drawing.Size(0, 13);
            this.lblskor.TabIndex = 0;
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // Frmoyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.btnyakala);
            this.Name = "Frmoyun";
            this.Text = "Frmoyun";
            this.SizeChanged += new System.EventHandler(this.Frmoyun_SizeChanged);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnyakala;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label lblskor;
        private System.Windows.Forms.Label lblsure;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Label lblbilgi;
    }
}