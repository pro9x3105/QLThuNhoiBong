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
    public partial class NhanVien_ChiTiet : Form
    {
        ProcessDataBase connv1 = new ProcessDataBase();
        DataTable dt;
        string maNV = "";
        public NhanVien_ChiTiet(string maNVformNhanVien)
        {
            InitializeComponent();
            maNV = maNVformNhanVien;
        }

        private void NhanVien_ChiTiet_Load(object sender, EventArgs e)
        {
            dt = connv1.DocBang("SELECT * FROM tbl_NhanVien left join tbl_CongViec on tbl_NhanVien.MaCV = tbl_CongViec.MaCV WHERE MaNV='"+maNV+"'");
            txbMaNV.Text = dt.Rows[0]["MaNV"].ToString();
            txbTenNV.Text = dt.Rows[0]["TenNV"].ToString();
            if (dt.Rows[0]["GioiTinh"].ToString() == "True")
            {
                cbGioiTinh.Text = "Nam";
            }
            else if (dt.Rows[0]["GioiTinh"].ToString() == "False")
            {
                cbGioiTinh.Text = "Nữ";
            }
            dtpNgaySinh.Text= dt.Rows[0]["NgaySinh"].ToString();
            txbDienThoai.Text= dt.Rows[0]["DienThoai"].ToString();
            txbDiaChi.Text= dt.Rows[0]["DiaChi"].ToString();
            cbChonMaCV.Text= dt.Rows[0]["MaCV"].ToString();
            txbCongViec.Text= dt.Rows[0]["TenCV"].ToString();
            txbMucLuong.Text= dt.Rows[0]["MucLuong"].ToString();
            ThemComboBoxCV();
            ThemComboBoxGioiTinh();
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

        private void CbChonMaCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = cbChonMaCV.SelectedItem.ToString();
            DataTable dt3 = new DataTable();
            dt3 = connv1.DocBang("SELECT * FROM tbl_CongViec WHERE MaCV='" + a + "'");
            txbCongViec.Text = dt3.Rows[0]["TenCV"].ToString();
            txbMucLuong.Text = dt3.Rows[0]["MucLuong"].ToString();
        }

        private void BtnBanDau_Click(object sender, EventArgs e)
        {
            txbMaNV.Text = dt.Rows[0]["MaNV"].ToString();
            txbTenNV.Text = dt.Rows[0]["TenNV"].ToString();
            if (dt.Rows[0]["GioiTinh"].ToString() == "True")
            {
                cbGioiTinh.Text = "Nam";
            }
            else if (dt.Rows[0]["GioiTinh"].ToString() == "False")
            {
                cbGioiTinh.Text = "Nữ";
            }
            dtpNgaySinh.Text = dt.Rows[0]["NgaySinh"].ToString();
            txbDienThoai.Text = dt.Rows[0]["DienThoai"].ToString();
            txbDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
            cbChonMaCV.Text = dt.Rows[0]["MaCV"].ToString();
            txbCongViec.Text = dt.Rows[0]["TenCV"].ToString();
            txbMucLuong.Text = dt.Rows[0]["MucLuong"].ToString();
        }

        private void BtnQuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu thay đổi ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string convertGioiTinh = "";
                if (cbGioiTinh.Text == "Nam")
                {
                    convertGioiTinh = "true";
                }
                else if (cbGioiTinh.Text == "Nữ")
                {
                    convertGioiTinh = "false";
                }
                try
                {
                    connv1.CapNhapDuLieu("UPDATE tbl_NhanVien SET TenNV='" + txbTenNV.Text + "',GioiTinh='" + convertGioiTinh + "',Ngaysinh='" + dtpNgaySinh.Text + "',DienThoai='" + txbDienThoai.Text + "',Diachi='" + txbDiaChi.Text + "',MaCV='" + cbChonMaCV.Text + "' WHERE MaNV='" + txbMaNV.Text + "'");
                }
                catch (Exception e1)
                {
                    MessageBox.Show("Lỗi update , lỗi : \n"+e1.ToString());
                }
                finally
                {
                    MessageBox.Show("Bạn đã lưu thay đổi thành công");
                    this.Close();
                }
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (txbMaNV.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn dữ liệu");
                }
                else
                {
                    connv1.CapNhapDuLieu("DELETE FROM tbl_NhanVien WHERE MaNV='" + txbMaNV.Text + "'");
                }
            }
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            if (dt!=null) //TH co du lieu de ghi
            {
                Excel.Application exApp = new Excel.Application();
                Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
                //Dinh dang chung
                Excel.Range tenExcel = (Excel.Range)exSheet.Cells[1, 1];
                tenExcel.Font.Size = 14;
                tenExcel.Font.Bold = true;
                tenExcel.Font.Color = Color.Blue;
                tenExcel.Value = "Form Chi Tiết Nhân Viên";
                //Dinh dang tieu de excel
                exSheet.get_Range("A2:E2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                Excel.Range header1 = (Excel.Range)exSheet.Cells[2, 1];
                exSheet.get_Range("A2:B2").Merge(true);
                header1.Font.Bold = true;
                header1.Font.Color = Color.Yellow;
                header1.Value = "Trong SQL ";
                Excel.Range header2 = (Excel.Range)exSheet.Cells[2, 4];
                exSheet.get_Range("D2:E2").Merge(true);
                header2.Font.Bold = true;
                header2.Font.Color = Color.Red;
                header2.Value = "Trong Form ";
                //Nhap thong so trong datagridview
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    char ascii = (char)65;  //A=65
                    exSheet.get_Range(ascii + (i + 3).ToString()).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                    exSheet.get_Range(ascii + (i + 3).ToString()).Font.Bold = true;
                    exSheet.get_Range(ascii + (i + 3).ToString()).Value = dt.Columns[i].ColumnName.ToString();
                    exSheet.get_Range(ascii + (i + 3).ToString()).ColumnWidth = 15;
                    ascii++;
                    exSheet.get_Range(ascii + (i + 3).ToString()).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                    exSheet.get_Range(ascii + (i + 3).ToString()).Value = dt.Rows[0][dt.Columns[i].ColumnName.ToString()].ToString();
                    exSheet.get_Range(ascii + (i + 3).ToString()).ColumnWidth = 15;
                }
                exSheet.get_Range("D3:D12").Font.Bold = true;
                exSheet.get_Range("D3:E12").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.get_Range("D3:E12").ColumnWidth = 15;
                exSheet.get_Range("D3").Value = "Mã Nhân Viên";
                exSheet.get_Range("E3").Value = txbMaNV.Text;
                exSheet.get_Range("D4").Value = "Tên Nhân Viên";
                exSheet.get_Range("E4").Value = txbTenNV.Text;
                exSheet.get_Range("D5").Value = "Giới Tính";
                exSheet.get_Range("E5").Value = cbGioiTinh.Text;
                exSheet.get_Range("D6").Value = "Ngày Sinh";
                exSheet.get_Range("E6").Value = dtpNgaySinh.Text;
                exSheet.get_Range("D7").Value = "Điện Thoại";
                exSheet.get_Range("E7").Value = txbDienThoai.Text;
                exSheet.get_Range("D8").Value = "Địa Chỉ";
                exSheet.get_Range("E8").Value = txbDiaChi.Text;
                exSheet.get_Range("D10").Value = "Mã Công Việc";
                exSheet.get_Range("E10").Value = cbChonMaCV.Text;
                exSheet.get_Range("D11").Value = "Công Việc";
                exSheet.get_Range("E11").Value = txbCongViec.Text;
                exSheet.get_Range("D12").Value = "Mức Lương";
                exSheet.get_Range("E12").Value = txbMucLuong.Text;
                exSheet.get_Range("D3:E12").BorderAround2();

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
