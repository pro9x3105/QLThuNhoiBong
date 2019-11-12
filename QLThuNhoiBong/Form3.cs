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
    
    public partial class Form3 : Form
    {
        Form2 form2 = new Form2();

        public Form3(Form2 _form2)
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
