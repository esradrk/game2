﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyun
{
    public partial class Frm2 : Form
    {
        Frm1 frm1;
        public Frm2(Frm1 frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;
        }

        private void btnfrm2_Click(object sender, EventArgs e)
        {
            frm1.Text = txt.Text;
        }
    }
}
