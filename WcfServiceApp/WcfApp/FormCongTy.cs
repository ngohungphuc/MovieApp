using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfApp.WcfService;
namespace WcfApp
{
    public partial class FormCongTy : Form
    {
        ServiceCongTyClient sv = new ServiceCongTyClient();
        public FormCongTy()
        {
            InitializeComponent();
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            dataResult.DataSource = sv.DocTatCa();
        }

        private void btnLoadById_Click(object sender, EventArgs e)
        {
            if (txtIdCongTy.Text.Length == 0)
            {
                MessageBox.Show("Ban hay nhap vao id cua cong ty");
            }
            else
            {
                int id = int.Parse(txtIdCongTy.Text);
                var query = sv.DocTheoId(id);
                if (query != null)
                {
                    //dataResult.DataSource = query;
                    txtName.Text = query.Ten;
                    txtPhone.Text = query.Dien_thoai;
                    txtWeek.Text = query.So_tuan_lap_lich.ToString();
                    txtAddress.Text = query.Dia_chi;
                }
                else
                {
                    MessageBox.Show("Khong co ket qua");
                }
                
            }
   
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdCongTy.Text);
            var result=sv.Huy(id);
            if (result != null)
            {

                MessageBox.Show("Xoa thanh cong");
                dataResult.DataSource = sv.DocTatCa();
            }
            else
            {
                MessageBox.Show("Khong co id nao ung voi ban vua nhap");
                dataResult.DataSource = sv.DocTatCa();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Form1 newForm = new Form1();
            //newForm.Show();
            int id = int.Parse(txtIdCongTy.Text);
            CONG_TY cty = new CONG_TY
            {
                Ten = txtName.Text,
                Dia_chi = txtAddress.Text,
                Dien_thoai = txtPhone.Text,
                So_tuan_lap_lich = int.Parse(txtWeek.Text)
            };
            sv.Them(cty);
            dataResult.DataSource = sv.DocTatCa();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            CongTy cty = new CongTy
            {
                ID = Convert.ToInt32(txtIdCongTy.Text),
                Ten = txtName.Text,
                Dia_chi = txtAddress.Text,
                Dien_thoai = txtPhone.Text,
                So_tuan_lap_lich = Convert.ToInt32(txtWeek.Text)
            };
            
            if (sv.Sua(cty)!=null)
            {
                MessageBox.Show("ok");
                dataResult.DataSource = sv.DocTatCa();
            }
            else
            {
                MessageBox.Show("error");

            }
            dataResult.DataSource = sv.DocTatCa();
        }
    }
}
