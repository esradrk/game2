namespace oyun
{
    partial class Frmkullanici
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
            this.grpkullanıcı = new System.Windows.Forms.GroupBox();
            this.btnoyun = new System.Windows.Forms.Button();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.grplevel = new System.Windows.Forms.GroupBox();
            this.rdkolay = new System.Windows.Forms.RadioButton();
            this.rdorta = new System.Windows.Forms.RadioButton();
            this.rdzor = new System.Windows.Forms.RadioButton();
            this.grpkullanıcı.SuspendLayout();
            this.grplevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpkullanıcı
            // 
            this.grpkullanıcı.Controls.Add(this.txtsoyad);
            this.grpkullanıcı.Controls.Add(this.txtad);
            this.grpkullanıcı.Controls.Add(this.lblsoyad);
            this.grpkullanıcı.Controls.Add(this.lblad);
            this.grpkullanıcı.Location = new System.Drawing.Point(12, 12);
            this.grpkullanıcı.Name = "grpkullanıcı";
            this.grpkullanıcı.Size = new System.Drawing.Size(248, 174);
            this.grpkullanıcı.TabIndex = 0;
            this.grpkullanıcı.TabStop = false;
            this.grpkullanıcı.Text = "Kullanıcı Bilgileri";
            // 
            // btnoyun
            // 
            this.btnoyun.Location = new System.Drawing.Point(12, 280);
            this.btnoyun.Name = "btnoyun";
            this.btnoyun.Size = new System.Drawing.Size(243, 37);
            this.btnoyun.TabIndex = 4;
            this.btnoyun.Text = "Oyunu Başlat";
            this.btnoyun.UseVisualStyleBackColor = true;
            this.btnoyun.Click += new System.EventHandler(this.btnoyun_Click);
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(120, 97);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtsoyad.TabIndex = 3;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(120, 52);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 2;
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Location = new System.Drawing.Point(55, 104);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(37, 13);
            this.lblsoyad.TabIndex = 1;
            this.lblsoyad.Text = "Soyad";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(55, 52);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(20, 13);
            this.lblad.TabIndex = 0;
            this.lblad.Text = "Ad";
            // 
            // grplevel
            // 
            this.grplevel.Controls.Add(this.rdzor);
            this.grplevel.Controls.Add(this.rdorta);
            this.grplevel.Controls.Add(this.rdkolay);
            this.grplevel.Location = new System.Drawing.Point(12, 192);
            this.grplevel.Name = "grplevel";
            this.grplevel.Size = new System.Drawing.Size(248, 82);
            this.grplevel.TabIndex = 1;
            this.grplevel.TabStop = false;
            this.grplevel.Text = "Seviye İşlemleri";
            // 
            // rdkolay
            // 
            this.rdkolay.AutoSize = true;
            this.rdkolay.Location = new System.Drawing.Point(6, 38);
            this.rdkolay.Name = "rdkolay";
            this.rdkolay.Size = new System.Drawing.Size(51, 17);
            this.rdkolay.TabIndex = 0;
            this.rdkolay.TabStop = true;
            this.rdkolay.Text = "Kolay";
            this.rdkolay.UseVisualStyleBackColor = true;
            // 
            // rdorta
            // 
            this.rdorta.AutoSize = true;
            this.rdorta.Location = new System.Drawing.Point(87, 38);
            this.rdorta.Name = "rdorta";
            this.rdorta.Size = new System.Drawing.Size(45, 17);
            this.rdorta.TabIndex = 1;
            this.rdorta.TabStop = true;
            this.rdorta.Text = "Orta";
            this.rdorta.UseVisualStyleBackColor = true;
            // 
            // rdzor
            // 
            this.rdzor.AutoSize = true;
            this.rdzor.Location = new System.Drawing.Point(165, 38);
            this.rdzor.Name = "rdzor";
            this.rdzor.Size = new System.Drawing.Size(41, 17);
            this.rdzor.TabIndex = 2;
            this.rdzor.TabStop = true;
            this.rdzor.Text = "Zor";
            this.rdzor.UseVisualStyleBackColor = true;
            // 
            // Frmkullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 326);
            this.Controls.Add(this.grplevel);
            this.Controls.Add(this.btnoyun);
            this.Controls.Add(this.grpkullanıcı);
            this.Name = "Frmkullanici";
            this.Text = "Frmkullanici";
            this.grpkullanıcı.ResumeLayout(false);
            this.grpkullanıcı.PerformLayout();
            this.grplevel.ResumeLayout(false);
            this.grplevel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpkullanıcı;
        private System.Windows.Forms.Button btnoyun;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.GroupBox grplevel;
        private System.Windows.Forms.RadioButton rdzor;
        private System.Windows.Forms.RadioButton rdorta;
        private System.Windows.Forms.RadioButton rdkolay;
    }
}