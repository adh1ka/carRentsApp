﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carRentsApps
{
    public partial class mngUser : Form
    {
        public mngUser()
        {
            InitializeComponent();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Semua data user akan hilang", "Hapus user?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
