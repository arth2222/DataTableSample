using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataTableSample
{
    public partial class TextFromDB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Labelens tekst får det som metoden returnerer. Dvs det som ligger i tabellen.
            LabelTextFromDB.Text = GetTextFromDB();
        }

        /// <summary>
        /// Gets the text from a column in a database table. Database code should be in a owv file/class/project
        /// </summary>
        /// <returns>string</returns>
        public string GetTextFromDB()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnCms"].ConnectionString;
            string textFromDB = "";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Text1 FROM TextTable", conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    textFromDB = (string)reader[0];
                }

                reader.Close();
                conn.Close();
            }
            return textFromDB;
        }
    }
}