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
    public partial class FrmDetailBeli : Form
    {
        private string _nama;
        private string _harga;
        private Image _foto;
        private string _deskripsi;

        public string Deskripsi
        {
            get { return _deskripsi; }
            set { _deskripsi = value; label3.Text = value; }
        }


        public Image Foto
        {
            get { return _foto; }
            set { Image _foto = value; pictureBox1.Image = value; }
        }


        public string Harga
        {
            get { return _harga; }
            set { _harga = value; label2.Text = value; }
        }


        public string Nama
        {
            get { return _nama; }
            set { _nama = value; label1.Text = value; }
        }

        public FrmDetailBeli()
        {
            InitializeComponent();
        }

        private void FrmDetailBeli_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
