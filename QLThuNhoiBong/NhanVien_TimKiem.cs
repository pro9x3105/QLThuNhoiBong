using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLThuNhoiBong
{
    public partial class NhanVien_TimKiem : Form
    {
        ProcessDataBase connv1 = new ProcessDataBase();
        public string TimKiemNhanVien = "";
        public NhanVien_TimKiem()
        {
            InitializeComponent();
            ThemComboBoxCV();
            ThemComboBoxGioiTinh();
            this.ClientSize = new System.Drawing.Size(350, 400);
        }
        public void ThemComboBoxCV()
        {
            DataTable dt2 = connv1.DocBang("SELECT * FROM tbl_CongViec");
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                cbChonMaCV.Items.Add(dt2.Rows[i]["MaCV"].ToString());
            }
        }
        public void ThemComboBoxGioiTinh()
        {
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(1000, 400);
            TimKiemNhanVien = "SELECT MaNV as [Mã Nhân Viên] , TenNV as [Tên Nhân Viên] , IIF(GioiTinh = 'True', N'Nam', N'Nữ') as [Giới Tính] , DienThoai as [Điện Thoại] , TenCV as [Công Việc] FROM tbl_NhanVien left join tbl_CongViec on tbl_NhanVien.MaCV = tbl_CongViec.MaCV WHERE MaNV is not null";
            if (txbMaNV.Text != "")
            {
                TimKiemNhanVien += " AND MaNV='" + txbMaNV.Text + "'";
            }
            if (txbTenNV.Text != "")
            {
                TimKiemNhanVien += " AND TenNV='" + txbTenNV.Text + "'";
            }
            if (cbGioiTinh.Text != "")
            {
                string convertGioiTinh = "";
                if (cbGioiTinh.Text == "Nam")
                {
                    convertGioiTinh = "True";
                }
                else if(cbGioiTinh.Text == "Nữ")
                {
                    convertGioiTinh = "False";
                }
                TimKiemNhanVien += " AND Gioitinh='" + convertGioiTinh+ "'";
            }
            if (txbNgay.Text != "")
            {
                TimKiemNhanVien += " AND DAY(NgaySinh)='" + txbNgay.Text + "'";
            }
            if (txbThang.Text != "")
            {
                TimKiemNhanVien += " AND MONTH(NgaySinh)='" + txbThang.Text + "'";
            }
            if (txbNam.Text != "")
            {
                TimKiemNhanVien += " AND YEAR(NgaySinh)='" + txbNam.Text + "'";
            }
            if (txbDienThoai.Text != "")
            {
                TimKiemNhanVien += " AND DienThoai='" + txbDienThoai.Text + "'";
            }
            if (txbDiaChi.Text != "")
            {
                TimKiemNhanVien += " AND Diachi='" + txbDiaChi.Text + "'";
            }
            if (cbChonMaCV.Text != "")
            {
                TimKiemNhanVien += " AND tbl_NhanVien.MaCV='" + cbChonMaCV.SelectedItem.ToString() + "'";
            }
            DataTable dt1 = connv1.DocBang(TimKiemNhanVien);
            dgvHienThi2.DataSource = dt1;
            
        }


        private void BtnLamLai_Click(object sender, EventArgs e)
        {
            txbMaNV.Clear();
            txbTenNV.Clear();
            cbGioiTinh.Text = "";
            txbNgay.Text = "";
            txbThang.Text = "";
            txbNam.Text = "";
            txbDienThoai.Clear();
            txbDiaChi.Clear();
            cbChonMaCV.Text = "";
            txbCongViec.Clear();
            txbMucLuong.Clear();
            DataTable dt = null;
            dgvHienThi2.DataSource = dt;
            this.ClientSize = new System.Drawing.Size(350, 400);
        }

        private void CbChonMaCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = cbChonMaCV.SelectedItem.ToString();
            DataTable dt3 = new DataTable();
            dt3 = connv1.DocBang("SELECT * FROM tbl_CongViec WHERE MaCV='" + a + "'");
            txbCongViec.Text = dt3.Rows[0]["TenCV"].ToString();
            txbMucLuong.Text = dt3.Rows[0]["MucLuong"].ToString();
        }

        private void BtnQuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvHienThi2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string chitiet = dgvHienThi2.CurrentRow.Cells["Mã Nhân Viên"].Value.ToString();
            NhanVien_ChiTiet form_ChiTiet = new NhanVien_ChiTiet(chitiet);
            form_ChiTiet.Show();
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            if(dgvHienThi2.Rows.Count > 0) //TH co du lieu de ghi
            {
                Excel.Application exApp = new Excel.Application();
                Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
                //Dinh dang chung
                Excel.Range tenExcel = (Excel.Range)exSheet.Cells[1, 1];
                tenExcel.Font.Size=14;
                tenExcel.Font.Bold = true;
                tenExcel.Font.Color = Color.Blue;
                tenExcel.Value = "Form Nhân Viên";
                Excel.Range header = (Excel.Range)exSheet.Cells[3, 1];
                exSheet.get_Range("A3:F3").Merge(true);
                header.Font.Size=16;
                header.Font.Bold = true;
                header.Font.Color = Color.Red;
                exSheet.get_Range("A3:F3").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                header.Value = "DANH SÁCH NHÂN VIÊN";
                //Dinh dang tieu de excel
                exSheet.get_Range("A4:F4").Font.Bold = true;
                exSheet.get_Range("A4:F4").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                exSheet.get_Range("A4").Value = "STT";
                exSheet.get_Range("A4").BorderAround2();

                char ascii = (char)65;  //A=65
                for (int i = 0; i < dgvHienThi2.Columns.Count; i++)
                {
                    ascii++;
                    exSheet.get_Range(ascii+"4").Value = dgvHienThi2.Columns[i].HeaderText.ToString();
                    exSheet.get_Range(ascii + "4").ColumnWidth = 15;
                    exSheet.get_Range(ascii + "4").BorderAround2();
                }

                //Nhap thong so trong datagridview
                for (int i = 0; i < dgvHienThi2.Rows.Count; i++)
                {
                    if (i<dgvHienThi2.Rows.Count-1)
                    {
                        exSheet.get_Range("A" + (i + 5).ToString()).Font.Bold = false;
                        exSheet.get_Range("A" + (i + 5).ToString()).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        exSheet.get_Range("A" + (i + 5).ToString()).Value = (i + 1).ToString();
                        exSheet.get_Range("A" + (i + 5).ToString()).BorderAround2();
                        ascii = (char)66;
                        for (int j = 0; j < dgvHienThi2.Columns.Count; j++)
                        {
                            exSheet.get_Range(ascii + (i + 5).ToString()).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                            exSheet.get_Range(ascii + (i + 5).ToString()).Value = dgvHienThi2.Rows[i].Cells[j].Value;
                            exSheet.get_Range(ascii + (i + 5).ToString()).BorderAround2();
                            ascii++;
                        }
                    }
                }
                exSheet.Name = "Nhân Viên";
                exBook.Activate(); //kich hoat file excel
                //Thiet lap thuoc tinh savefiledialog

                //saveExcel.Filter = "Excel Document(*.xls)";
                //saveExcel.FilterIndex = 0;
                //saveExcel.AddExtension = true;
                saveExcel.DefaultExt = ".xls";
                if (saveExcel.ShowDialog() == DialogResult.OK)
                {
                    exBook.SaveAs(saveExcel.FileName.ToString()); //Luu file Excel
                    exApp.Visible = true;
                }
                else
                {
                    exApp.Quit();
                }
            }
            else
            {
                MessageBox.Show("Không có danh sách để in");
            }
        }
    }
}
