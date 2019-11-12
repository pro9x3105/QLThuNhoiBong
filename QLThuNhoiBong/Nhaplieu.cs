using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLThuNhoiBong
{
    public partial class NhapLieu : Form
    {
        ProcessDataBase db = new ProcessDataBase();
        public NhapLieu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                if (string.IsNullOrEmpty(file))
                {
                    return;
                }
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                textBox8.Text = openFileDialog1.FileName;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {try
            {


              //  pictureBox1.Image.Save(stream, ImageFormat.Jpeg);//chuyen anh thanh chuoi byte)
            string    sql = "INSERT  [dbo].[tbl_DMHangHoa] ([MaHang], [TenHangHoa], [MaLoaiThu], [MaKichThuoc], [MaLoaiBong], [MaLoaiLong], [MaMau], [MaNuocSX], [SoLuong], [DonGiaNhap], [DonGiaBan],[ThoiGianBH],[Anh],[GhiChu]) VALUES (N'" + textBox1.Text.Trim() + "',N'" + textBox2.Text.Trim() + "',N'" + textBox3.Text.Trim() + "',N'" + textBox4.Text.Trim() + "',N'" + textBox5.Text.Trim() + "',N'" + textBox6.Text.Trim() + "',N'" + textBox7.Text.Trim() + "',N'" + textBox12.Text.Trim() + "',N'" + textBox11.Text.Trim() + "',N'" + textBox10.Text.Trim() + "',N'" + textBox9.Text.Trim() + "', '"+"1011999"+ "','"+ Convert.ToBase64String(converImgToByte()).Trim()+"','"+ "m"+"')";

             //   db.KetNoiCSDL();
                /// sql = "INSERT into [tbl_DMHangHoa] value (@MaHang,@Anh)";
                db.CapNhapDuLieu(sql);
                
           //     db.CapNhapDuLieuAnh(convertImageToByte(),sql);
         ////   sqlCommand.Parameters.AddWithValue("@MaHang", "H0006");
          ///      sqlCommand.Parameters.AddWithValue("@Anh", convertImageToByte());

               MessageBox.Show("Thêm thành công !" );

               // sqlCommand.ExecuteNonQuery();
               
               }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        /*private byte[] convertImageToByte()
        {
            FileStream fs;
            fs = new FileStream(button1.Text, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;


        }
        */
        private byte[] converImgToByte()
        {
            FileStream fs;
            fs = new FileStream(textBox8.Text, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }
        private Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        private void NhapLieu_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Convert.ToBase64String(converImgToByte());
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            imageList1.Images.Add(ByteToImg(richTextBox1.Text));
            imageList1.ImageSize = new Size(132, 132);
            this.listView1.View = View.LargeIcon;
            for (int counter = 0; counter < imageList1.Images.Count; counter++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = counter;
                this.listView1.Items.Add(item);
            }
            this.listView1.LargeImageList = imageList1;
        }
    }
}
