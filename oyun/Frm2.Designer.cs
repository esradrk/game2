namespace oyun
{
    partial class Frm2
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
            this.txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnfrm2
            // 
            this.btnfrm2.Location = new System.Drawing.Point(284, 166);
            this.btnfrm2.Name = "btnfrm2";
            this.btnfrm2.Size = new System.Drawing.Size(213, 74);
            this.btnfrm2.TabIndex = 0;
            this.btnfrm2.Text = "Frm 1\'in başlığını değiştir";
            this.btnfrm2.UseVisualStyleBackColor = true;
            this.btnfrm2.Click += new System.EventHandler(this.btnfrm2_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(284, 110);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(213, 20);
            this.txt.TabIndex = 1;
            // 
            // Frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btnfrm2);
            this.Name = "Frm2";
            this.Text = "Frm2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfrm2;
        private System.Windows.Forms.TextBox txt;
    }
}