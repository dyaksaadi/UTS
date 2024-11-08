using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace D_UTS
{
    public partial class HalamanRegistrasi : Form
    {
        public HalamanRegistrasi()
        {
            InitializeComponent();
        }

        private void tbUsernameRegistrasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrasi_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Inputan tidak valid");
                return;
            }

            M_Akun Akun = new M_Akun
            {
                username = tbUsernameRegistrasi.Text,
                password = tbPasswordRegistrasi.Text,
            };

        }
        private void ClearFields()
        {
            tbUsernameRegistrasi.Clear();
            tbPasswordRegistrasi.Clear();
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(tbUsernameRegistrasi.Text) ||
                string.IsNullOrWhiteSpace(tbPasswordRegistrasi.Text) ||
            {
                return false;
            }
            return true;
        }

    }
}
