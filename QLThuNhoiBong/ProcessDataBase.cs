using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLThuNhoiBong
{
    class ProcessDataBase
    {
        public string sql = "Data Source=DESKTOP-CTJL81R;Initial Catalog=TNB;User ID=sa;Password=31051999";
        public SqlConnection conn = null;
        public void KetNoiCSDL()
        {
            conn = new SqlConnection(sql);
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }   
        private void DongKetNoiCSDL()
        {
            if(conn.State!=ConnectionState.Closed)
            {
                conn.Close();

            }
        }
        public DataTable DocBang(string sql)
        {
            DataTable dt = new DataTable();
            KetNoiCSDL();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql,conn);
            sqlDataAdapter.Fill(dt);
            DongKetNoiCSDL();
            return dt;
            
        }
        public void CapNhapDuLieu(string sql)
        {
            KetNoiCSDL();
            
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn;
            sqlCommand.CommandText = sql;
            
            sqlCommand.ExecuteNonQuery();
            DongKetNoiCSDL();
        }
        public void CapNhapDuLieuAnh(byte []sql,string x)
        {
            KetNoiCSDL();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn;
            sqlCommand.CommandText = x;
            sqlCommand.Parameters.AddWithValue("[Anh]",sql);

            sqlCommand.ExecuteNonQuery();
            DongKetNoiCSDL();
        }
        
    }
}
