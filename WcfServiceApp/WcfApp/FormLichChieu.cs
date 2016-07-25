using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfApp.SearchSv;
using WcfApp.WcfService;
using WcfApp.ServiceLichChieu;
using WcfApp.ServiceMovie;
using WcfApp.ServiceXuatChieu;
namespace WcfApp
{
    public partial class FormLichChieu : Form
    {
        public FormLichChieu()
        {
            InitializeComponent();
        }
        SearchServiceClient scl = new SearchServiceClient();
        ServiceCongTyClient scty = new ServiceCongTyClient();
        ServiceLichChieuClient slc = new ServiceLichChieuClient();
        ServiceMoviesClient smv = new ServiceMoviesClient();
        ServiceXuatChieuClient sxc = new ServiceXuatChieuClient();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox chon = sender as ComboBox;
            string a = chon.SelectedValue.ToString();
            int id = 0;
            int.TryParse(a,out id);
            listBox1.DataSource = smv.DocTheoLich(id);
            listBox1.DisplayMember = "Ten";
            listBox1.ValueMember = "ID";
        }
        
        private void FormLichChieu_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = slc.DocTatCa().ToList();
            comboBox1.DisplayMember = "ThoiGian";
            comboBox1.ValueMember = "ID";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sxc.DocTheoPhim((int)listBox1.SelectedValue).ToList<XuatChieu>();

            //DateTime ngayBatDau, ngayKetThuc;
            //ngayBatDau = ((LichChieu)cboLichChieu.SelectedItem).Ngay_bat_dau;
            //ngayKetThuc = ((LichChieu)cboLichChieu.SelectedItem).Ngay_ket_thuc;

            //dgvXuatChieu.DataSource = dsXuatChieu.Where(xc => xc.Ngay >= ngayBatDau && xc.Ngay <= ngayKetThuc).ToList();
        }
    }
}
