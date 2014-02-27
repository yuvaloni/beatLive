using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace BeatLive
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection("Data Source=d968f873-9ef9-4654-aabd-a2d80114724d.sqlserver.sequelizer.com;Initial Catalog=dbd968f8739ef94654aabda2d80114724d;Persist Security Info=True;User ID=svthayatirbfcwpp;Password=VJLZpWcGhYgbhYj4dC3gnQ5hTuQS6uzCMgyp52c4Wojj28NCDgiKaBxeMCf4fsKV");
            SqlCommand t = new SqlCommand("SELECT * FROM Radios", c);
            c.Open();
            SqlDataReader r = t.ExecuteReader();

            while (r.Read())
            {
                 if((string)r[2]==TextBox1.Text && (string)r[3]==TextBox2.Text)
                 {
                     Session["id"] = (string)r[0];
                     Response.Redirect("CPanel.aspx");
                 }


            }
            Response.Write("Invalid detail, please try again");
            TextBox1.Text="";
            TextBox2.Text="";
            r.Close();
        }
    }
}