using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaoVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string tenmay;
        public string tencsdl;
        public string dangnhap;
        public string matkhau;

        private void tb_ketnoi_Click(object sender, EventArgs e)
        {
            danhsachgiaovien f = new danhsachgiaovien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tb_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn thoát chương trình ? ", "Thông Báo!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
