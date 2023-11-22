using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2._6
{
    internal class LoadSinhvien
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public LoadSinhvien()
        {
            dc = new DataConnection();
        }
        public DataTable getlistSinhvien()
        {
            string sql = "SELECT * FROM SINHVIEN";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InserSinhvien(Sinhvien sv)
        {
            string sql = "INSERT INTO SINHVIEN(MSSV,TEN,BIRTHDAY) VALUES (@MSSV,@TEN,@BIRTHDAY)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MSSV", SqlDbType.VarChar).Value = sv.MSSV;
                cmd.Parameters.Add("@Ten", SqlDbType.VarChar).Value = sv.Ten;
                cmd.Parameters.Add("@BIRTHDAY", SqlDbType.VarChar).Value = sv.Birthday;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool UpdateSinhvien(Sinhvien sv)
        {
            string sql = "UPDATE SINHVIEN SET MSSV = @MSSV , TEN = @TEN , BIRTHDAY = @BIRTHDAY WHERE ID = @ID";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = sv.ID;
                cmd.Parameters.Add("@MSSV", SqlDbType.VarChar).Value = sv.MSSV;
                cmd.Parameters.Add("@Ten", SqlDbType.VarChar).Value = sv.Ten;
                cmd.Parameters.Add("@BIRTHDAY", SqlDbType.VarChar).Value = sv.Birthday;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool DeleteSinhvien(Sinhvien sv)
        {
            string sql = "DELETE SINHVIEN WHERE ID = @ID";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = sv.ID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
