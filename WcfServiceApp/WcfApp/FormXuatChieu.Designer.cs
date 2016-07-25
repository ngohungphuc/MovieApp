namespace WcfApp
{
    partial class FormXuatChieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormXuatChieu));
            this.dsCaChieug = new System.Windows.Forms.GroupBox();
            this.dsCaChieu = new System.Windows.Forms.FlowLayoutPanel();
            this.groupThongTin = new System.Windows.Forms.GroupBox();
            this.thongtinImg = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.dsCaChieug.SuspendLayout();
            this.groupThongTin.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsCaChieug
            // 
            this.dsCaChieug.Controls.Add(this.dsCaChieu);
            this.dsCaChieug.Location = new System.Drawing.Point(209, 13);
            this.dsCaChieug.Name = "dsCaChieug";
            this.dsCaChieug.Size = new System.Drawing.Size(387, 86);
            this.dsCaChieug.TabIndex = 1;
            this.dsCaChieug.TabStop = false;
            this.dsCaChieug.Text = "Ca Chieu";
            // 
            // dsCaChieu
            // 
            this.dsCaChieu.Location = new System.Drawing.Point(6, 19);
            this.dsCaChieu.Name = "dsCaChieu";
            this.dsCaChieu.Size = new System.Drawing.Size(375, 50);
            this.dsCaChieu.TabIndex = 0;
            // 
            // groupThongTin
            // 
            this.groupThongTin.Controls.Add(this.thongtinImg);
            this.groupThongTin.Location = new System.Drawing.Point(16, 165);
            this.groupThongTin.Name = "groupThongTin";
            this.groupThongTin.Size = new System.Drawing.Size(580, 257);
            this.groupThongTin.TabIndex = 2;
            this.groupThongTin.TabStop = false;
            this.groupThongTin.Text = "Thong tin";
            // 
            // thongtinImg
            // 
            this.thongtinImg.Location = new System.Drawing.Point(19, 20);
            this.thongtinImg.Name = "thongtinImg";
            this.thongtinImg.Size = new System.Drawing.Size(547, 221);
            this.thongtinImg.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(16, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 87);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ngay Chieu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(580, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Liet Ke";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(16, 429);
            this.axWindowsMediaPlayer1.MaximumSize = new System.Drawing.Size(580, 400);
            this.axWindowsMediaPlayer1.MinimumSize = new System.Drawing.Size(580, 400);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(580, 400);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // FormXuatChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 1009);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupThongTin);
            this.Controls.Add(this.dsCaChieug);
            this.Name = "FormXuatChieu";
            this.Text = "FormXuatChieu";
            this.Load += new System.EventHandler(this.FormXuatChieu_Load);
            this.dsCaChieug.ResumeLayout(false);
            this.groupThongTin.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dsCaChieug;
        private System.Windows.Forms.GroupBox groupThongTin;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel dsCaChieu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel thongtinImg;
        private System.Windows.Forms.ToolTip toolTip1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}