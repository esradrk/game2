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
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void btnfrm2_Click(object sender, EventArgs e)
        {
            Frm2 frm = new Frm2(this);
            frm.Show();
        }
    }
}
