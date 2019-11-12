using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLThuNhoiBong
{
    public partial class NhanVien : Form
    {
        ProcessDataBase connv1 = new ProcessDataBase();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        string sqlfrom = "FROM tbl_NhanVien left join tbl_CongViec on tbl_NhanVien.MaCV = tbl_CongViec.MaCV left join tbl_HoaDonBan on tbl_NhanVien.MaNV = tbl_HoaDonBan.MaNV left join tbl_HoaDonNhap on tbl_NhanVien.MaNV = tbl_HoaDonNhap.MaNV";

        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            string sql1 = "SELECT tbl_NhanVien.MaNV as [Mã Nhân Viên] , TenNV as [Tên Nhân Viên] , IIF(GioiTinh='True',N'Nam',N'Nữ') as [Giới Tính] , DienThoai as [Điện Thoại] , TenCV as [Công Việc] " + sqlfrom;
            dt1 = connv1.DocBang(sql1);
            dgvHienThi.DataSource = dt1;
        }

        
        private void DataGridView1_Click(object sender, EventArgs e)
        {
            txbMaNV.Text = dgvHienThi.CurrentRow.Cells["Mã Nhân Viên"].Value.ToString();
            string sqlMaNV = " WHERE tbl_NhanVien.MaNV='" + txbMaNV.Text + "'";
            string sql2 = "SELECT * " + sqlfrom + sqlMaNV;
            dt2 = connv1.DocBang(sql2);
            try
            {
                txbTenNV.Text = dt2.Rows[0]["TenNV"].ToString();
                txbGioiTinh.Text = dgvHienThi.CurrentRow.Cells["Giới Tính"].Value.ToString();
                dtpNgaySinh.Text = dt2.Rows[0]["NgaySinh"].ToString();
                txbDienThoai.Text = dt2.Rows[0]["DienThoai"].ToString();
                txbDiaChi.Text = dt2.Rows[0]["DiaChi"].ToString();
                txbCongViec.Text = dt2.Rows[0]["TenCV"].ToString();
                txbMucLuong.Text = dt2.Rows[0]["MucLuong"].ToString();
            }
            catch (Exception)
            {
                txbTenNV.Clear();
                txbGioiTinh.Clear();
                dtpNgaySinh.Text = "";
                txbDienThoai.Clear();
                txbDiaChi.Clear();
                txbCongViec.Clear();
                txbMucLuong.Clear();
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            NhanVien_Them nhanvien_them = new NhanVien_Them();
            nhanvien_them.Show();
        }

        private void DgvHienThi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string chitiet = dgvHienThi.CurrentRow.Cells["Mã Nhân Viên"].Value.ToString();
            NhanVien_ChiTiet form_ChiTiet = new NhanVien_ChiTiet(chitiet);
            form_ChiTiet.Show();
        }

        private void BtnRefreshdgv_Click(object sender, EventArgs e)
        {
            string sql1 = "SELECT tbl_NhanVien.MaNV as [Mã Nhân Viên] , TenNV as [Tên Nhân Viên] , IIF(GioiTinh='True',N'Nam',N'Nữ') as [Giới Tính] , DienThoai as [Điện Thoại] , TenCV as [Công Việc] " + sqlfrom;
            dt1 = connv1.DocBang(sql1);
            dgvHienThi.DataSource = dt1;
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            NhanVien_TimKiem form_NhanVien_TimKiem = new NhanVien_TimKiem();
            form_NhanVien_TimKiem.Show();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa không ?","Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (txbMaNV.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn dữ liệu");
                }
                else
                {
                    connv1.CapNhapDuLieu("DELETE FROM tbl_NhanVien WHERE MaNV='" +txbMaNV.Text+"'");
                    BtnRefreshdgv_Click(null, null);
                }
            }
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            if (dgvHienThi.Rows.Count > 0) //TH co du lieu de ghi
            {
                Excel.Application exApp = new Excel.Application();
                Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
                //Dinh dang chung
                Excel.Range tenExcel = (Excel.Range)exSheet.Cells[1, 1];
                tenExcel.Font.Size = 14;
                tenExcel.Font.Bold = true;
                tenExcel.Font.Color = Color.Blue;
                tenExcel.Value = "Form Nhân Viên";
                Excel.Range header = (Excel.Range)exSheet.Cells[3, 1];
                exSheet.get_Range("A3:F3").Merge(true);
                header.Font.Size = 16;
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
                for (int i = 0; i < dgvHienThi.Columns.Count; i++)
                {
                    ascii++;
                    exSheet.get_Range(ascii + "4").Value = dgvHienThi.Columns[i].HeaderText.ToString();
                    exSheet.get_Range(ascii + "4").ColumnWidth = 15;
                    exSheet.get_Range(ascii + "4").BorderAround2();
                }

                //Nhap thong so trong datagridview
                for (int i = 0; i < dgvHienThi.Rows.Count; i++)
                {
                    if (i < dgvHienThi.Rows.Count - 1)
                    {
                        exSheet.get_Range("A" + (i + 5).ToString()).Font.Bold = false;
                        exSheet.get_Range("A" + (i + 5).ToString()).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        exSheet.get_Range("A" + (i + 5).ToString()).Value = (i + 1).ToString();
                        exSheet.get_Range("A" + (i + 5).ToString()).BorderAround2();
                        ascii = (char)66;
                        for (int j = 0; j < dgvHienThi.Columns.Count; j++)
                        {
                            exSheet.get_Range(ascii + (i + 5).ToString()).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                            exSheet.get_Range(ascii + (i + 5).ToString()).Value = dgvHienThi.Rows[i].Cells[j].Value;
                            exSheet.get_Range(ascii + (i + 5).ToString()).BorderAround2();
                            ascii++;
                        }
                    }
                }
                //exSheet.get_Range((char)65 + "4:" + (char)(65 + dgvHienThi.Columns.Count) + (dgvHienThi.Rows.Count + 3)).BorderAround2();
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
