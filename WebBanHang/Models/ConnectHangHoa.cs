using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebBanHang.Models
{
    public class ConnectHangHoa
    {
        string conStr = "Data Source = LAPTOP-AV\\SQLEXPRESS; database =  QL_THIETBIDIENTU; Integrated Security = true";
        public List<HangHoa> Search(string txt_search)
        {
            List<HangHoa> listHangHoa = new List<HangHoa>();
            SqlConnection con = new SqlConnection(conStr);
            string sql = "Select * from HangHoa where TenHH like '%' + @TenHH + '%'";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            SqlParameter par = new SqlParameter("@TenHH", txt_search);
            cmd.Parameters.Add(par);

            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                HangHoa hanghoa = new HangHoa();
                hanghoa.MaHH = Convert.ToInt32(rdr.GetValue(0).ToString());
                hanghoa.MaNhom = Convert.ToInt32(rdr.GetValue(1).ToString());
                hanghoa.TenHH = rdr.GetValue(2).ToString();
                hanghoa.HinhAnh = rdr.GetValue(3).ToString();
                hanghoa.Gia = float.Parse(rdr.GetValue(4).ToString());
                hanghoa.DonViTinh = rdr.GetValue(5).ToString();
                hanghoa.NoiSX = rdr.GetValue(6).ToString();

                listHangHoa.Add(hanghoa);
            }
            return (listHangHoa);
        }
    }
}