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
        SqlConnection C;
        Random rnd = new Random();
        string s = "0aA1bB2cC3dD4eE5fF6gG7hH8iI9jJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ";
        protected void Page_Load(object sender, EventArgs e)
        {

            C = new SqlConnection("Server=d968f873-9ef9-4654-aabd-a2d80114724d.sqlserver.sequelizer.com;Database=dbd968f8739ef94654aabda2d80114724d;User ID=svthayatirbfcwpp;Password=VJLZpWcGhYgbhYj4dC3gnQ5hTuQS6uzCMgyp52c4Wojj28NCDgiKaBxeMCf4fsKV;");
            C.Open();

            
            
        }
        
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string f = "";
            bool match = false;
            while (match)
            {

                for (int i = 0; i < 5; i++)
                    f += s[rnd.Next(0, s.Length + 1)];
                f += ".mp3";
                SqlCommand t = new SqlCommand("Select * from music", C);
                SqlDataReader r = t.ExecuteReader();
                while(r.Read())
                {
                    if (r[3] == f)
                        match = false;
                }
            }
            SqlCommand u = new SqlCommand("Insert into music values (@n,@a,@f)", C);
            u.Parameters.Add(new SqlParameter("@n", TextBox1.Text));
            u.Parameters.Add(new SqlParameter("@a", TextBox2.Text));
            u.Parameters.Add(new SqlParameter("@f", f));
            u.ExecuteNonQuery();
            File.WriteAllBytes(Path.Combine(Server.MapPath("~"),"Music",f), FileUpload1.FileBytes);

        }
    }
}