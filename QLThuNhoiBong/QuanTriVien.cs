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
    public partial class QuanTriVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public QuanTriVien()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DuLieu duLieu = new DuLieu();
            duLieu.Visible = true;
            this.Visible = false;
        }

        private void QuanTriVien_Load(object sender, EventArgs e)
        {

        }
    }
}