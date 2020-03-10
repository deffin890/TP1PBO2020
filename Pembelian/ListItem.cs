using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pembelian.Properties;

namespace Pembelian
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }

        private string _judul;
        private string _harga;
        private Image _icon;

        [Category("Custom Props")]
        public string Judul
        {
            get { return _judul; }
            set { _judul = value; lblJudul.Text = value; }
        }

        [Category("Custom Props")]
        public string Harga
        {
            get { return _harga; }
            set { _harga = value; lblHarga.Text = value; }
        }

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }

        [Category("Custom Props")]
        public string Button
        {
            get { return btnBeli.Name; }
            set { btnBeli.Name = value; }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            FrmDetailBeli fdb = new FrmDetailBeli();
            string s = (sender as Button).Name;

            if(string.Compare(s,"btn1") == 0)
            {
                fdb.Nama = "Baju Bedug";
                fdb.Harga = "Rp.150.000";
                fdb.Foto = Resources.icons8_t_shirt_64;
                fdb.Deskripsi = "ini baju bedug";
                fdb.Show();
            }
            else if (string.Compare(s, "btn2") == 0)
            {
                fdb.Nama = "Bikini";
                fdb.Harga = "Rp.400.000";
                fdb.Foto = Resources.icons8_bra_64;
                fdb.Deskripsi = "ini bikini buat perempuan";
                fdb.Show();
            }
            else if (string.Compare(s, "btn3") == 0)
            {
                fdb.Nama = "GoPro";
                fdb.Harga = "Rp.100.000.000";
                fdb.Foto = Resources.icons8_camera_64;
                fdb.Deskripsi = "ini gopro buat foto foto";
                fdb.Show();
            }
            else if (string.Compare(s, "btn4") == 0)
            {
                fdb.Nama = "Handphone";
                fdb.Harga = "Rp.900.000";
                fdb.Foto = Resources.icons8_phonelink_ring_64;
                fdb.Deskripsi = "ini HP buat bucin";
                fdb.Show();
            }
            else if (string.Compare(s, "btn5") == 0)
            {
                fdb.Nama = "Pizza";
                fdb.Harga = "Rp.100.000";
                fdb.Foto = Resources.icons8_italian_pizza_64;
                fdb.Deskripsi = "ini Pizza buat pesta";
                fdb.Show();
            }
            else if (string.Compare(s, "btn6") == 0)
            {
                fdb.Nama = "Ayam Geprek Emas";
                fdb.Harga = "Rp.500.000.000";
                fdb.Foto = Resources.icons8_chicken_box_64;
                fdb.Deskripsi = "ini ayam geprek buat makan";
                fdb.Show();
            }

        }
    }
}
