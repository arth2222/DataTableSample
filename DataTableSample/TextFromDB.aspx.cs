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
            LabelParagraf1.Text = GetTextFromParagraf1();
            bool loggedIn = true;

            if(loggedIn)//hack, men du skjønner  vel at du må bruke ekte login her....
            {
                TextBoxEditOnPage.Visible = true;
                TextBoxEditOnPage.Text = GetTextFromDB();//henter text fra db, det som er nå, inn til textbox
                ButtonEdit.Visible = true;
                //husk å ha en knapp for UPDATE
            }
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

        public string GetTextFromParagraf1()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnCms"].ConnectionString;
            string textFromDB = "";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Paragraf1 FROM TextTable", conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    textFromDB = (string)reader[0];
                }

                reader.Close();
                conn.Close();
            }
            return textFromDB;
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            //todo kode for insert
        }

        protected void ButtonEdit_Click(object sender, EventArgs e)
        {
            
        }
    }
}