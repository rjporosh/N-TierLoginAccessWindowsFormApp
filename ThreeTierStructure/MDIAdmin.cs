﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThreeTierStructure
{
    public partial class MDIAdmin : Form
    {
        public MDIAdmin()
        {
            InitializeComponent();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEmployees ve = new ViewEmployees();
            ve.MdiParent = this;
            ve.Show();
        }
    }
}
