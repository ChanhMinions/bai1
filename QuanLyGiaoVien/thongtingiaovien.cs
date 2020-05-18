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
    public partial class thongtingiaovien : Form
    {
        public thongtingiaovien()
        {
            InitializeComponent();
        }
        public string Hoten;
        public string Sdt;
        public string Ghichu;
        public string Donvi;
        public string Coso;

        private void thongtingiaovien_Load(object sender, EventArgs e)
        {
            txt_hoten.Text = Hoten;
            txt_sdt.Text = Sdt;
            txt_ghichu.Text = Ghichu;
            txt_donvi.Text = Donvi;
            txt_coso.Text = Coso;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Quay Lại Danh Sách Giáo Viên ? ", "Thông Báo!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
            {
                this.Close();
            }
        }
    }
}
