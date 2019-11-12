using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuNhoiBong
{
    public partial class NhanVien_Them : Form
    {
        ProcessDataBase connv1 = new ProcessDataBase();
        DataTable dt;
        public NhanVien_Them()
        {
            InitializeComponent();
            ThemComboBoxCV();
            ThemComboBoxGioiTinh();
        }


        private void NhanVien_Them_Load(object sender, EventArgs e)
        {
            dt = connv1.DocBang("SELECT * FROM tbl_NhanVien left join tbl_CongViec on tbl_NhanVien.MaCV = tbl_CongViec.MaCV");
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
        private void BtnAuto_Click(object sender, EventArgs e)
        {
            int i = 0;
            Boolean check1=false;
            do
            {
                i++;
                string tenAuto = "NV";
                if (i < 10)
                {
                    tenAuto += "000";
                }
                else if (i < 100)
                {
                    tenAuto += "00";
                }
                else if (i < 1000)
                {
                    tenAuto += "0";
                }
                tenAuto += i;
                int dem = 0;
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (dt.Rows[j]["MaNV"].ToString() == tenAuto)
                    {
                        dem++;
                    }
                }
                if (dem == 0)
                {
                    txbMaNV.Text = "" + tenAuto;
                    check1 = true;
                }
            } while (check1 == false);

        }

        private void CbChonMaCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = cbChonMaCV.SelectedItem.ToString();
            DataTable dt2 = new DataTable();
            dt2 = connv1.DocBang("SELECT * FROM tbl_CongViec WHERE MaCV='" + a + "'");
            txbCongViec.Text = dt2.Rows[0]["TenCV"].ToString();
            txbMucLuong.Text = dt2.Rows[0]["MucLuong"].ToString();
        }

        private void BtnQuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLamLai_Click(object sender, EventArgs e)
        {
            txbMaNV.Clear();
            txbTenNV.Clear();
            cbGioiTinh.Text = "";
            dtpNgaySinh.Text = "";
            txbDienThoai.Clear();
            txbDiaChi.Clear();
            cbChonMaCV.Text = "";
            txbCongViec.Clear();
            txbMucLuong.Clear();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (txbMaNV.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã nhân viên");
                    return;
                }
                else if (dt.Rows[i]["MaNV"].ToString() == txbMaNV.Text)
                {
                    MessageBox.Show("Mã nhân viên đã có trong CSDL");
                    txbTenNV.Clear();
                    return;
                }
                else
                {
                    string convertGioiTinh = "";
                    if (cbGioiTinh.Text=="Nam")
                    {
                        convertGioiTinh = "true";
                    }
                    else if (cbGioiTinh.Text=="Nữ")
                    {
                        convertGioiTinh = "false";
                    }
                    else if (cbChonMaCV.Text=="" || cbGioiTinh.Text=="")
                    {
                        MessageBox.Show("Bạn chưa chọn giới tính hoặc mã công việc");
                        return;
                    }
                    if (MessageBox.Show("Bạn có chắc chắn muốn thêm nhân viên", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        connv1.CapNhapDuLieu("INSERT INTO tbl_NhanVien (MaNV,TenNV,GioiTinh,NgaySinh,DienThoai,DiaChi,MaCV) VALUES ('" + txbMaNV.Text + "','" + txbTenNV.Text + "','" + convertGioiTinh + "','" + dtpNgaySinh.Text + "','" + txbDienThoai.Text + "','" + txbDiaChi.Text + "','" + cbChonMaCV.Text + "')");
                        MessageBox.Show("Thêm nhân viên thành công");
                        BtnLamLai_Click(null, null);    //clear het txb
                        NhanVien_Them_Load(null, null);                  
                        return;
                    }
                    
                }
            }

        }
    }
}
