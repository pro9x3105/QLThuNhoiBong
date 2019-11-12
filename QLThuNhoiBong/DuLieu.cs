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

namespace QLThuNhoiBong
{
    public partial class DuLieu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DuLieu()
        {
            InitializeComponent();
            openFileDialog1.Title = "Select Picture";
            openFileDialog1.Filter = "Windows Bitmap|*.bmp|JPEG Image|*.jpg|All Files|*.*";

        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

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
                
            }
        }

        private void BarButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}