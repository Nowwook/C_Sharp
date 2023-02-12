using System;
 
using System.Data.SqlClient;
using System.Data;
 
namespace MssqlTestProject
{
    class MssqlLib
    {
        // 접속테스트
        public bool ConnectionTest()
        {
            string connectString = string.Format("Server={0};Database={1};Uid ={2};Pwd={3};", "127.0.0.1", "sampledb", "test", "1234!");
            try
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    conn.Open();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //데이터조회
        public void SelectDB()
        {
            string connectString = string.Format("Server={0};Database={1};Uid ={2};Pwd={3};", "127.0.0.1", "sampledb", "test", "1234!");
            string sql = "select * from UserInfo";

            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Close();
            }
        }

        //INSERT처리
        public void InsertDB(int id, string name)
        {
            string connectString = string.Format("Server={0};Database={1};Uid ={2};Pwd={3};", "127.0.0.1","sampledb", "test", "1234!");
            string sql = $"Insert Into UserInfo  (id,name) values ({id},'{name}')";

            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }

        //데이터조회
        public DataSet GetUserInfo()
        {
            string connectString = string.Format("Server={0};Database={1};Uid ={2};Pwd={3};", "127.0.0.1", "sampledb", "test", "1234!");
            string sql = "select * from [UserInfo]";
            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds);
            }
            return ds;
        }
    }
}
