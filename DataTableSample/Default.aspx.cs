using System;
using System.Collections.Generic;
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
            
        }

        protected void ButtonSearchTeacher_Click(object sender, EventArgs e)
        {
            DBLayer dbl = new DBLayer();
            GridView1.DataSource = dbl.GetTeacherByName(TextBoxSearchTeacher.Text);
            GridView1.DataBind();
        }
    }
}