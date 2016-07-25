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
    public partial class FormPDF : Form
    {
        public FormPDF()
        {
            InitializeComponent();
        }
        public string path = null;
        private void FormPDF_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(path);
        }
    }
}
