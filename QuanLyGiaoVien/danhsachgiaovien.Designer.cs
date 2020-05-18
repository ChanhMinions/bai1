namespace QuanLyGiaoVien
{
    partial class danhsachgiaovien
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hiểnThịGVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_donvi = new System.Windows.Forms.ComboBox();
            this.txt_coso = new System.Windows.Forms.ComboBox();
            this.cOSOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QuanLyGiaoVien.DataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cOSOTableAdapter = new QuanLyGiaoVien.DataSet1TableAdapters.COSOTableAdapter();
            this.xóaGVĐangChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOSOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyGiaoVien.Properties.Resources.Green_Flowers_Pattern_Fresh;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 529);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(260, 122);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ten GV";
            this.columnHeader2.Width = 1000;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiểnThịGVToolStripMenuItem,
            this.xóaGVĐangChọnToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // hiểnThịGVToolStripMenuItem
            // 
            this.hiểnThịGVToolStripMenuItem.Name = "hiểnThịGVToolStripMenuItem";
            this.hiểnThịGVToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.hiểnThịGVToolStripMenuItem.Text = "Hiển Thị GV";
            this.hiểnThịGVToolStripMenuItem.Click += new System.EventHandler(this.hiểnThịGVToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(246, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_donvi
            // 
            this.txt_donvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_donvi.FormattingEnabled = true;
            this.txt_donvi.Location = new System.Drawing.Point(73, 203);
            this.txt_donvi.Name = "txt_donvi";
            this.txt_donvi.Size = new System.Drawing.Size(235, 32);
            this.txt_donvi.TabIndex = 11;
            this.txt_donvi.SelectedIndexChanged += new System.EventHandler(this.txt_donvi_SelectedIndexChanged);
            // 
            // txt_coso
            // 
            this.txt_coso.DataSource = this.cOSOBindingSource;
            this.txt_coso.DisplayMember = "macoso";
            this.txt_coso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coso.FormattingEnabled = true;
            this.txt_coso.Location = new System.Drawing.Point(140, 128);
            this.txt_coso.Name = "txt_coso";
            this.txt_coso.Size = new System.Drawing.Size(168, 32);
            this.txt_coso.TabIndex = 10;
            this.txt_coso.SelectedIndexChanged += new System.EventHandler(this.txt_coso_SelectedIndexChanged);
            // 
            // cOSOBindingSource
            // 
            this.cOSOBindingSource.DataMember = "COSO";
            this.cOSOBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Đơn Vị Đào Tạo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cơ Sở :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(69, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "THÔNG TIN GIÁO VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 175);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Giáo Viên :";
            // 
            // cOSOTableAdapter
            // 
            this.cOSOTableAdapter.ClearBeforeFill = true;
            // 
            // xóaGVĐangChọnToolStripMenuItem
            // 
            this.xóaGVĐangChọnToolStripMenuItem.Name = "xóaGVĐangChọnToolStripMenuItem";
            this.xóaGVĐangChọnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xóaGVĐangChọnToolStripMenuItem.Text = "Xóa GV Đang Chọn";
            this.xóaGVĐangChọnToolStripMenuItem.Click += new System.EventHandler(this.xóaGVĐangChọnToolStripMenuItem_Click);
            // 
            // danhsachgiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 526);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_donvi);
            this.Controls.Add(this.txt_coso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "danhsachgiaovien";
            this.Text = "danhsachgiaovien";
            this.Load += new System.EventHandler(this.danhsachgiaovien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cOSOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox txt_donvi;
        private System.Windows.Forms.ComboBox txt_coso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cOSOBindingSource;
        private DataSet1TableAdapters.COSOTableAdapter cOSOTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hiểnThịGVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaGVĐangChọnToolStripMenuItem;
    }
}