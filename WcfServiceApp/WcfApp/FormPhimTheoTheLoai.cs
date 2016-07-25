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
    public partial class FormPhimTheoTheLoai : Form
    {
        public FormPhimTheoTheLoai()
        {
            InitializeComponent();
        }
        SearchServiceClient s_cat = new SearchServiceClient();
        private void FormPhimTheoTheLoai_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = s_cat.DocTheLoai().ToList();
            comboBox1.DisplayMember = "The_loai";
            //comboBox1.ValueMember = "ID";
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox selected_val = sender as ComboBox;
            string value = selected_val.SelectedValue.ToString();
            dataGridView1.DataSource = s_cat.DocPhimTheoTheLoai(value).ToList();
        }
    }
}
