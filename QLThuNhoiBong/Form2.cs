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
    
    public partial class Form2 : Form
    {
        Login login = new Login();
        PhanQuyen phanQuyen = new PhanQuyen();
        frmMain fm = new frmMain();
        QuanTriVien quanTri = new QuanTriVien();
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(frmMain _fm)
        { 
           fm = _fm;
            InitializeComponent();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
          if(  MessageBox.Show("Bạn có muốn thoát không ?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                fm.Close();

            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (phanQuyen.CV(comboBox1.Text, comboBox2.Text) == 1)
            {
                if (checkBox1.Checked == true)
                {

                    comboBox1.Items.Add(comboBox1.Text);
                    
                }
                Visible = false;
                quanTri.Visible = true;

            }
            else
            {
                Visible = false;
                fm.Visible = true;

            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
