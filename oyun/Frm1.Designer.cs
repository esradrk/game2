namespace oyun
{
    partial class Frm1
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
            this.btnfrm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfrm2
            // 
            this.btnfrm2.Location = new System.Drawing.Point(257, 171);
            this.btnfrm2.Name = "btnfrm2";
            this.btnfrm2.Size = new System.Drawing.Size(228, 43);
            this.btnfrm2.TabIndex = 0;
            this.btnfrm2.Text = "Frm 2\'ye git";
            this.btnfrm2.UseVisualStyleBackColor = true;
            this.btnfrm2.Click += new System.EventHandler(this.btnfrm2_Click);
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnfrm2);
            this.Name = "Frm1";
            this.Text = "Frm1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfrm2;
    }
}