using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfApp.ServiceLichChieu;
using WcfApp.ServiceXuatChieu;
using WcfApp.ServiceCaChieu;
using WcfApp.ServiceMovie;
namespace WcfApp
{
    public partial class FormXuatChieu : Form
    {
        public FormXuatChieu()
        {
            InitializeComponent();
        }
        ServiceLichChieuClient lc_s = new ServiceLichChieuClient();
        ServiceXuatChieuClient xc_s = new ServiceXuatChieuClient();
        ServiceCaChieuClient cc_s = new ServiceCaChieuClient();
        ServiceMoviesClient mv_s = new ServiceMoviesClient();
        private void FormXuatChieu_Load(object sender, EventArgs e)
        {
            dochetcachieu();
            docngaychieu();
            
        }
        void docngaychieu()
        {
            comboBox1.DataSource = xc_s.layngay().ToList();
            comboBox1.DisplayMember = "ngay";

        }
        void dochetcachieu()
        {

            var result = cc_s.xuatCaChieu();
            foreach (CaChieu c in result)
            {
                RadioButton r = new RadioButton();
                r.Tag = c.ID;
                r.Text = c.Gio_bat_dau + ":" + c.Phut_bat_dau;
                dsCaChieu.Controls.Add(r);
            }

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime ngaychon = DateTime.Parse(comboBox1.Text);
            int caChieuChon = 0;

            foreach (RadioButton ct in dsCaChieu.Controls)
            {
                if (ct.Checked)
                {
                    caChieuChon = Convert.ToInt32(ct.Tag.ToString());
                    break;
                }
            }

            var dsPhim = mv_s.Doctheocachieu(ngaychon, caChieuChon);
            thongtinImg.Controls.Clear();
            string path = mv_s.Endpoint.Address.ToString();
            path = path.Substring(0, path.LastIndexOf("/") + 1);

            foreach (var phim in dsPhim)
            {
                PictureBox pbx = new PictureBox();
                pbx.Tag = phim.ID;
                pbx.Click += pbx_Click;
                pbx.SizeMode = PictureBoxSizeMode.StretchImage;
                pbx.ImageLocation = path + phim.Poster;
                pbx.Height = 223;
                pbx.Width = 223;
                pbx.Tag = phim;
                toolTip1.SetToolTip(pbx, phim.Ten + " - " + phim.ID);
                thongtinImg.Controls.Add(pbx);
            }
        }

        void pbx_Click(object sender, EventArgs e)
        {
            string path = mv_s.Endpoint.Address.ToString();
            path = path.Substring(0, path.LastIndexOf("/") + 1);
            PictureBox pc = sender as PictureBox;
            axWindowsMediaPlayer1.URL = path + ((PHIM_ALL)pc.Tag).Trailer;
            FormPDF pdf = new FormPDF();
            pdf.path = path + ((PHIM_ALL)pc.Tag).PDF;
            pdf.Show();
        }
    }
}
