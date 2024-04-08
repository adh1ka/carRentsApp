using System;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void tbUsn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLgn_Click(object sender, EventArgs e)
        {
            if (tbPwd.Text == ""||tbUsn.Text == "")
            {
                MessageBox.Show("Isi data terlebih dahulu");
                koneksi.validate("users", namaKolom, value);
            }
            else
            {
                string[] namaKolom = {"username", "password"};
                string[] value = {tbUsn.Text, tbPwd.Text};
                koneksi.validate("users", namaKolom, value);
            }
        }
    }
}
