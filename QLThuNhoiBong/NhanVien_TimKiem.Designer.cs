namespace QLThuNhoiBong
{
    partial class NhanVien_TimKiem
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
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbChonMaCV = new System.Windows.Forms.Label();
            this.cbChonMaCV = new System.Windows.Forms.ComboBox();
            this.txbMucLuong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbCongViec = new System.Windows.Forms.TextBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.txbDienThoai = new System.Windows.Forms.TextBox();
            this.txbTenNV = new System.Windows.Forms.TextBox();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNgay = new System.Windows.Forms.TextBox();
            this.txbThang = new System.Windows.Forms.TextBox();
            this.txbNam = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHienThi2 = new System.Windows.Forms.DataGridView();
            this.saveExcel = new System.Windows.Forms.SaveFileDialog();
            this.btnExcel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(123, 99);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(100, 21);
            this.cbGioiTinh.TabIndex = 66;
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.Location = new System.Drawing.Point(190, 294);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(75, 23);
            this.btnQuayVe.TabIndex = 65;
            this.btnQuayVe.Text = "Quay về";
            this.btnQuayVe.UseVisualStyleBackColor = true;
            this.btnQuayVe.Click += new System.EventHandler(this.BtnQuayVe_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(109, 294);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(75, 23);
            this.btnLamLai.TabIndex = 64;
            this.btnLamLai.Text = "Làm Lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.BtnLamLai_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(28, 294);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 63;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.BtnTimKiem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(81, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 29);
            this.label8.TabIndex = 61;
            this.label8.Text = "Tìm kiếm nhân viên";
            // 
            // lbChonMaCV
            // 
            this.lbChonMaCV.AutoSize = true;
            this.lbChonMaCV.Location = new System.Drawing.Point(12, 206);
            this.lbChonMaCV.Name = "lbChonMaCV";
            this.lbChonMaCV.Size = new System.Drawing.Size(102, 13);
            this.lbChonMaCV.TabIndex = 60;
            this.lbChonMaCV.Text = "Chọn Mã Công Việc";
            // 
            // cbChonMaCV
            // 
            this.cbChonMaCV.FormattingEnabled = true;
            this.cbChonMaCV.Location = new System.Drawing.Point(123, 203);
            this.cbChonMaCV.Name = "cbChonMaCV";
            this.cbChonMaCV.Size = new System.Drawing.Size(100, 21);
            this.cbChonMaCV.TabIndex = 59;
            this.cbChonMaCV.SelectedIndexChanged += new System.EventHandler(this.CbChonMaCV_SelectedIndexChanged);
            // 
            // txbMucLuong
            // 
            this.txbMucLuong.Enabled = false;
            this.txbMucLuong.Location = new System.Drawing.Point(123, 257);
            this.txbMucLuong.Name = "txbMucLuong";
            this.txbMucLuong.Size = new System.Drawing.Size(100, 20);
            this.txbMucLuong.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Mức Lương";
            // 
            // txbCongViec
            // 
            this.txbCongViec.Enabled = false;
            this.txbCongViec.Location = new System.Drawing.Point(123, 231);
            this.txbCongViec.Name = "txbCongViec";
            this.txbCongViec.Size = new System.Drawing.Size(100, 20);
            this.txbCongViec.TabIndex = 55;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Location = new System.Drawing.Point(123, 177);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(100, 20);
            this.txbDiaChi.TabIndex = 54;
            // 
            // txbDienThoai
            // 
            this.txbDienThoai.Location = new System.Drawing.Point(123, 151);
            this.txbDienThoai.Name = "txbDienThoai";
            this.txbDienThoai.Size = new System.Drawing.Size(100, 20);
            this.txbDienThoai.TabIndex = 53;
            // 
            // txbTenNV
            // 
            this.txbTenNV.Location = new System.Drawing.Point(123, 73);
            this.txbTenNV.Name = "txbTenNV";
            this.txbTenNV.Size = new System.Drawing.Size(100, 20);
            this.txbTenNV.TabIndex = 52;
            // 
            // txbMaNV
            // 
            this.txbMaNV.Location = new System.Drawing.Point(123, 47);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(100, 20);
            this.txbMaNV.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Công Việc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Điện Thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Giới Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // txbNgay
            // 
            this.txbNgay.Location = new System.Drawing.Point(123, 125);
            this.txbNgay.Name = "txbNgay";
            this.txbNgay.Size = new System.Drawing.Size(30, 20);
            this.txbNgay.TabIndex = 67;
            // 
            // txbThang
            // 
            this.txbThang.Location = new System.Drawing.Point(203, 125);
            this.txbThang.Name = "txbThang";
            this.txbThang.Size = new System.Drawing.Size(30, 20);
            this.txbThang.TabIndex = 68;
            // 
            // txbNam
            // 
            this.txbNam.Location = new System.Drawing.Point(272, 125);
            this.txbNam.Name = "txbNam";
            this.txbNam.Size = new System.Drawing.Size(50, 20);
            this.txbNam.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(85, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 70;
            this.label10.Text = "Ngày";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(159, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 71;
            this.label11.Text = "Tháng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(239, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 72;
            this.label12.Text = "Năm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHienThi2);
            this.groupBox1.Location = new System.Drawing.Point(358, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 349);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả tìm kiếm";
            // 
            // dgvHienThi2
            // 
            this.dgvHienThi2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThi2.Location = new System.Drawing.Point(3, 16);
            this.dgvHienThi2.Name = "dgvHienThi2";
            this.dgvHienThi2.Size = new System.Drawing.Size(615, 327);
            this.dgvHienThi2.TabIndex = 0;
            this.dgvHienThi2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHienThi2_CellDoubleClick);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(28, 323);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 74;
            this.btnExcel.Text = "In Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // NhanVien_TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 361);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbNam);
            this.Controls.Add(this.txbThang);
            this.Controls.Add(this.txbNgay);
            this.Controls.Add(this.cbGioiTinh);
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbChonMaCV);
            this.Controls.Add(this.cbChonMaCV);
            this.Controls.Add(this.txbMucLuong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbCongViec);
            this.Controls.Add(this.txbDiaChi);
            this.Controls.Add(this.txbDienThoai);
            this.Controls.Add(this.txbTenNV);
            this.Controls.Add(this.txbMaNV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NhanVien_TimKiem";
            this.Text = "NhanVien_TimKiem";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Button btnQuayVe;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbChonMaCV;
        private System.Windows.Forms.ComboBox cbChonMaCV;
        private System.Windows.Forms.TextBox txbMucLuong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbCongViec;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.TextBox txbDienThoai;
        private System.Windows.Forms.TextBox txbTenNV;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNgay;
        private System.Windows.Forms.TextBox txbThang;
        private System.Windows.Forms.TextBox txbNam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHienThi2;
        private System.Windows.Forms.SaveFileDialog saveExcel;
        private System.Windows.Forms.Button btnExcel;
    }
}