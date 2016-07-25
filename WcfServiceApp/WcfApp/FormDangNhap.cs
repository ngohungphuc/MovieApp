using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfApp.ServiceDangNhap;
namespace WcfApp
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        ServiceDangNhapClient login = new ServiceDangNhapClient();
        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName == null && txtPassword == null || txtUserName == null || txtPassword == null)
            {
                MessageBox.Show("Vui long nhap day du thong tin");
            }
            else
            {
                var username = txtUserName.Text;
                var pass = txtPassword.Text;
                var check=login.dangnhap(username,pass);
                if (check!=null)
                {
                    MessageBox.Show("Dang nhap thanh cong");
                }
                else
                {
                    MessageBox.Show("Sai ten dang nhap hoac mat khau");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
