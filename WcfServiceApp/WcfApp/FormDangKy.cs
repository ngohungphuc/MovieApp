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
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }
        ServiceDangNhapClient regis=new ServiceDangNhapClient();
        private void button1_Click(object sender, EventArgs e)
        {
            var username = txtUserName.Text;
            var pass = txtPass.Text;
            string result=regis.dangky(username, pass);
            MessageBox.Show(result); 
        }
    }
}
