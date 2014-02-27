using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;
namespace BeatLive
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        Random rnd = new Random();
        string s = "0aA1bB2cC3dD4eE5fF6gG7hH8iI9jJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ";
        string id;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["id"] != null)
                id = (string)Session["id"];
            else
                Response.Redirect("Login.aspx");





        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection C = new SqlConnection("Server=d968f873-9ef9-4654-aabd-a2d80114724d.sqlserver.sequelizer.com;Database=dbd968f8739ef94654aabda2d80114724d;User ID=svthayatirbfcwpp;Password=VJLZpWcGhYgbhYj4dC3gnQ5hTuQS6uzCMgyp52c4Wojj28NCDgiKaBxeMCf4fsKV;");
            C.Open();

            if (id == null)
                Response.Write("<h1>Please log in!</h1>");
            else
            {

                string f = "";
                for (int i = 0; i < 5; i++)
                    f += s[rnd.Next(0, s.Length - 1)];
                f += ".mp3";
                SqlCommand u = new SqlCommand("Insert into " + id + "([name],artist,[file]) values (@n,@a,@f)", C);
                u.Parameters.Add(new SqlParameter("@n", TextBox1.Text));
                u.Parameters.Add(new SqlParameter("@a", TextBox2.Text));
                u.Parameters.Add(new SqlParameter("@f", f));
                u.ExecuteNonQuery();
                File.WriteAllBytes(Path.Combine(Server.MapPath("~"), id, "Music", f), FileUpload1.FileBytes);
                TextBox1.Text = "";
                TextBox2.Text = "";
                C.Close();
            }


        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection C = new SqlConnection("Server=d968f873-9ef9-4654-aabd-a2d80114724d.sqlserver.sequelizer.com;Database=dbd968f8739ef94654aabda2d80114724d;User ID=svthayatirbfcwpp;Password=VJLZpWcGhYgbhYj4dC3gnQ5hTuQS6uzCMgyp52c4Wojj28NCDgiKaBxeMCf4fsKV;");
            C.Open();
            SqlCommand u = new SqlCommand("UPDATE Radios SET about = @n where [name] = '" + id + "'", C);
            u.Parameters.Add(new SqlParameter("@n", TextBox3.Text));
            u.ExecuteNonQuery();
            C.Close();
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection C = new SqlConnection("Server=d968f873-9ef9-4654-aabd-a2d80114724d.sqlserver.sequelizer.com;Database=dbd968f8739ef94654aabda2d80114724d;User ID=svthayatirbfcwpp;Password=VJLZpWcGhYgbhYj4dC3gnQ5hTuQS6uzCMgyp52c4Wojj28NCDgiKaBxeMCf4fsKV;");
            C.Open();
            SqlCommand u = new SqlCommand("UPDATE Radios SET news = @n where [name] = '" + id +"'", C);
            u.Parameters.Add(new SqlParameter("@n", TextBox4.Text));
            u.ExecuteNonQuery();
            C.Close();
        }
    }
}
