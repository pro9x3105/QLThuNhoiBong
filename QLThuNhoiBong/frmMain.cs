using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.IO;

namespace QLThuNhoiBong
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ProcessDataBase dtBase = new ProcessDataBase();
        public frmMain()
        {
            InitializeComponent();
        }
        private Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        private void Ribbon_Click(object sender, EventArgs e)
        {

        }

        private void BarButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void BarButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DataTable dataTable = dtBase.DocBang("select * from tbl_DMHangHoa ");
            dataGridView1.DataSource = dataTable;



        }

        private void BarButtonItem37_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BarListItem2_ListItemClick(object sender, ListItemClickEventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Visible = true;
            this.Visible = false;
        }

        private void BarHeaderItem7_ItemClick(object sender, ItemClickEventArgs e)
        {

            Form2 form2 = new Form2(this);
            form2.Visible = true;
            this.Visible = false;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("" + dataGridView1.CurrentRow.Cells[12].Value.ToString());

       /*     textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();//in gia tri hien thoi o cot 0 
                                                                               //txtTenCL.Text = dgvChatLieu.CurrentRow.Cells[1].Value.ToString();//in gia tri hien thoi o cot 1
            imageList1.Images.Add(ByteToImg(dataGridView1.CurrentRow.Cells[13].Value.ToString()));
            imageList1.ImageSize = new Size(132, 132);
            this.listView1.View = View.LargeIcon;
            for (int counter = 0; counter < imageList1.Images.Count; counter++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = counter;
                this.listView1.Items.Add(item);
            }
            this.listView1.LargeImageList = imageList1;*/
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("" + dataGridView1.CurrentRow.Cells[12].Value.ToString());
       /*     imageList1.Images.Add(ByteToImg(dataGridView1.CurrentRow.Cells[12].Value.ToString()));
            imageList1.ImageSize = new Size(132, 132);
            this.listView1.View = View.LargeIcon;
            for (int counter = 0; counter < imageList1.Images.Count; counter++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = counter;
                this.listView1.Items.Add(item);
            }
            this.listView1.LargeImageList = imageList1;*/
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + dataGridView1.CurrentRow.Cells[12].Value.ToString());
        /*    textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();//in gia tri hien thoi o cot 0 
                                                                               //txtTenCL.Text = dgvChatLieu.CurrentRow.Cells[1].Value.ToString();//in gia tri hien thoi o cot 1
            imageList1.Images.Add(ByteToImg(dataGridView1.CurrentRow.Cells[13].Value.ToString()));
            imageList1.ImageSize = new Size(132, 132);
            this.listView1.View = View.LargeIcon;
            for (int counter = 0; counter < imageList1.Images.Count; counter++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = counter;
                this.listView1.Items.Add(item);
            }
            this.listView1.LargeImageList = imageList1;*/
        }
    }
}