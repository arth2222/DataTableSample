using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DataTableSample
{
    public class DBLayer
    {
        public DataTable GetAllTeachers()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnAir"].ConnectionString;
            DataTable dt=new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Person", conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);
               
                reader.Close();
                conn.Close();
            }
            return dt;
        }

        public DataTable GetTeacherByName(string name)
        {
            SqlParameter param;
            var connectionString = ConfigurationManager.ConnectionStrings["ConnAir"].ConnectionString;
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM person where navn=@name", conn);
                cmd.CommandType = CommandType.Text;

                //params here
                param = new SqlParameter("@name", SqlDbType.NVarChar);
                param.Value = name;
                cmd.Parameters.Add(param);

                SqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);

                reader.Close();
                conn.Close();
            }
            return dt;
        }

        /// <summary>BrendonStuff
        /// Updatetes one col.Text is the param that is stored in db
        /// </summary>
        /// <param name="text"></param>
        public void UpdateText(string text,string slot)
        {
            SqlParameter param;
            var connectionString = ConfigurationManager.ConnectionStrings["ConnAir"].ConnectionString;
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                
                SqlCommand cmd = new SqlCommand("UPDATE YourTable SET [" + slot +"]=@param where id=1", conn);
                cmd.CommandType = CommandType.Text;

                //params here
                param = new SqlParameter("@param", SqlDbType.NVarChar);
                param.Value = text;
                cmd.Parameters.Add(param);

                SqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);

                reader.Close();
                conn.Close();
            }
        }
    }
}