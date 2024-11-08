using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_UTS
{
    public partial class SelamatDatang : Form
    {
        public SelamatDatang()
        {
            InitializeComponent();
        }

        private void btnHalamanBuku_Click(object sender, EventArgs e)
        {
            HalamanBuku halamanbuku = new HalamanBuku();
            this.Hide();
            halamanbuku.ShowDialog();
        }

        private void btnRegistrasi_Click(object sender, EventArgs e)
        {
            HalamanRegistrasi halamanRegistrasi = new HalamanRegistrasi();
            this.Hide();
            halamanRegistrasi.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            HalamanLogin halamanLogin = new HalamanLogin();
            this.Hide();
            halamanLogin.ShowDialog();
        }
    }
}
