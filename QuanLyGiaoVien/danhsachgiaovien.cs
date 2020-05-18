using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QuanLyGiaoVien
{
    public partial class danhsachgiaovien : Form
    {
        public danhsachgiaovien()
        {
            InitializeComponent();
        }
        String chuoiketnoi = @"Data Source=DESKTOP-5MP3V7M;Initial Catalog=QuanLyGiaoVien;Integrated Security=True";
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        string sql;
        int i = 0;
        public string hoten;
        public string sdt;
        public string ghichu;
        public string donvi;
        public string coso;


        private void txt_coso_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            txt_donvi.Items.Clear();
            ketnoi.Open();
            string Sql = @"Select COSO.macoso,DONVI.madonvi 
            FROM COSO Inner join DONVI 
            ON COSO.macoso = DONVI.macoso
            WHERE (COSO.macoso = N'" + txt_coso.Text + @"')";
            thuchien = new SqlCommand(Sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                txt_donvi.Items.Add(docdulieu[1].ToString());
            }
            ketnoi.Close();
        }

        private void danhsachgiaovien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.COSO' table. You can move, or remove it, as needed.
            this.cOSOTableAdapter.Fill(this.dataSet1.COSO);
            ketnoi = new SqlConnection(chuoiketnoi);

        }

        private void txt_donvi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hienthi();
        }
        public void Hienthi()
        {
            listView1.Items.Clear();
            txt_donvi.Items.Clear();
            ketnoi.Open();
            sql = @"Select GiaoVien.hoten,GiaoVien.sdt,GiaoVien.ghichu,COSO.macoso,DONVI.madonvi 
            FROM GiaoVien Inner Join DONVI
            ON GiaoVien.madonvi = DONVI.madonvi Inner join COSO 
            ON DONVI.macoso = COSO.macoso 
            WHERE(COSO.macoso = N'" + txt_coso.Text + @"') and (DONVI.madonvi = N'" + txt_donvi.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                listView1.Items.Add((i + 1).ToString());
                listView1.Items[i].SubItems.Add(docdulieu[0].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[1].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[2].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[3].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[4].ToString());
                i++;
            }
            ketnoi.Close();
        }

        private void hiểnThịGVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtingiaovien f = new thongtingiaovien();
            f.Hoten = hoten;
            f.Sdt = sdt;
            f.Ghichu = ghichu;
            f.Donvi = donvi;
            f.Coso = coso;
            f.Show();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            hoten = listView1.SelectedItems[0].SubItems[1].Text;
            sdt = listView1.SelectedItems[0].SubItems[2].Text;
            ghichu = listView1.SelectedItems[0].SubItems[3].Text;
            donvi = listView1.SelectedItems[0].SubItems[4].Text;
            coso = listView1.SelectedItems[0].SubItems[5].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn thoát chương trình ? ", "Thông Báo!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
            {
                this.Close();
            }
        }

        private void xóaGVĐangChọnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtingiaovien f = new thongtingiaovien();
            f.Hoten = hoten;
            f.Sdt = sdt;
            f.Ghichu = ghichu;
            f.Donvi = donvi;
            f.Coso = coso;
            f.Show();
        }
    }
}
