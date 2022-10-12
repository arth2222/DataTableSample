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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        /// <summary>
        /// Binds the grid with rs
        /// </summary>
        private void BindGrid()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnAir"].ConnectionString;
            DataTable dt = new DataTable();

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
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void ButtonSearchTeacher_Click(object sender, EventArgs e)
        {
            DBLayer dbl = new DBLayer();
            GridView1.DataSource = dbl.GetTeacherByName(TextBoxSearchTeacher.Text);
            GridView1.DataBind();
        }
    }
}