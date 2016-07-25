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
namespace WcfApp
{
    public partial class FormSearch : Form
    {
         SearchServiceClient sv = new SearchServiceClient();
          
        public FormSearch()
        {
            InitializeComponent();
          
        }
       
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sv.DocTatCa();          
        }

        private void btnOrderByCat_Click(object sender, EventArgs e)
        {
            string cat = comboBox1.SelectedValue.ToString();
            dataGridView1.DataSource = sv.DocPhimTheoTheLoai(cat);
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = sv.DocTheLoai().ToList();
            comboBox1.DisplayMember = "The_loai";
            //comboBox1.ValueMember = "The_loai";
        }
    }
}
