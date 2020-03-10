using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pembelian
{
    public partial class FrmHome : Form
    {
        FrmBeli formBeli = new FrmBeli();
        User user = new User();
        public FrmHome()
        {
            InitializeComponent();
            txtName.Text = "aaa" + user.Username;
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            formBeli.TopLevel = false;
            PnlUtama.Controls.Add(formBeli);
            formBeli.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKatalog_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://screamous.com/");
        }
    }
}
