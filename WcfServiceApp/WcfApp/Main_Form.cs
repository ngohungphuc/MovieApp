using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WcfApp
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void dangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDangNhap login_f = new FormDangNhap();
            login_f.MdiParent = this;
            login_f.Show();
        }

        private void thoatRaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dangKyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDangKy regis_f = new FormDangKy();
            regis_f.MdiParent = this;
            regis_f.Show();
        }

        private void phimTheoTheLoaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPhimTheoTheLoai cat_f = new FormPhimTheoTheLoai();
            cat_f.MdiParent = this;
            cat_f.Show();
        }

        private void phimTheoXuatChieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormXuatChieu xc_f = new FormXuatChieu();
            xc_f.MdiParent = this;
            xc_f.Show();
        }
    }
}
