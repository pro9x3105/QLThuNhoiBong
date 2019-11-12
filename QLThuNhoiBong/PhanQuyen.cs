using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuNhoiBong
{
    class PhanQuyen
    {
        private List<Login> QuanLy=new List<Login>();
        private List<Login> NhanVien=new List<Login>();
        private List<Login> KhachHang =new List<Login>();
        public PhanQuyen()
        {

            Login ak = new Login("admin", "123456");
            Login bk = new Login("nv01", "123456");
            Login ck = new Login("kh01", "123456");
            QuanLy.Add(ak);
           NhanVien.Add(bk);
            KhachHang.Add(ck);
        }
        public void addNhanVien(string a,string b)
        {
            Login A = new Login(a,b);

            NhanVien.Add(A);
        }
        public void addKhachHang(string a, string b)
        {
            
            Login A = new Login(a, b);
            foreach(Login c in QuanLy)
            {
                if (A == c)
                {
                    return;
                }
            }
           KhachHang.Add(A);
        }
        public void addQuanLy(string a, string b)
        {
            Login A = new Login(a, b);

            QuanLy.Add(A);
        }
        public int CV(string a, string b)
        {
            Login login = new Login(a, b);
           for (int i = 0; i < QuanLy.Count; i++)
                if (QuanLy[i].getUser==a&&QuanLy[i].getPassword==b)
                {
                    return 1;
                }
              for (int i = 0; i < NhanVien.Count; i++)
            if (NhanVien[i].getUser == a && NhanVien[i].getPassword == b)
            {
                return 1;
            }
            return -1;
        }
        public Login getQuanLy(int index) { return QuanLy[index]; }
        public Login getNhanVien(int index) { return QuanLy[index]; }
        public Login getKhachHang(int index) { return QuanLy[index]; }

    }
}
